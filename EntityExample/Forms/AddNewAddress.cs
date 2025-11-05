using EntityExample.Lib;
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
    public partial class AddNewAddress : Form
    {
        public Address Address { get; private set; }
        Factory factory = new Factory();
        Validation validation = new Validation();
        public long NewAddressId { get; private set; } // Add this property to the AddNewAddress class to fix CS1061
        public AddNewAddress(Address existingAddress = null)
        {
            InitializeComponent();
            if (existingAddress != null) // Rediģēšanas gadījumā
            {
                Address = existingAddress; // Izmanto esošo adresi
                txtRegion.Text = Address.Region; // Aizpilda laukus ar esošās adreses datiem
                txtStreet.Text = Address.Street;
                txtCity.Text = Address.City;
                txtNumber.Text = Address.Number;
            }
            else
            {
                Address = new Address();
            }
        }
        private void AddNewAddress_Load(object sender, EventArgs e)
        {

        }
        private void buttSaveAddress_Click(object sender, EventArgs e)
        {
            if (Address.ID_address == 0)
            {
                Address.Region = txtRegion.Text;
                Address.Street = txtStreet.Text;
                Address.City = txtCity.Text;
                Address.Number = txtNumber.Text;
                List<string> errors = validation.AddressValidation(Address);
                Address = factory.RegAddress(Address);
                NewAddressId = Address.ID_address;
            }
            else
            {
                Address.Region = txtRegion.Text;
                Address.Street = txtStreet.Text;
                Address.City = txtCity.Text;
                Address.Number = txtNumber.Text;
                List<string> errors = validation.AddressValidation(Address);
                factory.UpdateAddress(Address);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
