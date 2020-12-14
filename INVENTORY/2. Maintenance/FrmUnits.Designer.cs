namespace PMIS
{
    partial class FrmUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnits));
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUnit = new System.Windows.Forms.TextBox();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.GrpUnit = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.GrpUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(172, 47);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(87, 28);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit";
            // 
            // TxtUnit
            // 
            this.TxtUnit.Location = new System.Drawing.Point(64, 16);
            this.TxtUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.Size = new System.Drawing.Size(288, 23);
            this.TxtUnit.TabIndex = 1;
            // 
            // LstBox
            // 
            this.LstBox.FormattingEnabled = true;
            this.LstBox.ItemHeight = 16;
            this.LstBox.Location = new System.Drawing.Point(4, 141);
            this.LstBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstBox.Name = "LstBox";
            this.LstBox.Size = new System.Drawing.Size(366, 260);
            this.LstBox.TabIndex = 0;
            this.LstBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstBox_MouseClick);
            this.LstBox.SelectedIndexChanged += new System.EventHandler(this.LstBox_SelectedIndexChanged);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(4, 6);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(87, 36);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "NEW";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(97, 6);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(87, 36);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "EDIT";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(283, 6);
            this.btnCLose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(87, 36);
            this.btnCLose.TabIndex = 3;
            this.btnCLose.Text = "CLOSE";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // GrpUnit
            // 
            this.GrpUnit.Controls.Add(this.label1);
            this.GrpUnit.Controls.Add(this.BtnCancel);
            this.GrpUnit.Controls.Add(this.TxtUnit);
            this.GrpUnit.Controls.Add(this.BtnSave);
            this.GrpUnit.Enabled = false;
            this.GrpUnit.Location = new System.Drawing.Point(4, 49);
            this.GrpUnit.Name = "GrpUnit";
            this.GrpUnit.Size = new System.Drawing.Size(366, 87);
            this.GrpUnit.TabIndex = 5;
            this.GrpUnit.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(265, 47);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(87, 28);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(190, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 407);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.GrpUnit);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LstBox);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNITS";
            this.Load += new System.EventHandler(this.FrmUnits_Load);
            this.GrpUnit.ResumeLayout(false);
            this.GrpUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUnit;
        private System.Windows.Forms.ListBox LstBox;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.GroupBox GrpUnit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}