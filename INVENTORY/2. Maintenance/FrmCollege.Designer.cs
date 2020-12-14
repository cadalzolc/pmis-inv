namespace PMIS
{
    partial class FrmCollege
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCollege));
            this.btnDelete = new System.Windows.Forms.Button();
            this.GrpCollege = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtCollege = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.GrpCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(190, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GrpCollege
            // 
            this.GrpCollege.Controls.Add(this.label1);
            this.GrpCollege.Controls.Add(this.BtnCancel);
            this.GrpCollege.Controls.Add(this.TxtCollege);
            this.GrpCollege.Controls.Add(this.BtnSave);
            this.GrpCollege.Enabled = false;
            this.GrpCollege.Location = new System.Drawing.Point(4, 53);
            this.GrpCollege.Name = "GrpCollege";
            this.GrpCollege.Size = new System.Drawing.Size(366, 87);
            this.GrpCollege.TabIndex = 11;
            this.GrpCollege.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "College";
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
            // TxtCollege
            // 
            this.TxtCollege.Location = new System.Drawing.Point(64, 16);
            this.TxtCollege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCollege.Name = "TxtCollege";
            this.TxtCollege.Size = new System.Drawing.Size(288, 20);
            this.TxtCollege.TabIndex = 1;
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
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(283, 10);
            this.btnCLose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(87, 36);
            this.btnCLose.TabIndex = 10;
            this.btnCLose.Text = "CLOSE";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(97, 10);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(87, 36);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "EDIT";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(4, 10);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(87, 36);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.Text = "NEW";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // LstBox
            // 
            this.LstBox.FormattingEnabled = true;
            this.LstBox.Location = new System.Drawing.Point(4, 145);
            this.LstBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstBox.Name = "LstBox";
            this.LstBox.Size = new System.Drawing.Size(366, 251);
            this.LstBox.TabIndex = 7;
            this.LstBox.SelectedIndexChanged += new System.EventHandler(this.LstBox_SelectedIndexChanged);
            // 
            // FrmCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 395);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.GrpCollege);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LstBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCollege";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COLLEGE";
            this.Load += new System.EventHandler(this.FrmCollege_Load);
            this.GrpCollege.ResumeLayout(false);
            this.GrpCollege.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox GrpCollege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtCollege;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.ListBox LstBox;
    }
}