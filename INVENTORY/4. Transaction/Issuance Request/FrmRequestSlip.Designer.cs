namespace PMIS
{
    partial class FrmRequestSlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequestSlip));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtRN = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtRC = new System.Windows.Forms.TextBox();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.GrdDetails = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrb = new System.Windows.Forms.TextBox();
            this.txtrd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "College :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Responsibility Center :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "RIS no :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "SAI no :";
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(568, 67);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(110, 20);
            this.txtCode.TabIndex = 4;
            // 
            // txtRN
            // 
            this.txtRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRN.Location = new System.Drawing.Point(568, 13);
            this.txtRN.Name = "txtRN";
            this.txtRN.Size = new System.Drawing.Size(110, 20);
            this.txtRN.TabIndex = 6;
            // 
            // txtSN
            // 
            this.txtSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSN.Location = new System.Drawing.Point(568, 41);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(110, 20);
            this.txtSN.TabIndex = 7;
            // 
            // txtRC
            // 
            this.txtRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRC.Location = new System.Drawing.Point(131, 67);
            this.txtRC.Name = "txtRC";
            this.txtRC.Size = new System.Drawing.Size(367, 20);
            this.txtRC.TabIndex = 3;
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.Location = new System.Drawing.Point(15, 93);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(138, 225);
            this.LstItems.TabIndex = 8;
            this.LstItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstItems_MouseDoubleClick);
            // 
            // GrdDetails
            // 
            this.GrdDetails.AllowUserToAddRows = false;
            this.GrdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDetails.Location = new System.Drawing.Point(159, 93);
            this.GrdDetails.MultiSelect = false;
            this.GrdDetails.Name = "GrdDetails";
            this.GrdDetails.Size = new System.Drawing.Size(521, 226);
            this.GrdDetails.StandardTab = true;
            this.GrdDetails.TabIndex = 3;
            this.GrdDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.GrdDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.GrdDetails.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.GrdDetails_UserDeletedRow);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(487, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Submit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(585, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(577, 326);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(80, 326);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(386, 20);
            this.txtPurpose.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Purpose :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Cost :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Requested by :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Requested date :";
            // 
            // txtrb
            // 
            this.txtrb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrb.Location = new System.Drawing.Point(131, 14);
            this.txtrb.Name = "txtrb";
            this.txtrb.Size = new System.Drawing.Size(162, 20);
            this.txtrb.TabIndex = 1;
            // 
            // txtrd
            // 
            this.txtrd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtrd.Location = new System.Drawing.Point(397, 14);
            this.txtrd.Name = "txtrd";
            this.txtrd.Size = new System.Drawing.Size(101, 20);
            this.txtrd.TabIndex = 5;
            this.txtrd.Value = new System.DateTime(2015, 10, 31, 11, 55, 58, 0);
            // 
            // FrmRequestSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 416);
            this.ControlBox = false;
            this.Controls.Add(this.txtrd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GrdDetails);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.txtrb);
            this.Controls.Add(this.txtRC);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.txtRN);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRequestSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW REQUEST";
            this.Load += new System.EventHandler(this.New_Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtRN;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtRC;
        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.DataGridView GrdDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrb;
        private System.Windows.Forms.DateTimePicker txtrd;

       
    }
}