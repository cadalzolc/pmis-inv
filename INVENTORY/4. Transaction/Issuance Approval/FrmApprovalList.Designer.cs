namespace PMIS
{
    partial class FrmApprovalList
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
            this.GrdList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnApproveRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCLose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdList
            // 
            this.GrdList.AllowUserToAddRows = false;
            this.GrdList.AllowUserToDeleteRows = false;
            this.GrdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdList.Location = new System.Drawing.Point(6, 93);
            this.GrdList.Name = "GrdList";
            this.GrdList.ReadOnly = true;
            this.GrdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdList.Size = new System.Drawing.Size(774, 419);
            this.GrdList.TabIndex = 4;
            this.GrdList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCLose);
            this.panel1.Controls.Add(this.BtnApproveRequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 53);
            this.panel1.TabIndex = 5;
            // 
            // BtnApproveRequest
            // 
            this.BtnApproveRequest.Location = new System.Drawing.Point(6, 6);
            this.BtnApproveRequest.Name = "BtnApproveRequest";
            this.BtnApproveRequest.Size = new System.Drawing.Size(157, 39);
            this.BtnApproveRequest.TabIndex = 0;
            this.BtnApproveRequest.Text = "APPROVE  REQUEST";
            this.BtnApproveRequest.UseVisualStyleBackColor = true;
            this.BtnApproveRequest.Click += new System.EventHandler(this.BtnApproveRequest_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(784, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "LIST OF REQUEST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 46);
            this.panel2.TabIndex = 7;
            // 
            // BtnCLose
            // 
            this.BtnCLose.Location = new System.Drawing.Point(169, 6);
            this.BtnCLose.Name = "BtnCLose";
            this.BtnCLose.Size = new System.Drawing.Size(89, 39);
            this.BtnCLose.TabIndex = 1;
            this.BtnCLose.Text = "CLOSE";
            this.BtnCLose.UseVisualStyleBackColor = true;
            this.BtnCLose.Click += new System.EventHandler(this.BtnCLose_Click);
            // 
            // FrmApprovalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrdList);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmApprovalList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISSUANCE REQUEST - LIST FOR APPROVAL";
            this.Load += new System.EventHandler(this.ListofApprovalIssuance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView GrdList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnApproveRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCLose;
    }
}