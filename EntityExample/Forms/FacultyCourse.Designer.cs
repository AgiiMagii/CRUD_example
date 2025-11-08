namespace EntityExample.Forms
{
    partial class fm_FacultyCourse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_FacultyCourse));
            this.gbFaculties = new System.Windows.Forms.GroupBox();
            this.flPanelFaculties = new System.Windows.Forms.FlowLayoutPanel();
            this.gridCourses = new System.Windows.Forms.DataGridView();
            this.gbCourses = new System.Windows.Forms.GroupBox();
            this.labelAccept = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numScholarship = new System.Windows.Forms.NumericUpDown();
            this.gridSubjects = new System.Windows.Forms.DataGridView();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeleteCourse = new System.Windows.Forms.Label();
            this.buttUpdateCourse = new System.Windows.Forms.Button();
            this.buttAddCourse = new System.Windows.Forms.Button();
            this.listViewLectors = new System.Windows.Forms.ListView();
            this.gbFacultyInfo = new System.Windows.Forms.GroupBox();
            this.buttUpdateFac = new System.Windows.Forms.Button();
            this.buttAddFaculty = new System.Windows.Forms.Button();
            this.labelEditAddress = new System.Windows.Forms.Label();
            this.labelClearFacUI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFacYear = new System.Windows.Forms.ComboBox();
            this.txtFacAddress = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.picFacToUni = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbFaculties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).BeginInit();
            this.gbCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScholarship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubjects)).BeginInit();
            this.gbFacultyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFacToUni)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFaculties
            // 
            this.gbFaculties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbFaculties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbFaculties.Controls.Add(this.flPanelFaculties);
            this.gbFaculties.Location = new System.Drawing.Point(14, 12);
            this.gbFaculties.Name = "gbFaculties";
            this.gbFaculties.Size = new System.Drawing.Size(148, 343);
            this.gbFaculties.TabIndex = 0;
            this.gbFaculties.TabStop = false;
            this.gbFaculties.Text = "Faculties";
            // 
            // flPanelFaculties
            // 
            this.flPanelFaculties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flPanelFaculties.AutoScroll = true;
            this.flPanelFaculties.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flPanelFaculties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flPanelFaculties.Location = new System.Drawing.Point(0, 20);
            this.flPanelFaculties.Name = "flPanelFaculties";
            this.flPanelFaculties.Size = new System.Drawing.Size(148, 322);
            this.flPanelFaculties.TabIndex = 0;
            // 
            // gridCourses
            // 
            this.gridCourses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourses.Location = new System.Drawing.Point(6, 83);
            this.gridCourses.Name = "gridCourses";
            this.gridCourses.Size = new System.Drawing.Size(172, 130);
            this.gridCourses.TabIndex = 2;
            this.gridCourses.SelectionChanged += new System.EventHandler(this.gridCourses_SelectionChanged);
            // 
            // gbCourses
            // 
            this.gbCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCourses.BackColor = System.Drawing.Color.Silver;
            this.gbCourses.Controls.Add(this.labelAccept);
            this.gbCourses.Controls.Add(this.label7);
            this.gbCourses.Controls.Add(this.numScholarship);
            this.gbCourses.Controls.Add(this.gridSubjects);
            this.gbCourses.Controls.Add(this.txtCourseName);
            this.gbCourses.Controls.Add(this.label6);
            this.gbCourses.Controls.Add(this.lblDeleteCourse);
            this.gbCourses.Controls.Add(this.buttUpdateCourse);
            this.gbCourses.Controls.Add(this.buttAddCourse);
            this.gbCourses.Controls.Add(this.gridCourses);
            this.gbCourses.Location = new System.Drawing.Point(8, 196);
            this.gbCourses.Name = "gbCourses";
            this.gbCourses.Size = new System.Drawing.Size(597, 219);
            this.gbCourses.TabIndex = 3;
            this.gbCourses.TabStop = false;
            this.gbCourses.Text = "Courses";
            // 
            // labelAccept
            // 
            this.labelAccept.AutoSize = true;
            this.labelAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccept.Location = new System.Drawing.Point(310, 188);
            this.labelAccept.Name = "labelAccept";
            this.labelAccept.Size = new System.Drawing.Size(33, 25);
            this.labelAccept.TabIndex = 24;
            this.labelAccept.Text = "✔";
            this.labelAccept.Click += new System.EventHandler(this.labelAccept_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Scholarship";
            // 
            // numScholarship
            // 
            this.numScholarship.Location = new System.Drawing.Point(184, 193);
            this.numScholarship.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numScholarship.Name = "numScholarship";
            this.numScholarship.Size = new System.Drawing.Size(120, 20);
            this.numScholarship.TabIndex = 21;
            // 
            // gridSubjects
            // 
            this.gridSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubjects.Location = new System.Drawing.Point(399, 45);
            this.gridSubjects.Name = "gridSubjects";
            this.gridSubjects.Size = new System.Drawing.Size(182, 150);
            this.gridSubjects.TabIndex = 20;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(93, 19);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(172, 20);
            this.txtCourseName.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Course name";
            // 
            // lblDeleteCourse
            // 
            this.lblDeleteCourse.AutoSize = true;
            this.lblDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCourse.Location = new System.Drawing.Point(271, 16);
            this.lblDeleteCourse.Name = "lblDeleteCourse";
            this.lblDeleteCourse.Size = new System.Drawing.Size(33, 25);
            this.lblDeleteCourse.TabIndex = 16;
            this.lblDeleteCourse.Text = "🗑️";
            this.lblDeleteCourse.Click += new System.EventHandler(this.lblDeleteCourse_Click);
            // 
            // buttUpdateCourse
            // 
            this.buttUpdateCourse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttUpdateCourse.Location = new System.Drawing.Point(180, 45);
            this.buttUpdateCourse.Name = "buttUpdateCourse";
            this.buttUpdateCourse.Size = new System.Drawing.Size(85, 24);
            this.buttUpdateCourse.TabIndex = 5;
            this.buttUpdateCourse.Text = "Update";
            this.buttUpdateCourse.UseVisualStyleBackColor = false;
            this.buttUpdateCourse.Click += new System.EventHandler(this.buttUpdateCourse_Click);
            // 
            // buttAddCourse
            // 
            this.buttAddCourse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttAddCourse.Location = new System.Drawing.Point(93, 45);
            this.buttAddCourse.Name = "buttAddCourse";
            this.buttAddCourse.Size = new System.Drawing.Size(85, 24);
            this.buttAddCourse.TabIndex = 4;
            this.buttAddCourse.Text = "Add";
            this.buttAddCourse.UseVisualStyleBackColor = false;
            this.buttAddCourse.Click += new System.EventHandler(this.buttAddCourse_Click);
            // 
            // listViewLectors
            // 
            this.listViewLectors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewLectors.HideSelection = false;
            this.listViewLectors.Location = new System.Drawing.Point(349, 20);
            this.listViewLectors.Name = "listViewLectors";
            this.listViewLectors.Size = new System.Drawing.Size(256, 170);
            this.listViewLectors.TabIndex = 3;
            this.listViewLectors.UseCompatibleStateImageBehavior = false;
            // 
            // gbFacultyInfo
            // 
            this.gbFacultyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFacultyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbFacultyInfo.Controls.Add(this.buttUpdateFac);
            this.gbFacultyInfo.Controls.Add(this.buttAddFaculty);
            this.gbFacultyInfo.Controls.Add(this.labelEditAddress);
            this.gbFacultyInfo.Controls.Add(this.listViewLectors);
            this.gbFacultyInfo.Controls.Add(this.labelClearFacUI);
            this.gbFacultyInfo.Controls.Add(this.label3);
            this.gbFacultyInfo.Controls.Add(this.label2);
            this.gbFacultyInfo.Controls.Add(this.label1);
            this.gbFacultyInfo.Controls.Add(this.comboFacYear);
            this.gbFacultyInfo.Controls.Add(this.txtFacAddress);
            this.gbFacultyInfo.Controls.Add(this.txtFacultyName);
            this.gbFacultyInfo.Controls.Add(this.gbCourses);
            this.gbFacultyInfo.Location = new System.Drawing.Point(168, 12);
            this.gbFacultyInfo.Name = "gbFacultyInfo";
            this.gbFacultyInfo.Size = new System.Drawing.Size(620, 424);
            this.gbFacultyInfo.TabIndex = 4;
            this.gbFacultyInfo.TabStop = false;
            this.gbFacultyInfo.Text = "About Faculty";
            // 
            // buttUpdateFac
            // 
            this.buttUpdateFac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttUpdateFac.Location = new System.Drawing.Point(188, 165);
            this.buttUpdateFac.Name = "buttUpdateFac";
            this.buttUpdateFac.Size = new System.Drawing.Size(85, 23);
            this.buttUpdateFac.TabIndex = 21;
            this.buttUpdateFac.Text = "Update";
            this.buttUpdateFac.UseVisualStyleBackColor = false;
            this.buttUpdateFac.Click += new System.EventHandler(this.buttUpdateFac_Click);
            // 
            // buttAddFaculty
            // 
            this.buttAddFaculty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttAddFaculty.Location = new System.Drawing.Point(101, 165);
            this.buttAddFaculty.Name = "buttAddFaculty";
            this.buttAddFaculty.Size = new System.Drawing.Size(85, 23);
            this.buttAddFaculty.TabIndex = 20;
            this.buttAddFaculty.Text = "Add";
            this.buttAddFaculty.UseVisualStyleBackColor = false;
            this.buttAddFaculty.Click += new System.EventHandler(this.buttAddFaculty_Click);
            // 
            // labelEditAddress
            // 
            this.labelEditAddress.AutoSize = true;
            this.labelEditAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditAddress.Location = new System.Drawing.Point(279, 84);
            this.labelEditAddress.Name = "labelEditAddress";
            this.labelEditAddress.Size = new System.Drawing.Size(26, 18);
            this.labelEditAddress.TabIndex = 19;
            this.labelEditAddress.Text = "🖊️";
            this.labelEditAddress.Click += new System.EventHandler(this.labelEditAddress_Click);
            // 
            // labelClearFacUI
            // 
            this.labelClearFacUI.AutoSize = true;
            this.labelClearFacUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClearFacUI.Location = new System.Drawing.Point(244, 12);
            this.labelClearFacUI.Name = "labelClearFacUI";
            this.labelClearFacUI.Size = new System.Drawing.Size(29, 31);
            this.labelClearFacUI.TabIndex = 18;
            this.labelClearFacUI.Text = "🗋";
            this.labelClearFacUI.Click += new System.EventHandler(this.labelClearFacUI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Established";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Faculty name";
            // 
            // comboFacYear
            // 
            this.comboFacYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFacYear.FormattingEnabled = true;
            this.comboFacYear.Location = new System.Drawing.Point(101, 122);
            this.comboFacYear.Name = "comboFacYear";
            this.comboFacYear.Size = new System.Drawing.Size(121, 21);
            this.comboFacYear.TabIndex = 10;
            // 
            // txtFacAddress
            // 
            this.txtFacAddress.Location = new System.Drawing.Point(101, 84);
            this.txtFacAddress.Name = "txtFacAddress";
            this.txtFacAddress.ReadOnly = true;
            this.txtFacAddress.Size = new System.Drawing.Size(172, 20);
            this.txtFacAddress.TabIndex = 9;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(101, 46);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(172, 20);
            this.txtFacultyName.TabIndex = 5;
            // 
            // picFacToUni
            // 
            this.picFacToUni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picFacToUni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picFacToUni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFacToUni.Image = global::EntityExample.Properties.Resources.Ionic_Ionicons_Arrow_back_128;
            this.picFacToUni.Location = new System.Drawing.Point(17, 364);
            this.picFacToUni.Name = "picFacToUni";
            this.picFacToUni.Size = new System.Drawing.Size(145, 72);
            this.picFacToUni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFacToUni.TabIndex = 5;
            this.picFacToUni.TabStop = false;
            this.picFacToUni.Click += new System.EventHandler(this.picFacToUni_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fm_FacultyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picFacToUni);
            this.Controls.Add(this.gbFaculties);
            this.Controls.Add(this.gbFacultyInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_FacultyCourse";
            this.Text = "Faculties and courses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_FacultyCourse_FormClosing);
            this.Load += new System.EventHandler(this.fm_FacultyCourse_Load);
            this.gbFaculties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).EndInit();
            this.gbCourses.ResumeLayout(false);
            this.gbCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScholarship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubjects)).EndInit();
            this.gbFacultyInfo.ResumeLayout(false);
            this.gbFacultyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFacToUni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFaculties;
        private System.Windows.Forms.DataGridView gridCourses;
        private System.Windows.Forms.GroupBox gbCourses;
        private System.Windows.Forms.GroupBox gbFacultyInfo;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.FlowLayoutPanel flPanelFaculties;
        private System.Windows.Forms.TextBox txtFacAddress;
        private System.Windows.Forms.ComboBox comboFacYear;
        private System.Windows.Forms.ListView listViewLectors;
        private System.Windows.Forms.PictureBox picFacToUni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClearFacUI;
        private System.Windows.Forms.Label labelEditAddress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttAddFaculty;
        private System.Windows.Forms.Button buttUpdateFac;
        private System.Windows.Forms.Button buttAddCourse;
        private System.Windows.Forms.Label lblDeleteCourse;
        private System.Windows.Forms.Button buttUpdateCourse;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridSubjects;
        private System.Windows.Forms.NumericUpDown numScholarship;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAccept;
    }
}