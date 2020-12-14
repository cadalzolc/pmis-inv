namespace PMIS
{
    partial class FrmRequestList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequestList));
            this.GrdList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnCancelRequest = new System.Windows.Forms.Button();
            this.BtnNewRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExportRequest = new System.Windows.Forms.Button();
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
            this.GrdList.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdList.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdList.EnableHeadersVisualStyles = false;
            this.GrdList.Location = new System.Drawing.Point(3, 93);
            this.GrdList.Name = "GrdList";
            this.GrdList.ReadOnly = true;
            this.GrdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdList.Size = new System.Drawing.Size(838, 342);
            this.GrdList.TabIndex = 0;
            this.GrdList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.GrdList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExportRequest);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnCancelRequest);
            this.panel1.Controls.Add(this.BtnNewRequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 53);
            this.panel1.TabIndex = 4;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(495, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(92, 39);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "CLOSE";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnCancelRequest
            // 
            this.BtnCancelRequest.Location = new System.Drawing.Point(169, 6);
            this.BtnCancelRequest.Name = "BtnCancelRequest";
            this.BtnCancelRequest.Size = new System.Drawing.Size(157, 39);
            this.BtnCancelRequest.TabIndex = 1;
            this.BtnCancelRequest.Text = "DELETE REQUEST";
            this.BtnCancelRequest.UseVisualStyleBackColor = true;
            this.BtnCancelRequest.Click += new System.EventHandler(this.BtnCancelRequest_Click);
            // 
            // BtnNewRequest
            // 
            this.BtnNewRequest.Location = new System.Drawing.Point(6, 6);
            this.BtnNewRequest.Name = "BtnNewRequest";
            this.BtnNewRequest.Size = new System.Drawing.Size(157, 39);
            this.BtnNewRequest.TabIndex = 0;
            this.BtnNewRequest.Text = "NEW REQUEST";
            this.BtnNewRequest.UseVisualStyleBackColor = true;
            this.BtnNewRequest.Click += new System.EventHandler(this.BtnNewRequest_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(844, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIST OF REQUEST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 46);
            this.panel2.TabIndex = 6;
            // 
            // BtnExportRequest
            // 
            this.BtnExportRequest.Location = new System.Drawing.Point(332, 6);
            this.BtnExportRequest.Name = "BtnExportRequest";
            this.BtnExportRequest.Size = new System.Drawing.Size(157, 39);
            this.BtnExportRequest.TabIndex = 3;
            this.BtnExportRequest.Text = "EXPORT REQUEST";
            this.BtnExportRequest.UseVisualStyleBackColor = true;
            this.BtnExportRequest.Click += new System.EventHandler(this.BtnExportRequest_Click);
            // 
            // FrmRequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrdList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRequestList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISSUANCE REQUEST - LIST";
            this.Load += new System.EventHandler(this.ListIssuance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView GrdList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancelRequest;
        private System.Windows.Forms.Button BtnNewRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnExportRequest;
    }
}