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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttLectorReg = new System.Windows.Forms.Button();
            this.buttUpdateLec = new System.Windows.Forms.Button();
            this.buttDelLector = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickHire = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLectorFaculty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLectorSurn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butLectorBack = new System.Windows.Forms.Button();
            this.textSearchLectors = new System.Windows.Forms.TextBox();
            this.cbFilterByFaculty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttNext = new System.Windows.Forms.Button();
            this.buttPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLectors)).BeginInit();
            this.groupBLector.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLectors
            // 
            this.gridLectors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLectors.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridLectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLectors.Location = new System.Drawing.Point(12, 66);
            this.gridLectors.Name = "gridLectors";
            this.gridLectors.Size = new System.Drawing.Size(507, 309);
            this.gridLectors.TabIndex = 2;
            this.gridLectors.SelectionChanged += new System.EventHandler(this.gridLectors_SelectionChanged);
            // 
            // txtLectorName
            // 
            this.txtLectorName.Location = new System.Drawing.Point(22, 54);
            this.txtLectorName.Name = "txtLectorName";
            this.txtLectorName.Size = new System.Drawing.Size(221, 20);
            this.txtLectorName.TabIndex = 3;
            // 
            // groupBLector
            // 
            this.groupBLector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBLector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBLector.Controls.Add(this.flowLayoutPanel1);
            this.groupBLector.Controls.Add(this.label6);
            this.groupBLector.Controls.Add(this.label5);
            this.groupBLector.Controls.Add(this.datePickHire);
            this.groupBLector.Controls.Add(this.label4);
            this.groupBLector.Controls.Add(this.cbLectorFaculty);
            this.groupBLector.Controls.Add(this.label3);
            this.groupBLector.Controls.Add(this.txtPhone);
            this.groupBLector.Controls.Add(this.label2);
            this.groupBLector.Controls.Add(this.txtLectorSurn);
            this.groupBLector.Controls.Add(this.label1);
            this.groupBLector.Controls.Add(this.txtLectorName);
            this.groupBLector.Location = new System.Drawing.Point(525, 12);
            this.groupBLector.Name = "groupBLector";
            this.groupBLector.Size = new System.Drawing.Size(263, 426);
            this.groupBLector.TabIndex = 4;
            this.groupBLector.TabStop = false;
            this.groupBLector.Text = "Registration";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.buttLectorReg);
            this.flowLayoutPanel1.Controls.Add(this.buttUpdateLec);
            this.flowLayoutPanel1.Controls.Add(this.buttDelLector);
            this.flowLayoutPanel1.Controls.Add(this.buttCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 257);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 169);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // buttLectorReg
            // 
            this.buttLectorReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttLectorReg.Location = new System.Drawing.Point(3, 3);
            this.buttLectorReg.Name = "buttLectorReg";
            this.buttLectorReg.Size = new System.Drawing.Size(184, 23);
            this.buttLectorReg.TabIndex = 13;
            this.buttLectorReg.Text = "Register";
            this.buttLectorReg.UseVisualStyleBackColor = false;
            this.buttLectorReg.Click += new System.EventHandler(this.buttLectorReg_Click);
            // 
            // buttUpdateLec
            // 
            this.buttUpdateLec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttUpdateLec.Location = new System.Drawing.Point(3, 32);
            this.buttUpdateLec.Name = "buttUpdateLec";
            this.buttUpdateLec.Size = new System.Drawing.Size(184, 23);
            this.buttUpdateLec.TabIndex = 14;
            this.buttUpdateLec.Text = "Update";
            this.buttUpdateLec.UseVisualStyleBackColor = false;
            this.buttUpdateLec.Click += new System.EventHandler(this.buttUpdateLec_Click);
            // 
            // buttDelLector
            // 
            this.buttDelLector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttDelLector.Location = new System.Drawing.Point(3, 61);
            this.buttDelLector.Name = "buttDelLector";
            this.buttDelLector.Size = new System.Drawing.Size(184, 23);
            this.buttDelLector.TabIndex = 15;
            this.buttDelLector.Text = "Delete";
            this.buttDelLector.UseVisualStyleBackColor = false;
            this.buttDelLector.Click += new System.EventHandler(this.buttDelLector_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttCancel.Location = new System.Drawing.Point(3, 90);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hire date";
            // 
            // datePickHire
            // 
            this.datePickHire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickHire.Location = new System.Drawing.Point(22, 229);
            this.datePickHire.Name = "datePickHire";
            this.datePickHire.Size = new System.Drawing.Size(221, 20);
            this.datePickHire.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Faculty";
            // 
            // cbLectorFaculty
            // 
            this.cbLectorFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLectorFaculty.FormattingEnabled = true;
            this.cbLectorFaculty.Location = new System.Drawing.Point(22, 183);
            this.cbLectorFaculty.Name = "cbLectorFaculty";
            this.cbLectorFaculty.Size = new System.Drawing.Size(221, 21);
            this.cbLectorFaculty.TabIndex = 9;
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
            this.txtPhone.Size = new System.Drawing.Size(221, 20);
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
            this.txtLectorSurn.Size = new System.Drawing.Size(221, 20);
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
            // butLectorBack
            // 
            this.butLectorBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLectorBack.Location = new System.Drawing.Point(12, 381);
            this.butLectorBack.Name = "butLectorBack";
            this.butLectorBack.Size = new System.Drawing.Size(157, 47);
            this.butLectorBack.TabIndex = 5;
            this.butLectorBack.Text = "Back";
            this.butLectorBack.UseVisualStyleBackColor = true;
            this.butLectorBack.Click += new System.EventHandler(this.butLectorBack_Click);
            // 
            // textSearchLectors
            // 
            this.textSearchLectors.Location = new System.Drawing.Point(51, 38);
            this.textSearchLectors.Name = "textSearchLectors";
            this.textSearchLectors.Size = new System.Drawing.Size(184, 20);
            this.textSearchLectors.TabIndex = 6;
            this.textSearchLectors.TextChanged += new System.EventHandler(this.textSearchLectors_TextChanged);
            // 
            // cbFilterByFaculty
            // 
            this.cbFilterByFaculty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterByFaculty.FormattingEnabled = true;
            this.cbFilterByFaculty.Location = new System.Drawing.Point(368, 38);
            this.cbFilterByFaculty.Name = "cbFilterByFaculty";
            this.cbFilterByFaculty.Size = new System.Drawing.Size(151, 21);
            this.cbFilterByFaculty.TabIndex = 7;
            this.cbFilterByFaculty.SelectedIndexChanged += new System.EventHandler(this.cbFilterByFaculty_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "🔍";
            // 
            // buttNext
            // 
            this.buttNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttNext.Location = new System.Drawing.Point(444, 381);
            this.buttNext.Name = "buttNext";
            this.buttNext.Size = new System.Drawing.Size(75, 23);
            this.buttNext.TabIndex = 9;
            this.buttNext.Text = "Next";
            this.buttNext.UseVisualStyleBackColor = true;
            this.buttNext.Click += new System.EventHandler(this.buttNext_Click);
            // 
            // buttPrevious
            // 
            this.buttPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttPrevious.Location = new System.Drawing.Point(343, 381);
            this.buttPrevious.Name = "buttPrevious";
            this.buttPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttPrevious.TabIndex = 10;
            this.buttPrevious.Text = "Previous";
            this.buttPrevious.UseVisualStyleBackColor = true;
            this.buttPrevious.Click += new System.EventHandler(this.buttPrevious_Click);
            // 
            // fm_Lector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttPrevious);
            this.Controls.Add(this.buttNext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFilterByFaculty);
            this.Controls.Add(this.textSearchLectors);
            this.Controls.Add(this.butLectorBack);
            this.Controls.Add(this.groupBLector);
            this.Controls.Add(this.gridLectors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_Lector";
            this.Text = "Lector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lector_FormClosing);
            this.Load += new System.EventHandler(this.Lector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLectors)).EndInit();
            this.groupBLector.ResumeLayout(false);
            this.groupBLector.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridLectors;
        private System.Windows.Forms.TextBox txtLectorName;
        private System.Windows.Forms.GroupBox groupBLector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickHire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLectorFaculty;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butLectorBack;
        private System.Windows.Forms.TextBox textSearchLectors;
        private System.Windows.Forms.ComboBox cbFilterByFaculty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttNext;
        private System.Windows.Forms.Button buttPrevious;
    }
}