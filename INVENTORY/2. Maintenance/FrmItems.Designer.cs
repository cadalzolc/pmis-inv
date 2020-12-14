namespace PMIS
{
    partial class FrmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItems));
            this.btnDelete = new System.Windows.Forms.Button();
            this.GrpItem = new System.Windows.Forms.GroupBox();
            this.CboUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStockNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtItemNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtItemName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.GrdList = new System.Windows.Forms.DataGridView();
            this.GrpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(192, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GrpItem
            // 
            this.GrpItem.Controls.Add(this.CboUnit);
            this.GrpItem.Controls.Add(this.label4);
            this.GrpItem.Controls.Add(this.TxtDescription);
            this.GrpItem.Controls.Add(this.label3);
            this.GrpItem.Controls.Add(this.TxtStockNo);
            this.GrpItem.Controls.Add(this.label2);
            this.GrpItem.Controls.Add(this.TxtItemNo);
            this.GrpItem.Controls.Add(this.label1);
            this.GrpItem.Controls.Add(this.BtnCancel);
            this.GrpItem.Controls.Add(this.TxtItemName);
            this.GrpItem.Controls.Add(this.BtnSave);
            this.GrpItem.Enabled = false;
            this.GrpItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpItem.Location = new System.Drawing.Point(6, 47);
            this.GrpItem.Name = "GrpItem";
            this.GrpItem.Size = new System.Drawing.Size(366, 338);
            this.GrpItem.TabIndex = 4;
            this.GrpItem.TabStop = false;
            // 
            // CboUnit
            // 
            this.CboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboUnit.FormattingEnabled = true;
            this.CboUnit.Location = new System.Drawing.Point(172, 72);
            this.CboUnit.Name = "CboUnit";
            this.CboUnit.Size = new System.Drawing.Size(180, 24);
            this.CboUnit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescription.Location = new System.Drawing.Point(85, 129);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(270, 66);
            this.TxtDescription.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock No";
            // 
            // TxtStockNo
            // 
            this.TxtStockNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStockNo.Location = new System.Drawing.Point(172, 44);
            this.TxtStockNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtStockNo.MaxLength = 35;
            this.TxtStockNo.Name = "TxtStockNo";
            this.TxtStockNo.Size = new System.Drawing.Size(183, 23);
            this.TxtStockNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item No";
            // 
            // TxtItemNo
            // 
            this.TxtItemNo.Location = new System.Drawing.Point(172, 17);
            this.TxtItemNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemNo.Name = "TxtItemNo";
            this.TxtItemNo.ReadOnly = true;
            this.TxtItemNo.Size = new System.Drawing.Size(183, 23);
            this.TxtItemNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Name";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(268, 203);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(87, 28);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtItemName
            // 
            this.TxtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtItemName.Location = new System.Drawing.Point(85, 103);
            this.TxtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Size = new System.Drawing.Size(270, 23);
            this.TxtItemName.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(175, 203);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(87, 28);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(285, 4);
            this.btnCLose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(87, 36);
            this.btnCLose.TabIndex = 3;
            this.btnCLose.Text = "CLOSE";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(99, 4);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(87, 36);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "EDIT";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(6, 4);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(87, 36);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "NEW";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // GrdList
            // 
            this.GrdList.AllowUserToAddRows = false;
            this.GrdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdList.Location = new System.Drawing.Point(378, 4);
            this.GrdList.Name = "GrdList";
            this.GrdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdList.Size = new System.Drawing.Size(374, 380);
            this.GrdList.StandardTab = true;
            this.GrdList.TabIndex = 5;
            this.GrdList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdList_RowHeaderMouseClick);
            // 
            // FrmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 388);
            this.ControlBox = false;
            this.Controls.Add(this.GrdList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.GrpItem);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmItems";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEMS";
            this.Load += new System.EventHandler(this.FrmItems_Load);
            this.GrpItem.ResumeLayout(false);
            this.GrpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox GrpItem;
        private System.Windows.Forms.ComboBox CboUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStockNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtItemNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtItemName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridView GrdList;
    }
}