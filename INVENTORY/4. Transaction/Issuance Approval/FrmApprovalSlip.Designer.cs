namespace PMIS
{
    partial class FrmApprovalSlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApprovalSlip));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApprove = new System.Windows.Forms.TextBox();
            this.txtIssuedBy = new System.Windows.Forms.TextBox();
            this.txtReceiveBy = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GrdDetails = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.txtApproveDate = new System.Windows.Forms.DateTimePicker();
            this.txtrb = new System.Windows.Forms.TextBox();
            this.txtRC = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtRN = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtrd = new System.Windows.Forms.TextBox();
            this.txtcollege = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Approved  By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Issued By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Received By :";
            // 
            // txtApprove
            // 
            this.txtApprove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprove.Location = new System.Drawing.Point(11, 332);
            this.txtApprove.Name = "txtApprove";
            this.txtApprove.Size = new System.Drawing.Size(160, 23);
            this.txtApprove.TabIndex = 6;
            // 
            // txtIssuedBy
            // 
            this.txtIssuedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedBy.Location = new System.Drawing.Point(11, 376);
            this.txtIssuedBy.Name = "txtIssuedBy";
            this.txtIssuedBy.Size = new System.Drawing.Size(160, 23);
            this.txtIssuedBy.TabIndex = 7;
            // 
            // txtReceiveBy
            // 
            this.txtReceiveBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiveBy.Location = new System.Drawing.Point(11, 421);
            this.txtReceiveBy.Name = "txtReceiveBy";
            this.txtReceiveBy.Size = new System.Drawing.Size(160, 23);
            this.txtReceiveBy.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(458, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 50);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Approve";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(568, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GrdDetails
            // 
            this.GrdDetails.AllowUserToAddRows = false;
            this.GrdDetails.AllowUserToDeleteRows = false;
            this.GrdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDetails.Location = new System.Drawing.Point(11, 94);
            this.GrdDetails.Name = "GrdDetails";
            this.GrdDetails.ReadOnly = true;
            this.GrdDetails.Size = new System.Drawing.Size(661, 178);
            this.GrdDetails.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Issued Date :";
            // 
            // txtIssuedDate
            // 
            this.txtIssuedDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtIssuedDate.Location = new System.Drawing.Point(177, 376);
            this.txtIssuedDate.Name = "txtIssuedDate";
            this.txtIssuedDate.Size = new System.Drawing.Size(130, 23);
            this.txtIssuedDate.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Received Date :";
            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtReceivedDate.Location = new System.Drawing.Point(177, 421);
            this.txtReceivedDate.Name = "txtReceivedDate";
            this.txtReceivedDate.Size = new System.Drawing.Size(130, 23);
            this.txtReceivedDate.TabIndex = 11;
            // 
            // txtApproveDate
            // 
            this.txtApproveDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApproveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtApproveDate.Location = new System.Drawing.Point(177, 332);
            this.txtApproveDate.Name = "txtApproveDate";
            this.txtApproveDate.Size = new System.Drawing.Size(130, 23);
            this.txtApproveDate.TabIndex = 11;
            // 
            // txtrb
            // 
            this.txtrb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrb.Location = new System.Drawing.Point(125, 12);
            this.txtrb.Name = "txtrb";
            this.txtrb.ReadOnly = true;
            this.txtrb.Size = new System.Drawing.Size(162, 23);
            this.txtrb.TabIndex = 19;
            // 
            // txtRC
            // 
            this.txtRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRC.Location = new System.Drawing.Point(125, 65);
            this.txtRC.Name = "txtRC";
            this.txtRC.ReadOnly = true;
            this.txtRC.Size = new System.Drawing.Size(367, 23);
            this.txtRC.TabIndex = 21;
            // 
            // txtSN
            // 
            this.txtSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(562, 39);
            this.txtSN.Name = "txtSN";
            this.txtSN.ReadOnly = true;
            this.txtSN.Size = new System.Drawing.Size(110, 23);
            this.txtSN.TabIndex = 25;
            // 
            // txtRN
            // 
            this.txtRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRN.Location = new System.Drawing.Point(562, 11);
            this.txtRN.Name = "txtRN";
            this.txtRN.ReadOnly = true;
            this.txtRN.Size = new System.Drawing.Size(110, 23);
            this.txtRN.TabIndex = 24;
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(562, 65);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(110, 23);
            this.txtCode.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "SAI no :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "RIS no :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Code :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Responsibility Center :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Requested date :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Requested by :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "College :";
            // 
            // txtrd
            // 
            this.txtrd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrd.Location = new System.Drawing.Point(391, 11);
            this.txtrd.Name = "txtrd";
            this.txtrd.ReadOnly = true;
            this.txtrd.Size = new System.Drawing.Size(101, 23);
            this.txtrd.TabIndex = 26;
            // 
            // txtcollege
            // 
            this.txtcollege.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcollege.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcollege.Location = new System.Drawing.Point(125, 39);
            this.txtcollege.Name = "txtcollege";
            this.txtcollege.ReadOnly = true;
            this.txtcollege.Size = new System.Drawing.Size(367, 23);
            this.txtcollege.TabIndex = 27;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(571, 278);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 31;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(74, 278);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.ReadOnly = true;
            this.txtPurpose.Size = new System.Drawing.Size(386, 20);
            this.txtPurpose.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Purpose :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(504, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Total Cost :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(174, 316);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Approved  Date :";
            // 
            // FrmApprovalSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtcollege);
            this.Controls.Add(this.txtrd);
            this.Controls.Add(this.txtrb);
            this.Controls.Add(this.txtRC);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.txtRN);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtApproveDate);
            this.Controls.Add(this.txtReceivedDate);
            this.Controls.Add(this.txtIssuedDate);
            this.Controls.Add(this.GrdDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReceiveBy);
            this.Controls.Add(this.txtIssuedBy);
            this.Controls.Add(this.txtApprove);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmApprovalSlip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approval Slip";
            this.Load += new System.EventHandler(this.ApprovalSlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApprove;
        private System.Windows.Forms.TextBox txtIssuedBy;
        private System.Windows.Forms.TextBox txtReceiveBy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView GrdDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtIssuedDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtReceivedDate;
        private System.Windows.Forms.DateTimePicker txtApproveDate;
        private System.Windows.Forms.TextBox txtrb;
        private System.Windows.Forms.TextBox txtRC;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtRN;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtrd;
        private System.Windows.Forms.TextBox txtcollege;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}