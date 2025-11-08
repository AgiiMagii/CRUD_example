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
            this.butToStudents = new System.Windows.Forms.Button();
            this.butToLectors = new System.Windows.Forms.Button();
            this.butToFaculties = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butToStudents
            // 
            this.butToStudents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.butToStudents.Location = new System.Drawing.Point(3, 3);
            this.butToStudents.Name = "butToStudents";
            this.butToStudents.Size = new System.Drawing.Size(188, 46);
            this.butToStudents.TabIndex = 4;
            this.butToStudents.Text = "Students";
            this.butToStudents.UseVisualStyleBackColor = true;
            this.butToStudents.Click += new System.EventHandler(this.butToStudents_Click);
            // 
            // butToLectors
            // 
            this.butToLectors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butToLectors.Location = new System.Drawing.Point(3, 55);
            this.butToLectors.Name = "butToLectors";
            this.butToLectors.Size = new System.Drawing.Size(188, 46);
            this.butToLectors.TabIndex = 5;
            this.butToLectors.Text = "Lectors";
            this.butToLectors.UseVisualStyleBackColor = true;
            this.butToLectors.Click += new System.EventHandler(this.butToLectors_Click);
            // 
            // butToFaculties
            // 
            this.butToFaculties.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butToFaculties.Location = new System.Drawing.Point(3, 107);
            this.butToFaculties.Name = "butToFaculties";
            this.butToFaculties.Size = new System.Drawing.Size(188, 46);
            this.butToFaculties.TabIndex = 6;
            this.butToFaculties.Text = "Faculties and courses";
            this.butToFaculties.UseVisualStyleBackColor = true;
            this.butToFaculties.Click += new System.EventHandler(this.butToFaculties_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.butToStudents);
            this.flowLayoutPanel1.Controls.Add(this.butToLectors);
            this.flowLayoutPanel1.Controls.Add(this.butToFaculties);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 450);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // fm_University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_University";
            this.Text = "University";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butToStudents;
        private System.Windows.Forms.Button butToLectors;
        private System.Windows.Forms.Button butToFaculties;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

