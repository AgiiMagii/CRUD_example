using EntityExample.Forms;
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

namespace EntityExample
{
    public partial class fm_University : Form
    {
        public fm_University()
        {
            InitializeComponent();
            StyleHelper.ApplyFormStyle(this);
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    StyleHelper.ApplyButtonStyle(button);
                }
            }
            StyleHelper.ApplyFlowLayoutPanelStyle(flowLayoutPanel1);
        }
        private void butToStudents_Click(object sender, EventArgs e)
        {
            fm_Student studentForm = new fm_Student(this);
            studentForm.Show();
            studentForm.Location = this.Location;
            studentForm.Size = this.Size;
            this.Hide();
        }
        private void butToLectors_Click(object sender, EventArgs e)
        {
            fm_Lector lectorForm = new fm_Lector(this);
            lectorForm.Show();
            lectorForm.Location = this.Location;
            lectorForm.Size = this.Size;
            this.Hide();
        }
        private void butToFaculties_Click(object sender, EventArgs e)
        {
            fm_FacultyCourse facultyCourseForm = new fm_FacultyCourse(this);
            facultyCourseForm.Show();
            facultyCourseForm.Location = this.Location;
            facultyCourseForm.Size = this.Size;
            this.Hide();
        }
    }
}
