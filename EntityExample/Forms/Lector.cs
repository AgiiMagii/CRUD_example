using EntityExample.Lib;
using EntityExample.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExample.Forms
{
    public partial class fm_Lector : Form
    {
        Factory factory = new Factory();
        Helper helper = new Helper();
        Validation validation = new Validation();
        private readonly fm_University _universityForm;
        private int pageNr = 1;
        private int pageSize = 28;
        private string searchText = string.Empty;
        private string selectedFacultyName = string.Empty;
        private List<LectorView> lectors = new List<LectorView>();
        private List<LectorView> filteredLectors = new List<LectorView>();
        public fm_Lector(fm_University universityForm)
        {
            InitializeComponent();
            _universityForm = universityForm;
        }
        private void Lector_Load(object sender, EventArgs e)
        {
            lectors = factory.GetLectors();
            helper.ReloadGrid(gridLectors, helper.Paging(lectors, pageNr, pageSize));
            gridLectors.Columns["HireDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
            StyleHelper.ApplyGridStyle(gridLectors);
            SetButtonStyle(this);

            LoadComboFaculties();
            LoadComboFilterByFaculty();

            buttPrevious.Enabled = false;
            buttNext.Enabled = (lectors.Count > pageSize * pageNr);
        }
        private void LoadComboFilterByFaculty()
        {
            cbFilterByFaculty.DataSource = null;
            List<Faculty> faculties = factory.GetFaculties();
            cbFilterByFaculty.DataSource = faculties;
            cbFilterByFaculty.DisplayMember = "Name";
            cbFilterByFaculty.ValueMember = "ID_faculty";
            cbFilterByFaculty.SelectedIndex = -1;
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
        private void Lector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_universityForm.Visible)
                Application.Exit();
        }
        private void LoadComboFaculties()
        {
            cbLectorFaculty.DataSource = null;
            List<Faculty> faculties = factory.GetFaculties();
            cbLectorFaculty.DataSource = faculties;
            cbLectorFaculty.DisplayMember = "Name";
            cbLectorFaculty.ValueMember = "ID_faculty";
            cbLectorFaculty.SelectedIndex = -1;
        }
        private void buttLectorReg_Click(object sender, EventArgs e)
        {
            Lector lector = new Lector
            {
                Name = txtLectorName.Text,
                Surname = txtLectorSurn.Text,
                Phone = txtPhone.Text,
                HireDate = datePickHire.Value,
                ID_faculty = (long?)cbLectorFaculty.SelectedValue
            };
            List<string> errors = validation.LectorValidation(lector);
            if (errors.Count == 0)
            {
                try
                {
                    factory.RegLector(lector);
                    MessageBox.Show("Lector registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lectors = factory.GetLectors();
                    helper.ReloadGrid(gridLectors, lectors);
                    gridLectors.Columns["HireDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
                    helper.ClearForm(Controls);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error registering lector:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string errorMessage = string.Join("\n", errors);
                MessageBox.Show(errorMessage, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridLectors_SelectionChanged(object sender, EventArgs e)
        {
            if (gridLectors.SelectedRows.Count == 0)
                return;

            DataGridViewRow selectedRow = gridLectors.SelectedRows[0];

            txtLectorName.Text = Convert.ToString(selectedRow.Cells["Name"].Value ?? "");
            txtLectorSurn.Text = Convert.ToString(selectedRow.Cells["Surname"].Value ?? "");
            txtPhone.Text = Convert.ToString(selectedRow.Cells["Phone"].Value ?? "");

            if (DateTime.TryParse(Convert.ToString(selectedRow.Cells["HireDate"].Value), out var hireDate))
                datePickHire.Value = hireDate;
            else
                datePickHire.Value = DateTime.Today;

            if (!long.TryParse(Convert.ToString(selectedRow.Cells["ID_lector"].Value), out var lectorId))
            {
                cbLectorFaculty.SelectedIndex = -1;
                return;
            }

            Lector lector = factory.GetLectorById(lectorId);
            if (lector != null && lector.ID_faculty.HasValue)
            {
                cbLectorFaculty.SelectedValue = lector.ID_faculty.Value;
            }
            else
            {
                cbLectorFaculty.SelectedIndex = -1;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            helper.ClearForm(Controls);
        }
        private void buttDelLector_Click(object sender, EventArgs e)
        {
            if (gridLectors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lector to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            long selectedLectorId = (long)gridLectors.SelectedRows[0].Cells["ID_lector"].Value;
            Lector lectorToDelete = factory.GetLectorById(selectedLectorId);
            if (lectorToDelete == null)
            {
                MessageBox.Show("Selected lector not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmResult = MessageBox.Show($"Are you sure to delete lector {lectorToDelete.Name} {lectorToDelete.Surname}?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    factory.DeleteLector(lectorToDelete.ID_lector);
                    MessageBox.Show("Lector deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lectors = factory.GetLectors();

                    helper.ReloadGrid(gridLectors, lectors);
                    helper.ClearForm(Controls);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting lector: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttUpdateLec_Click(object sender, EventArgs e)
        {
            if (gridLectors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lector to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            long selectedLectorId = (long)gridLectors.SelectedRows[0].Cells["ID_lector"].Value;
            Lector lectorToUpdate = factory.GetLectorById(selectedLectorId);
            if (lectorToUpdate == null)
            {
                MessageBox.Show("Selected lector not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lectorToUpdate.Name = txtLectorName.Text;
            lectorToUpdate.Surname = txtLectorSurn.Text;
            lectorToUpdate.Phone = txtPhone.Text;
            lectorToUpdate.ID_faculty = (long?)cbLectorFaculty.SelectedValue;
            lectorToUpdate.HireDate = datePickHire.Value;
            List<string> errors = validation.LectorValidation(lectorToUpdate);
            if (errors.Count == 0)
            {
                factory.UpdateLector(lectorToUpdate);
                MessageBox.Show("Lector updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lectors = factory.GetLectors();
                helper.ReloadGrid(gridLectors, lectors);
                helper.ClearForm(Controls);
            }
            else
            {
                string errorMessage = string.Join("\n", errors);
                MessageBox.Show(errorMessage, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttCancel_Click(object sender, EventArgs e)
        {
            helper.ClearForm(Controls);
            factory.DeleteAddress(factory.GetLastInsertedAddressId());
            LoadComboFaculties();
        }
        private void butLectorBack_Click(object sender, EventArgs e)
        {
            _universityForm.Location = this.Location;
            _universityForm.Size = this.Size;
            _universityForm.Show();
            this.Close();
        }
        private void cbFilterByFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFacultyName = cbFilterByFaculty.Text;
            ApplyFilters();
        }
        private void textSearchLectors_TextChanged(object sender, EventArgs e)
        {
            searchText = textSearchLectors.Text;
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            IEnumerable<LectorView> query = lectors;
            if (!string.IsNullOrEmpty(selectedFacultyName))
            {
                List<long> facultyIds = factory.GetFaculties()
                    .Where(f => f.Name.IndexOf(selectedFacultyName, StringComparison.OrdinalIgnoreCase) >= 0)
                    .Select(f => f.ID_faculty)
                    .ToList();
                query = query.Where(l => l.FacultyName != null && l.FacultyName.IndexOf(selectedFacultyName, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            if (!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(l =>
                    l.Name != null && l.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    l.Surname != null && l.Surname.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    l.Phone != null && l.Phone.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    l.FacultyName != null && l.FacultyName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (l.HireDate.HasValue && l.HireDate.Value.ToString("dd.MM.yyyy").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                );
            }
            filteredLectors = query.ToList();
            pageNr = 1;
            Paging();
            helper.ReloadGrid(gridLectors, helper.Paging(filteredLectors, pageNr, pageSize));
        }
        private void Paging()
        {
            List<LectorView> listObject = filteredLectors.Count > 0 ? filteredLectors : lectors;
            buttPrevious.Enabled = (pageNr > 1);
            buttNext.Enabled = (listObject.Count > pageSize * pageNr);
            helper.ReloadGrid(gridLectors, helper.Paging(listObject, pageNr, pageSize));
        }
        private void buttPrevious_Click(object sender, EventArgs e)
        {
            pageNr--;
            Paging();
        }
        private void buttNext_Click(object sender, EventArgs e)
        {
            pageNr++;
            Paging();
        }
    }
}
