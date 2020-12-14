namespace PMIS
{
    partial class FrmDeliverySlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliverySlip));
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrdDetails = new System.Windows.Forms.DataGridView();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.txtDeliveryNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdeliverydate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceivedDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(572, 45);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Total Amount :";
            // 
            // GrdDetails
            // 
            this.GrdDetails.AllowUserToAddRows = false;
            this.GrdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDetails.Location = new System.Drawing.Point(152, 71);
            this.GrdDetails.Name = "GrdDetails";
            this.GrdDetails.Size = new System.Drawing.Size(521, 212);
            this.GrdDetails.TabIndex = 5;
            this.GrdDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDetails_CellEndEdit);
            this.GrdDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrdDetails_DataError);
            this.GrdDetails.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.GrdDetails_UserDeletedRow);
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.Location = new System.Drawing.Point(8, 71);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(138, 212);
            this.LstItems.TabIndex = 4;
            this.LstItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstItems_MouseDoubleClick);
            // 
            // txtsupplier
            // 
            this.txtsupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsupplier.Location = new System.Drawing.Point(126, 12);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(547, 20);
            this.txtsupplier.TabIndex = 0;
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeliveryNo.Location = new System.Drawing.Point(126, 39);
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.Size = new System.Drawing.Size(110, 20);
            this.txtDeliveryNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Delivery No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Supplier :";
            // 
            // txtdeliverydate
            // 
            this.txtdeliverydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdeliverydate.Location = new System.Drawing.Point(345, 42);
            this.txtdeliverydate.Name = "txtdeliverydate";
            this.txtdeliverydate.Size = new System.Drawing.Size(117, 20);
            this.txtdeliverydate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Delivery Date :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(580, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(482, 289);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(93, 40);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReceivedBy.Location = new System.Drawing.Point(126, 307);
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.Size = new System.Drawing.Size(110, 20);
            this.txtReceivedBy.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Received By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Received Date :";
            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtReceivedDate.Location = new System.Drawing.Point(345, 310);
            this.txtReceivedDate.Name = "txtReceivedDate";
            this.txtReceivedDate.Size = new System.Drawing.Size(117, 20);
            this.txtReceivedDate.TabIndex = 7;
            // 
            // FrmDeliverySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 339);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReceivedDate);
            this.Controls.Add(this.txtReceivedBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdeliverydate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GrdDetails);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.txtsupplier);
            this.Controls.Add(this.txtDeliveryNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDeliverySlip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DELIVERY SLIP";
            this.Load += new System.EventHandler(this.FrmDeliverySlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GrdDetails;
        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.TextBox txtDeliveryNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtdeliverydate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox txtReceivedBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtReceivedDate;
    }
}