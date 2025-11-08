namespace EntityExample.Forms
{
    partial class fm_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Student));
            this.grid_Students = new System.Windows.Forms.DataGridView();
            this.buttPageRight = new System.Windows.Forms.Button();
            this.buttPageLeft = new System.Windows.Forms.Button();
            this.labelShowing = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_SName = new System.Windows.Forms.TextBox();
            this.comboStGender = new System.Windows.Forms.ComboBox();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.textSSurn = new System.Windows.Forms.TextBox();
            this.datePickStud = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttRegister = new System.Windows.Forms.Button();
            this.groupStudentReg = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttDelete = new System.Windows.Forms.Button();
            this.buttUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_filterByFaculty = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Students)).BeginInit();
            this.groupStudentReg.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_Students
            // 
            this.grid_Students.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Students.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Students.Location = new System.Drawing.Point(12, 38);
            this.grid_Students.Name = "grid_Students";
            this.grid_Students.Size = new System.Drawing.Size(522, 350);
            this.grid_Students.TabIndex = 1;
            this.grid_Students.SelectionChanged += new System.EventHandler(this.grid_Students_SelectionChanged);
            // 
            // buttPageRight
            // 
            this.buttPageRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttPageRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttPageRight.Enabled = false;
            this.buttPageRight.Location = new System.Drawing.Point(405, 409);
            this.buttPageRight.Name = "buttPageRight";
            this.buttPageRight.Size = new System.Drawing.Size(95, 23);
            this.buttPageRight.TabIndex = 2;
            this.buttPageRight.Text = "Next";
            this.buttPageRight.UseVisualStyleBackColor = false;
            this.buttPageRight.Click += new System.EventHandler(this.buttPageRight_Click);
            // 
            // buttPageLeft
            // 
            this.buttPageLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttPageLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttPageLeft.Enabled = false;
            this.buttPageLeft.Location = new System.Drawing.Point(262, 409);
            this.buttPageLeft.Name = "buttPageLeft";
            this.buttPageLeft.Size = new System.Drawing.Size(95, 23);
            this.buttPageLeft.TabIndex = 3;
            this.buttPageLeft.Text = "Previous";
            this.buttPageLeft.UseVisualStyleBackColor = false;
            this.buttPageLeft.Click += new System.EventHandler(this.buttPageLeft_Click);
            // 
            // labelShowing
            // 
            this.labelShowing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelShowing.AutoSize = true;
            this.labelShowing.Location = new System.Drawing.Point(286, 393);
            this.labelShowing.Name = "labelShowing";
            this.labelShowing.Size = new System.Drawing.Size(13, 13);
            this.labelShowing.TabIndex = 4;
            this.labelShowing.Text = "--";
            // 
            // labelNext
            // 
            this.labelNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNext.AutoSize = true;
            this.labelNext.Location = new System.Drawing.Point(429, 393);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(13, 13);
            this.labelNext.TabIndex = 5;
            this.labelNext.Text = "--";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "-->";
            // 
            // text_SName
            // 
            this.text_SName.Location = new System.Drawing.Point(77, 50);
            this.text_SName.Name = "text_SName";
            this.text_SName.Size = new System.Drawing.Size(151, 20);
            this.text_SName.TabIndex = 7;
            // 
            // comboStGender
            // 
            this.comboStGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStGender.FormattingEnabled = true;
            this.comboStGender.Location = new System.Drawing.Point(77, 145);
            this.comboStGender.Name = "comboStGender";
            this.comboStGender.Size = new System.Drawing.Size(151, 21);
            this.comboStGender.TabIndex = 8;
            // 
            // comboCourse
            // 
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Location = new System.Drawing.Point(77, 190);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(151, 21);
            this.comboCourse.TabIndex = 9;
            // 
            // textSSurn
            // 
            this.textSSurn.Location = new System.Drawing.Point(77, 76);
            this.textSSurn.Name = "textSSurn";
            this.textSSurn.Size = new System.Drawing.Size(151, 20);
            this.textSSurn.TabIndex = 10;
            // 
            // datePickStud
            // 
            this.datePickStud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickStud.Location = new System.Drawing.Point(77, 119);
            this.datePickStud.Name = "datePickStud";
            this.datePickStud.Size = new System.Drawing.Size(151, 20);
            this.datePickStud.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Surname";
            // 
            // dateBirth
            // 
            this.dateBirth.AutoSize = true;
            this.dateBirth.Location = new System.Drawing.Point(9, 125);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(52, 13);
            this.dateBirth.TabIndex = 14;
            this.dateBirth.Text = "Birth date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Course";
            // 
            // buttRegister
            // 
            this.buttRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttRegister.Location = new System.Drawing.Point(3, 32);
            this.buttRegister.Name = "buttRegister";
            this.buttRegister.Size = new System.Drawing.Size(217, 23);
            this.buttRegister.TabIndex = 17;
            this.buttRegister.Text = "Register";
            this.buttRegister.UseVisualStyleBackColor = false;
            this.buttRegister.Click += new System.EventHandler(this.buttRegister_Click);
            // 
            // groupStudentReg
            // 
            this.groupStudentReg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupStudentReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupStudentReg.Controls.Add(this.flowLayoutPanel1);
            this.groupStudentReg.Controls.Add(this.label7);
            this.groupStudentReg.Controls.Add(this.text_SName);
            this.groupStudentReg.Controls.Add(this.label2);
            this.groupStudentReg.Controls.Add(this.label6);
            this.groupStudentReg.Controls.Add(this.textSSurn);
            this.groupStudentReg.Controls.Add(this.comboCourse);
            this.groupStudentReg.Controls.Add(this.label5);
            this.groupStudentReg.Controls.Add(this.label3);
            this.groupStudentReg.Controls.Add(this.datePickStud);
            this.groupStudentReg.Controls.Add(this.dateBirth);
            this.groupStudentReg.Controls.Add(this.comboStGender);
            this.groupStudentReg.Location = new System.Drawing.Point(550, 12);
            this.groupStudentReg.Name = "groupStudentReg";
            this.groupStudentReg.Size = new System.Drawing.Size(238, 427);
            this.groupStudentReg.TabIndex = 18;
            this.groupStudentReg.TabStop = false;
            this.groupStudentReg.Text = "Student Registration";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttDelete);
            this.flowLayoutPanel1.Controls.Add(this.buttRegister);
            this.flowLayoutPanel1.Controls.Add(this.buttUpdate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 128);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // buttDelete
            // 
            this.buttDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttDelete.Location = new System.Drawing.Point(3, 3);
            this.buttDelete.Name = "buttDelete";
            this.buttDelete.Size = new System.Drawing.Size(217, 23);
            this.buttDelete.TabIndex = 19;
            this.buttDelete.Text = "Delete";
            this.buttDelete.UseVisualStyleBackColor = false;
            this.buttDelete.Click += new System.EventHandler(this.buttDelete_Click);
            // 
            // buttUpdate
            // 
            this.buttUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttUpdate.Location = new System.Drawing.Point(3, 61);
            this.buttUpdate.Name = "buttUpdate";
            this.buttUpdate.Size = new System.Drawing.Size(217, 23);
            this.buttUpdate.TabIndex = 18;
            this.buttUpdate.Text = "Update";
            this.buttUpdate.UseVisualStyleBackColor = false;
            this.buttUpdate.Click += new System.EventHandler(this.buttUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "🗋";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(46, 12);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(191, 20);
            this.txtSearchStudent.TabIndex = 20;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "🔍";
            // 
            // cb_filterByFaculty
            // 
            this.cb_filterByFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filterByFaculty.FormattingEnabled = true;
            this.cb_filterByFaculty.Location = new System.Drawing.Point(402, 11);
            this.cb_filterByFaculty.Name = "cb_filterByFaculty";
            this.cb_filterByFaculty.Size = new System.Drawing.Size(132, 21);
            this.cb_filterByFaculty.TabIndex = 22;
            this.cb_filterByFaculty.SelectedValueChanged += new System.EventHandler(this.cb_filterByFaculty_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Filter by faculty";
            // 
            // buttBack
            // 
            this.buttBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttBack.Location = new System.Drawing.Point(12, 409);
            this.buttBack.Name = "buttBack";
            this.buttBack.Size = new System.Drawing.Size(118, 23);
            this.buttBack.TabIndex = 24;
            this.buttBack.Text = "Back";
            this.buttBack.UseVisualStyleBackColor = true;
            this.buttBack.Click += new System.EventHandler(this.buttBack_Click);
            // 
            // fm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_filterByFaculty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.groupStudentReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNext);
            this.Controls.Add(this.labelShowing);
            this.Controls.Add(this.buttPageLeft);
            this.Controls.Add(this.buttPageRight);
            this.Controls.Add(this.grid_Students);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_Student";
            this.Text = "Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_Student_FormClosing);
            this.Load += new System.EventHandler(this.fm_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Students)).EndInit();
            this.groupStudentReg.ResumeLayout(false);
            this.groupStudentReg.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_Students;
        private System.Windows.Forms.Button buttPageRight;
        private System.Windows.Forms.Button buttPageLeft;
        private System.Windows.Forms.Label labelShowing;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_SName;
        private System.Windows.Forms.ComboBox comboStGender;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.TextBox textSSurn;
        private System.Windows.Forms.DateTimePicker datePickStud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttRegister;
        private System.Windows.Forms.GroupBox groupStudentReg;
        private System.Windows.Forms.Button buttDelete;
        private System.Windows.Forms.Button buttUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_filterByFaculty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttBack;
    }
}