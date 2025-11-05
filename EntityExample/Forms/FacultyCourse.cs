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
    public partial class fm_FacultyCourse : Form
    {
        Factory factory = new Factory();
        Helper helper = new Helper();
        Validation validation = new Validation();
        List<Faculty> faculties = new List<Faculty>();
        List<LectorView> lectors = new List<LectorView>();
        AddressView address = new AddressView();
        private Faculty selectedFaculty = null;
        private Course selectedCourse = null;
        private readonly fm_University _universityForm;
        public fm_FacultyCourse(fm_University universityForm)
        {
            InitializeComponent();
            _universityForm = universityForm;
        }
        private void fm_FacultyCourse_Load(object sender, EventArgs e)
        {
            LoadFacultyButtons();
            LoadComboFacYear();
        }
        private void LoadComboFacYear()
        {
            comboFacYear.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year >= 1700; year--)
            {
                comboFacYear.Items.Add(year.ToString());
            }
            comboFacYear.SelectedIndex = -1;
        }
        private void LoadFacultyButtons()
        {
            faculties = factory.GetFaculties();
            foreach (Faculty faculty in faculties)
            {
                Button facultyButton = new Button
                {
                    Text = faculty.Name,
                    Tag = faculty.ID_faculty,
                    Width = 100,
                    Height = 100,
                    Margin = new Padding(5)
                };
                facultyButton.Click += FacultyButton_Click;
                flPanelFaculties.Controls.Add(facultyButton);
            }
        }
        private void LoadFacultyUI(long id)
        {
            Faculty faculty = factory.GetFaculties().FirstOrDefault(f => f.ID_faculty == id);
            if (faculty == null) return;

            txtFacultyName.Text = faculty.Name;

            if (faculty.ANNO != null)
                comboFacYear.SelectedItem = faculty.ANNO?.Year.ToString();
            else
                comboFacYear.SelectedIndex = -1;

            Address addressEntity = factory.GetAddressById(faculty.ID_address ?? 0);
            address = new AddressView
            {
                ID_address = addressEntity.ID_address,
                Region = addressEntity.Region,
                City = addressEntity.City,
                Street = addressEntity.Street,
                Number = addressEntity.Number,
            };
            string facultyFullAddress = address.FullAddress;
            txtFacAddress.Text = facultyFullAddress;

            listViewLectors.Items.Clear();

            if (faculty.ID_address.HasValue)
            {
                lectors = factory.GetLectors();

                long matchingLectors = address.ID_address;

                foreach (var lector in lectors)
                {
                    Lector lectorEntity = factory.GetLectorById(lector.ID_lector);
                    if (lectorEntity.ID_address == matchingLectors)
                    {
                        ListViewItem item = new ListViewItem($"Prof. {lector.Name} {lector.Surname}, Phone nr: {lector.Phone}");

                        listViewLectors.Items.Add(item);
                        listViewLectors.View = View.List;

                    }
                }
            }
            List<Course> courses = factory.GetCoursesByFacultyId(id);
            helper.ReloadGrid(gridCourses, courses);
        }
        private void fm_FacultyCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_universityForm.Visible)
                Application.Exit();
        }
        private void FacultyButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                long facultyId = (long)clickedButton.Tag;
                selectedFaculty = faculties.FirstOrDefault(f => f.ID_faculty == facultyId);
                if (selectedFaculty != null)
                {
                    LoadFacultyUI(facultyId);
                }
            }

        }
        private void picFacToUni_Click(object sender, EventArgs e)
        {
            _universityForm.Location = this.Location;
            _universityForm.Size = this.Size;
            _universityForm.Show();
            this.Close();
        }
        private void labelClearFacUI_Click(object sender, EventArgs e)
        {
            selectedFaculty = null;
            helper.ClearForm(Controls);
            listViewLectors.Items.Clear();
            gridCourses.DataSource = null;
            txtCourseName.Clear();
        }
        private void AddNewAddressPositioning(Form addAddressForm)
        {
            addAddressForm.StartPosition = FormStartPosition.Manual;
            Point locationOnForm = gbFacultyInfo.PointToScreen(Point.Empty);
            const int extraOffset = 5;
            int newX = locationOnForm.X - ((addAddressForm.Width - gbFacultyInfo.Width) / 2) - extraOffset;
            newX = Math.Max(newX, 0);
            addAddressForm.Location = new Point(newX, locationOnForm.Y);
            addAddressForm.ShowDialog(this);
        }
        private void labelEditAddress_Click(object sender, EventArgs e)
        {
            AddNewAddress addAddressForm = new AddNewAddress();

            if (address.ID_address != 0)
            {
                Address existingAddress = factory.GetAddressById(address.ID_address);
                addAddressForm = new AddNewAddress(existingAddress);
                AddNewAddressPositioning(addAddressForm);
            }
            else
            {
                AddNewAddressPositioning(addAddressForm);
            }
            if (addAddressForm.DialogResult == DialogResult.OK)
            {
                Address newAddress = addAddressForm.Address;
                address = new AddressView
                {
                    ID_address = newAddress.ID_address,
                    Region = newAddress.Region,
                    City = newAddress.City,
                    Street = newAddress.Street,
                    Number = newAddress.Number,
                };
                txtFacAddress.Text = address.FullAddress;
            }
        }
        private void ReloadFacultyButtons()
        { 
            flPanelFaculties.Controls.Clear();
            LoadFacultyButtons();
        }
        private void buttAddFaculty_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty
            {
                Name = txtFacultyName.Text,
                ID_address = address.ID_address != 0 ? (long?)address.ID_address : null,
                ANNO = comboFacYear.SelectedIndex != -1 ? new DateTime(int.Parse(comboFacYear.SelectedItem.ToString()), 1, 1) : (DateTime?)null
            };
            List<string> errors = validation.FacultyValidation(faculty);
            if (errors != null)
            {
                try
                {
                    factory.RegFaculty(faculty);
                    MessageBox.Show("Faculty saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    helper.ClearForm(Controls);
                    listViewLectors.Items.Clear();
                    gridCourses.DataSource = null;
                    ReloadFacultyButtons();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private void buttUpdateFac_Click(object sender, EventArgs e)
        {
            if (selectedFaculty == null)
            {
                MessageBox.Show("Please select a faculty to edit.", "No Faculty Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Faculty facultyToUpdate = factory.GetFaculties().FirstOrDefault(f => f.ID_faculty == selectedFaculty.ID_faculty);
            if (facultyToUpdate != null)
            {
                facultyToUpdate.Name = txtFacultyName.Text;
                facultyToUpdate.ID_address = address.ID_address != 0 ? (long?)address.ID_address : null;
                facultyToUpdate.ANNO = comboFacYear.SelectedIndex != -1 ? new DateTime(int.Parse(comboFacYear.SelectedItem.ToString()), 1, 1) : (DateTime?)null;
                List<string> errors = validation.FacultyValidation(facultyToUpdate);
                if (errors != null)
                {
                    try
                    {
                        factory.UpdateFaculty(facultyToUpdate);
                        MessageBox.Show("Faculty updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        helper.ClearForm(Controls);
                        listViewLectors.Items.Clear();
                        gridCourses.DataSource = null;
                        ReloadFacultyButtons();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
        private void buttAddCourse_Click(object sender, EventArgs e)
        {
            if (selectedFaculty == null)
            {
                MessageBox.Show("Please select a faculty to add a course to.", "No Faculty Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Course course = new Course
            {
                Name = txtCourseName.Text,
                ID_faculty = selectedFaculty.ID_faculty
            };
            List<string> errors = validation.CourseValidation(course);
            if (errors != null)
            {
                try
                {
                    factory.RegCourse(course);
                    MessageBox.Show("Course added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFacultyUI(selectedFaculty.ID_faculty);
                    txtCourseName.Clear();
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        private void buttUpdateCourse_Click(object sender, EventArgs e)
        {
            if (gridCourses.CurrentRow == null)
            {
                MessageBox.Show("Please select a course to update.", "No Course Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedRowIndex = gridCourses.CurrentRow.Index;
            selectedCourse = (Course)gridCourses.Rows[selectedRowIndex].DataBoundItem;
            Course courseToUpdate = factory.GetCoursesByFacultyId(selectedFaculty.ID_faculty)
                                           .FirstOrDefault(c => c.ID_course == selectedCourse.ID_course);
            if (courseToUpdate != null)
            {
                courseToUpdate.Name = txtCourseName.Text;
                List<string> errors = validation.CourseValidation(courseToUpdate);
                if (errors != null)
                {
                    try
                    {
                        factory.UpdateCourse(courseToUpdate);
                        MessageBox.Show("Course updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFacultyUI(selectedFaculty.ID_faculty);
                        txtCourseName.Clear();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
        private void gridCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCourses.CurrentRow != null)
            {
                int selectedRowIndex = gridCourses.CurrentRow.Index;
                selectedCourse = (Course)gridCourses.Rows[selectedRowIndex].DataBoundItem;
                txtCourseName.Text = selectedCourse.Name;
            }
        }
        
    }
}

