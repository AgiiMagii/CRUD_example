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
        private List<LectorView> lectors = new List<LectorView>();
        private List<Address> addresses = new List<Address>();
        public fm_Lector(fm_University universityForm)
        {
            InitializeComponent();
            _universityForm = universityForm;
        }
        private void Lector_Load(object sender, EventArgs e)
        {
            lectors = factory.GetLectors();
            helper.ReloadGrid(gridLectors, lectors);
            gridLectors.Columns["HireDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
            LoadComboAddresses();
        }
        private void Lector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_universityForm.Visible)
                Application.Exit();
        }
        private void picLectToUni_Click(object sender, EventArgs e)
        {
            _universityForm.Location = this.Location;
            _universityForm.Size = this.Size;
            _universityForm.Show();
            this.Close();
        }
        private void LoadComboAddresses()
        {
            cbLectorAddress.DataSource = null;
            addresses = factory.GetAddresses();
            List<AddressView> addressViews = addresses.Select(a => new AddressView
            {
                ID_address = a.ID_address,
                Region = a.Region,
                City = a.City,
                Street = a.Street,
                Number = a.Number
            }).ToList();
            cbLectorAddress.DataSource = addressViews;
            cbLectorAddress.DisplayMember = "FullAddress";
            cbLectorAddress.ValueMember = "ID_address";
            cbLectorAddress.SelectedIndex = -1;
        }
        private void buttLectorReg_Click(object sender, EventArgs e)
        {
            long? selectedAddressId = null;
            if (cbLectorAddress.SelectedValue != null && cbLectorAddress.SelectedValue is long id && id > 0)
            {
                selectedAddressId = id;
            }
            Lector lector = new Lector
            {
                Name = txtLectorName.Text,
                Surname = txtLectorSurn.Text,
                Phone = txtPhone.Text,
                HireDate = datePickHire.Value,
                ID_address = selectedAddressId
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
                cbLectorAddress.SelectedIndex = -1;
                return;
            }

            Lector lector = factory.GetLectorById(lectorId);
            if (lector?.ID_address == null)
            {
                cbLectorAddress.SelectedIndex = -1;
                return;
            }
            var addressId = lector.ID_address.Value;
            var currentAddresses = cbLectorAddress.DataSource as IEnumerable<AddressView>;

            if (currentAddresses == null || !currentAddresses.Any(a => a.ID_address == addressId))
                LoadComboAddresses();
            try
            {
                cbLectorAddress.SelectedValue = addressId;
            }
            catch
            {
                cbLectorAddress.SelectedIndex = -1;
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
            lectorToUpdate.HireDate = datePickHire.Value;
            lectorToUpdate.ID_address = (long?)cbLectorAddress.SelectedValue;
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
            LoadComboAddresses();
        }
    }
}
