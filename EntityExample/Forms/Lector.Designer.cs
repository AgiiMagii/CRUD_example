namespace EntityExample.Forms
{
    partial class fm_Lector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Lector));
            this.gridLectors = new System.Windows.Forms.DataGridView();
            this.txtLectorName = new System.Windows.Forms.TextBox();
            this.groupBLector = new System.Windows.Forms.GroupBox();
            this.buttCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttDelLector = new System.Windows.Forms.Button();
            this.buttUpdateLec = new System.Windows.Forms.Button();
            this.buttLectorReg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickHire = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLectorAddress = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLectorSurn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLectToUni = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLectors)).BeginInit();
            this.groupBLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLectToUni)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLectors
            // 
            this.gridLectors.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridLectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLectors.Location = new System.Drawing.Point(99, 12);
            this.gridLectors.Name = "gridLectors";
            this.gridLectors.Size = new System.Drawing.Size(461, 158);
            this.gridLectors.TabIndex = 2;
            this.gridLectors.SelectionChanged += new System.EventHandler(this.gridLectors_SelectionChanged);
            // 
            // txtLectorName
            // 
            this.txtLectorName.Location = new System.Drawing.Point(22, 54);
            this.txtLectorName.Name = "txtLectorName";
            this.txtLectorName.Size = new System.Drawing.Size(184, 20);
            this.txtLectorName.TabIndex = 3;
            // 
            // groupBLector
            // 
            this.groupBLector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBLector.Controls.Add(this.buttCancel);
            this.groupBLector.Controls.Add(this.label6);
            this.groupBLector.Controls.Add(this.buttDelLector);
            this.groupBLector.Controls.Add(this.buttUpdateLec);
            this.groupBLector.Controls.Add(this.buttLectorReg);
            this.groupBLector.Controls.Add(this.label5);
            this.groupBLector.Controls.Add(this.datePickHire);
            this.groupBLector.Controls.Add(this.label4);
            this.groupBLector.Controls.Add(this.cbLectorAddress);
            this.groupBLector.Controls.Add(this.label3);
            this.groupBLector.Controls.Add(this.txtPhone);
            this.groupBLector.Controls.Add(this.label2);
            this.groupBLector.Controls.Add(this.txtLectorSurn);
            this.groupBLector.Controls.Add(this.label1);
            this.groupBLector.Controls.Add(this.txtLectorName);
            this.groupBLector.Location = new System.Drawing.Point(566, 12);
            this.groupBLector.Name = "groupBLector";
            this.groupBLector.Size = new System.Drawing.Size(222, 426);
            this.groupBLector.TabIndex = 4;
            this.groupBLector.TabStop = false;
            this.groupBLector.Text = "Registration";
            // 
            // buttCancel
            // 
            this.buttCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttCancel.Location = new System.Drawing.Point(22, 393);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(184, 23);
            this.buttCancel.TabIndex = 18;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = false;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "🗋";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttDelLector
            // 
            this.buttDelLector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttDelLector.Location = new System.Drawing.Point(22, 364);
            this.buttDelLector.Name = "buttDelLector";
            this.buttDelLector.Size = new System.Drawing.Size(184, 23);
            this.buttDelLector.TabIndex = 15;
            this.buttDelLector.Text = "Delete";
            this.buttDelLector.UseVisualStyleBackColor = false;
            this.buttDelLector.Click += new System.EventHandler(this.buttDelLector_Click);
            // 
            // buttUpdateLec
            // 
            this.buttUpdateLec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttUpdateLec.Location = new System.Drawing.Point(22, 335);
            this.buttUpdateLec.Name = "buttUpdateLec";
            this.buttUpdateLec.Size = new System.Drawing.Size(184, 23);
            this.buttUpdateLec.TabIndex = 14;
            this.buttUpdateLec.Text = "Update";
            this.buttUpdateLec.UseVisualStyleBackColor = false;
            this.buttUpdateLec.Click += new System.EventHandler(this.buttUpdateLec_Click);
            // 
            // buttLectorReg
            // 
            this.buttLectorReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttLectorReg.Location = new System.Drawing.Point(22, 306);
            this.buttLectorReg.Name = "buttLectorReg";
            this.buttLectorReg.Size = new System.Drawing.Size(184, 23);
            this.buttLectorReg.TabIndex = 13;
            this.buttLectorReg.Text = "Register";
            this.buttLectorReg.UseVisualStyleBackColor = false;
            this.buttLectorReg.Click += new System.EventHandler(this.buttLectorReg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hire date";
            // 
            // datePickHire
            // 
            this.datePickHire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickHire.Location = new System.Drawing.Point(22, 241);
            this.datePickHire.Name = "datePickHire";
            this.datePickHire.Size = new System.Drawing.Size(184, 20);
            this.datePickHire.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // cbLectorAddress
            // 
            this.cbLectorAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLectorAddress.FormattingEnabled = true;
            this.cbLectorAddress.Location = new System.Drawing.Point(22, 183);
            this.cbLectorAddress.Name = "cbLectorAddress";
            this.cbLectorAddress.Size = new System.Drawing.Size(184, 21);
            this.cbLectorAddress.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone number";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(22, 138);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(184, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // txtLectorSurn
            // 
            this.txtLectorSurn.Location = new System.Drawing.Point(22, 96);
            this.txtLectorSurn.Name = "txtLectorSurn";
            this.txtLectorSurn.Size = new System.Drawing.Size(184, 20);
            this.txtLectorSurn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // picLectToUni
            // 
            this.picLectToUni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picLectToUni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLectToUni.Image = global::EntityExample.Properties.Resources.Ionic_Ionicons_Arrow_back_128;
            this.picLectToUni.Location = new System.Drawing.Point(12, 12);
            this.picLectToUni.Name = "picLectToUni";
            this.picLectToUni.Size = new System.Drawing.Size(81, 74);
            this.picLectToUni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLectToUni.TabIndex = 1;
            this.picLectToUni.TabStop = false;
            this.picLectToUni.Click += new System.EventHandler(this.picLectToUni_Click);
            // 
            // fm_Lector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBLector);
            this.Controls.Add(this.gridLectors);
            this.Controls.Add(this.picLectToUni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_Lector";
            this.Text = "Lector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lector_FormClosing);
            this.Load += new System.EventHandler(this.Lector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLectors)).EndInit();
            this.groupBLector.ResumeLayout(false);
            this.groupBLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLectToUni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLectToUni;
        private System.Windows.Forms.DataGridView gridLectors;
        private System.Windows.Forms.TextBox txtLectorName;
        private System.Windows.Forms.GroupBox groupBLector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickHire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLectorAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLectorSurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttLectorReg;
        private System.Windows.Forms.Button buttDelLector;
        private System.Windows.Forms.Button buttUpdateLec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttCancel;
    }
}