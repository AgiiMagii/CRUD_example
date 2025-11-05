namespace EntityExample
{
    partial class fm_University
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_University));
            this.groupNav = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picToFaculties = new System.Windows.Forms.PictureBox();
            this.picToStudents = new System.Windows.Forms.PictureBox();
            this.picToLectors = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToFaculties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToLectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupNav
            // 
            this.groupNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupNav.Controls.Add(this.label3);
            this.groupNav.Controls.Add(this.label2);
            this.groupNav.Controls.Add(this.label1);
            this.groupNav.Controls.Add(this.picToFaculties);
            this.groupNav.Controls.Add(this.picToStudents);
            this.groupNav.Controls.Add(this.picToLectors);
            this.groupNav.Location = new System.Drawing.Point(12, 12);
            this.groupNav.Name = "groupNav";
            this.groupNav.Size = new System.Drawing.Size(776, 161);
            this.groupNav.TabIndex = 3;
            this.groupNav.TabStop = false;
            this.groupNav.Text = "Navigate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FACULTIES AND COURSES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LECTORS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "STUDENTS";
            // 
            // picToFaculties
            // 
            this.picToFaculties.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picToFaculties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picToFaculties.Image = global::EntityExample.Properties.Resources.University_128;
            this.picToFaculties.Location = new System.Drawing.Point(319, 19);
            this.picToFaculties.Name = "picToFaculties";
            this.picToFaculties.Size = new System.Drawing.Size(133, 119);
            this.picToFaculties.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picToFaculties.TabIndex = 4;
            this.picToFaculties.TabStop = false;
            this.picToFaculties.Click += new System.EventHandler(this.picToFaculties_Click_1);
            // 
            // picToStudents
            // 
            this.picToStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picToStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picToStudents.Image = global::EntityExample.Properties.Resources.Student_256;
            this.picToStudents.Location = new System.Drawing.Point(16, 19);
            this.picToStudents.Name = "picToStudents";
            this.picToStudents.Size = new System.Drawing.Size(133, 119);
            this.picToStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picToStudents.TabIndex = 1;
            this.picToStudents.TabStop = false;
            this.picToStudents.Click += new System.EventHandler(this.picToStudents_Click);
            // 
            // picToLectors
            // 
            this.picToLectors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picToLectors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picToLectors.Image = global::EntityExample.Properties.Resources.Professor_128;
            this.picToLectors.Location = new System.Drawing.Point(168, 19);
            this.picToLectors.Name = "picToLectors";
            this.picToLectors.Size = new System.Drawing.Size(132, 119);
            this.picToLectors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picToLectors.TabIndex = 2;
            this.picToLectors.TabStop = false;
            this.picToLectors.Click += new System.EventHandler(this.picToLectors_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::EntityExample.Properties.Resources.Designer;
            this.pictureBox2.Location = new System.Drawing.Point(12, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(452, 248);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // fm_University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_University";
            this.Text = "University";
            this.groupNav.ResumeLayout(false);
            this.groupNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToFaculties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToLectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picToStudents;
        private System.Windows.Forms.PictureBox picToLectors;
        private System.Windows.Forms.GroupBox groupNav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picToFaculties;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

