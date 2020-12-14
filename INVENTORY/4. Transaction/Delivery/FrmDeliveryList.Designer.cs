namespace PMIS
{
    partial class FrmDeliveryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnApprovedDelivery = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDeleteDelivery = new System.Windows.Forms.Button();
            this.BtnNewDelivery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GrdList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnApprovedDelivery);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnDeleteDelivery);
            this.panel1.Controls.Add(this.BtnNewDelivery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 53);
            this.panel1.TabIndex = 5;
            // 
            // BtnApprovedDelivery
            // 
            this.BtnApprovedDelivery.Location = new System.Drawing.Point(169, 6);
            this.BtnApprovedDelivery.Name = "BtnApprovedDelivery";
            this.BtnApprovedDelivery.Size = new System.Drawing.Size(157, 39);
            this.BtnApprovedDelivery.TabIndex = 3;
            this.BtnApprovedDelivery.Text = "APPROVED DELIVERY";
            this.BtnApprovedDelivery.UseVisualStyleBackColor = true;
            this.BtnApprovedDelivery.Click += new System.EventHandler(this.BtnApprovedDelivery_Click);
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
            // BtnDeleteDelivery
            // 
            this.BtnDeleteDelivery.Location = new System.Drawing.Point(332, 6);
            this.BtnDeleteDelivery.Name = "BtnDeleteDelivery";
            this.BtnDeleteDelivery.Size = new System.Drawing.Size(157, 39);
            this.BtnDeleteDelivery.TabIndex = 1;
            this.BtnDeleteDelivery.Text = "DELETE DELIVERY";
            this.BtnDeleteDelivery.UseVisualStyleBackColor = true;
            this.BtnDeleteDelivery.Click += new System.EventHandler(this.BtnDeleteDelivery_Click);
            // 
            // BtnNewDelivery
            // 
            this.BtnNewDelivery.Location = new System.Drawing.Point(6, 6);
            this.BtnNewDelivery.Name = "BtnNewDelivery";
            this.BtnNewDelivery.Size = new System.Drawing.Size(157, 39);
            this.BtnNewDelivery.TabIndex = 0;
            this.BtnNewDelivery.Text = "NEW DELIVERY";
            this.BtnNewDelivery.UseVisualStyleBackColor = true;
            this.BtnNewDelivery.Click += new System.EventHandler(this.BtnNewDelivery_Click);
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
            this.label1.TabIndex = 6;
            this.label1.Text = "LIST OF DELIVERY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 46);
            this.panel2.TabIndex = 7;
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
            this.GrdList.Location = new System.Drawing.Point(6, 93);
            this.GrdList.Name = "GrdList";
            this.GrdList.ReadOnly = true;
            this.GrdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdList.Size = new System.Drawing.Size(833, 419);
            this.GrdList.TabIndex = 8;
            this.GrdList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdList_RowHeaderMouseClick);
            this.GrdList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdList_RowHeaderMouseDoubleClick);
            // 
            // FrmDeliveryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 562);
            this.Controls.Add(this.GrdList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmDeliveryList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY - LIST OF ENTRY";
            this.Load += new System.EventHandler(this.FrmInventoryList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDeleteDelivery;
        private System.Windows.Forms.Button BtnNewDelivery;
        private System.Windows.Forms.Button BtnApprovedDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView GrdList;
    }
}