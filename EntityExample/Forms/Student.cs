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

namespace EntityExample.Forms
{
    public partial class fm_Student : Form
    {
        Factory factory = new Factory();
        Helper helper = new Helper();
        Validation validation = new Validation();
        private int pageNr = 1;
        private int pageSize = 5;
        private List<StudentView> students = new List<StudentView>();
        private List<StudentView> filteredStudents = new List<StudentView>();
        private readonly fm_University _universityForm;
        public fm_Student(fm_University universityForm)
        {
            InitializeComponent();
            _universityForm = universityForm;
        }
        private void fm_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_universityForm.Visible)
                Application.Exit();
        }
        private void picB_ToUniversity(object sender, EventArgs e)
        {
            _universityForm.Location = this.Location;
            _universityForm.Size = this.Size;
            _universityForm.Show();
            this.Close();
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
            comboStGender.DataSource = Enum.GetValues(typeof(Enums.Gender));
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
                ID_course = (long?)comboCourse.SelectedValue
            };
            List<string> errors = validation.StudentValidation(student);
            if (errors.Count == 0)
            {
                student = factory.RegStudent(student);
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    comboStGender.SelectedItem = Enum.Parse(typeof(Enums.Gender), student.Gender);
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
            if (cb_filterByFaculty.SelectedIndex != -1)
            {
                List<GetStudentsByFaculty_Result> selectedFaculty = factory.GetStudentsByFaculty(cb_filterByFaculty.Text);
                filteredStudents = students.Where(s => selectedFaculty.Any(f => f.ID_student == s.ID_student)).ToList();
                helper.ReloadGrid(grid_Students, helper.Paging(filteredStudents, pageNr, pageSize));
            }
            else
            {
                filteredStudents.Clear();
                helper.ReloadGrid(grid_Students, helper.Paging(students, pageNr, pageSize));
            }
        }
    }
}
