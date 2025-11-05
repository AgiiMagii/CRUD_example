using EntityExample.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExample
{
    public partial class fm_University : Form
    {
        public fm_University()
        {
            InitializeComponent();
        }
        private void picToStudents_Click(object sender, EventArgs e)
        {
            fm_Student studentForm = new fm_Student(this);
            studentForm.Show();
            studentForm.Location = this.Location;
            studentForm.Size = this.Size;
            this.Hide();
        }
        private void picToLectors_Click(object sender, EventArgs e)
        {
            fm_Lector lectorForm = new fm_Lector(this);
            lectorForm.Show();
            lectorForm.Location = this.Location;
            lectorForm.Size = this.Size;
            this.Hide();
        }
        private void picToFaculties_Click_1(object sender, EventArgs e)
        {
            fm_FacultyCourse facultyCourseForm = new fm_FacultyCourse(this);
            facultyCourseForm.Show();
            facultyCourseForm.Location = this.Location;
            facultyCourseForm.Size = this.Size;
            this.Hide();
        }
    }
}
