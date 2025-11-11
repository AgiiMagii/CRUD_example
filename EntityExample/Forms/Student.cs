using EntityExample.Lib;
using EntityExample.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyExcelLibrary;
using MyExcelLibrary.Lib;

namespace EntityExample.Forms
{
    public partial class fm_Student : Form
    {
        // TODO: Add multiselect update functionality in case if course is changed for multiple students or to delete, if course ends

        Factory factory = new Factory();
        Helper helper = new Helper();
        Validation validation = new Validation();
        Excel excel = new Excel();

        private int pageNr = 1;
        private int pageSize = 30;
        private string searchText = string.Empty;
        private string selectedFacultyName = string.Empty;
        private List<StudentView> students = new List<StudentView>();
        private List<StudentView> filteredStudents = new List<StudentView>();
        private readonly fm_University _universityForm;
        public fm_Student(fm_University universityForm)
        {
            InitializeComponent();
            _universityForm = universityForm;
            StyleHelper.ApplyGridStyle(grid_Students);
            SetButtonStyle(this);
        }
        private void SetButtonStyle(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    StyleHelper.ApplyButtonStyle(button);
                }
                if (control.HasChildren)
                {
                    SetButtonStyle(control);
                }
            }
        }
        private void fm_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_universityForm.Visible)
                Application.Exit();
        }
        private void fm_Student_Load(object sender, EventArgs e)
        {
            students = factory.GetStudents();
            
            
            helper.ReloadGrid(grid_Students, helper.Paging(students, pageNr, pageSize));

            LoadComboCourses();
            LoadComboGender();
            LoadFilterCmboCourses();

            buttPageRight.Enabled = (students.Count > pageSize * pageNr);
            buttPageLeft.Enabled = (pageNr > 1);
            labelShowing.Text = students.Count > 0 ? $"{((pageNr - 1) * pageSize + 1)} - {Math.Min(pageNr * pageSize, students.Count)}" : "No entries found";
        }
        private void LoadComboCourses()
        {
            comboCourse.DataSource = factory.GetCourses();
            comboCourse.DisplayMember = "Name";
            comboCourse.ValueMember = "ID_course";
            comboCourse.SelectedIndex = -1;
        }
        private void LoadComboGender()
        {
            comboStGender.DataSource = Enum.GetValues(typeof(Lib.Enums.Gender));
            comboStGender.SelectedIndex = -1;
        }
        private void buttPageRight_Click(object sender, EventArgs e)
        {
            pageNr++;
            Paging();
        }
        private void Paging()
        {
            List<StudentView> listObject = filteredStudents.Count > 0 ? filteredStudents : students;
            buttPageLeft.Enabled = (pageNr > 1);
            buttPageRight.Enabled = (listObject.Count > pageSize * pageNr);
            labelShowing.Text = listObject.Count > 0 ? $"{((pageNr - 1) * pageSize + 1)} - {Math.Min(pageNr * pageSize, listObject.Count)}" : "No entries found";
            labelNext.Text = (buttPageRight.Enabled) ? $"{Math.Min(pageNr * pageSize + 1, listObject.Count)} - {Math.Min((pageNr + 1) * pageSize, listObject.Count)}" : "-";
            helper.ReloadGrid(grid_Students, helper.Paging(listObject, pageNr, pageSize));
        }
        private void buttPageLeft_Click(object sender, EventArgs e)
        {
            pageNr--;
            Paging();
        }
        private void buttRegister_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Name = text_SName.Text,
                Surname = textSSurn.Text,
                BirthYear = datePickStud.Value,
                Gender = comboStGender.SelectedItem.ToString(),
                ID_course = (long?)comboCourse.SelectedValue,
                Scholarship = comboCourse.SelectedValue != null ? factory.GetCourseById(Convert.ToInt64(comboCourse.SelectedValue))?.DefaultScholarship : null
            };
            List<string> errors = validation.StudentValidation(student);
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            student = factory.RegStudent(student);
            MessageBox.Show($"Student {student.Name} {student.Surname} registered successfully with ID {student.ID_student}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            students = factory.GetStudents();
            helper.ReloadGrid(grid_Students, helper.Paging(students, pageNr, pageSize));
            helper.ClearForm(Controls);
        }
        private void grid_Students_SelectionChanged(object sender, EventArgs e)
        {
            if (grid_Students.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grid_Students.SelectedRows[0];
                long studentId = (long)selectedRow.Cells["ID_student"].Value;
                Student student = factory.GetStudentById(studentId);
                if (student != null)
                {
                    text_SName.Text = student.Name;
                    textSSurn.Text = student.Surname;
                    datePickStud.Value = student.BirthYear ?? DateTime.Now;
                    comboStGender.SelectedItem = Enum.Parse(typeof(Lib.Enums.Gender), student.Gender);
                    comboCourse.SelectedValue = student?.ID_course;
                }
            }
        }
        private void buttUpdate_Click(object sender, EventArgs e)
        {
            factory.UpdateStudent(new Student // Updating existing student
            {
                ID_student = (long)grid_Students.SelectedRows[0].Cells["ID_student"].Value, // Get the ID from the selected row
                Name = text_SName.Text, // Updated name from the text box
                Surname = textSSurn.Text,
                BirthYear = datePickStud.Value,
                Gender = comboStGender.SelectedItem.ToString(),
                ID_course = (long?)comboCourse.SelectedValue
            });
            students = factory.GetStudents();
            helper.ReloadGrid(grid_Students, helper.Paging(students, pageNr, pageSize));
            helper.ClearForm(Controls);
        }
        private void buttDelete_Click(object sender, EventArgs e)
        {
            if (grid_Students.SelectedRows.Count > 0)
            {
                long studentId = (long)grid_Students.SelectedRows[0].Cells["ID_student"].Value;
                factory.DeleteStudent(studentId);
                students = factory.GetStudents();
                helper.ReloadGrid(grid_Students, helper.Paging(students, pageNr, pageSize));
                helper.ClearForm(Controls);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            helper.ClearForm(Controls);
        }
        private void LoadFilterCmboCourses()
        {
            List<Faculty> faculties = factory.GetFaculties();
            cb_filterByFaculty.DataSource = faculties;
            cb_filterByFaculty.DisplayMember = "Name";
            cb_filterByFaculty.ValueMember = "ID_faculty";
            cb_filterByFaculty.SelectedIndex = -1;
        }
        private void cb_filterByFaculty_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedFacultyName = cb_filterByFaculty.SelectedIndex != -1 ? cb_filterByFaculty.Text : string.Empty;
            ApplyFilters();
        }
        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            searchText = txtSearchStudent.Text;
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            IEnumerable<StudentView> query = students;
            if (!string.IsNullOrEmpty(selectedFacultyName))
            {
                List<GetStudentsByFaculty_Result> selectedFaculty = factory.GetStudentsByFaculty(selectedFacultyName);
                query = query.Where(s => selectedFaculty.Any(f => f.ID_student == s.ID_student));
            }
            if (!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(s =>
                    s.Name.ToLower().Contains(searchText.ToLower()) ||
                    s.Surname.ToLower().Contains(searchText.ToLower()) ||
                    s.Gender.ToLower().Contains(searchText.ToLower()) ||
                    s.CourseName != null && s.CourseName.ToLower().Contains(searchText.ToLower()) ||
                    s.BirthYear.ToString().Contains(searchText.ToLower())
                );
            }
            filteredStudents = query.ToList();
            pageNr = 1;
            Paging();
            helper.ReloadGrid(grid_Students, helper.Paging(filteredStudents, pageNr, pageSize));
        }
        private void buttBack_Click(object sender, EventArgs e)
        {
            _universityForm.Location = this.Location;
            _universityForm.Size = this.Size;
            _universityForm.Show();
            this.Close();
        }
        private void buttSaveToXls_Click(object sender, EventArgs e)
        {
            List<StudentView> listObject = filteredStudents.Count > 0 ? filteredStudents : students;

            if (grid_Students.Rows.Count == 0)
            {
                MessageBox.Show("No student data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Save Students to Excel"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XLSConfig<StudentView> xLSConfig = new XLSConfig<StudentView>
                {
                    DateFormat = "dd.MM.yyyy",
                    Items = listObject,
                    FileFullPath = saveFileDialog.FileName,
                    TableName = "Students",
                    WorkSheetName = "Students",
                    TableStyles = MyExcelLibrary.Lib.Enums.TableStyles.TableStyleDark10,
                    Author = "Aggy"
                };
                excel.SaveToExcel(xLSConfig);
            }
        }

        private void buttGetFileContent_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Open Excel File"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;
            List<StudentView> studentsFromFile;
            try
            {
                studentsFromFile = excel.LoadFromExcel<StudentView>(filePath) ?? new List<StudentView>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to read Excel file:{Environment.NewLine}{ex.Message}", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            studentsFromFile = studentsFromFile
                .OrderBy(s => s?.Name ?? string.Empty)
                .ThenBy(s => s?.Surname ?? string.Empty)
                .ToList();
            students = studentsFromFile;
            filteredStudents = new List<StudentView>();

            pageNr = 1;
            Paging();

            helper.ReloadGrid(grid_Students, helper.Paging(students, pageNr, pageSize));
        }
    }
}
