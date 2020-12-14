namespace PMIS
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuColleges = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordsDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordsIsuuance = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDivider2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuInventoryAdjsutment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventoryBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransInventoryEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1stDivider = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTransAckowlegdement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransCustodian = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportAckonwledgement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportInventoryCustodian = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportInventoryAdjustment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFooter = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.sep1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain.SuspendLayout();
            this.mnuFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.mnuMaintenance,
            this.mnuRecords,
            this.tToolStripMenuItem,
            this.mnuReports});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(784, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fToolStripMenuItem.Text = "FILE";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(109, 22);
            this.mnuClose.Text = "&CLOSE";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuMaintenance
            // 
            this.mnuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUnits,
            this.mnuItems,
            this.toolStripMenuItem1,
            this.mnuColleges,
            this.toolStripMenuItem2,
            this.mnuUsers});
            this.mnuMaintenance.Name = "mnuMaintenance";
            this.mnuMaintenance.Size = new System.Drawing.Size(103, 20);
            this.mnuMaintenance.Text = "MAINTENANCE";
            this.mnuMaintenance.Visible = false;
            // 
            // mnuUnits
            // 
            this.mnuUnits.Name = "mnuUnits";
            this.mnuUnits.Size = new System.Drawing.Size(129, 22);
            this.mnuUnits.Text = "UNITS";
            this.mnuUnits.Click += new System.EventHandler(this.mnuUnits_Click);
            // 
            // mnuItems
            // 
            this.mnuItems.Name = "mnuItems";
            this.mnuItems.Size = new System.Drawing.Size(129, 22);
            this.mnuItems.Text = "ITEMS";
            this.mnuItems.Click += new System.EventHandler(this.mnuItems_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 6);
            // 
            // mnuColleges
            // 
            this.mnuColleges.Name = "mnuColleges";
            this.mnuColleges.Size = new System.Drawing.Size(129, 22);
            this.mnuColleges.Text = "COLLEGES";
            this.mnuColleges.Click += new System.EventHandler(this.mnuColleges_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 6);
            // 
            // mnuUsers
            // 
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(129, 22);
            this.mnuUsers.Text = "USERS";
            this.mnuUsers.Click += new System.EventHandler(this.mnuUsers_Click);
            // 
            // mnuRecords
            // 
            this.mnuRecords.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecordsDelivery,
            this.mnuRecordsIsuuance,
            this.mniDivider2,
            this.mnuInventoryAdjsutment,
            this.mnuInventoryBalance});
            this.mnuRecords.Name = "mnuRecords";
            this.mnuRecords.Size = new System.Drawing.Size(70, 20);
            this.mnuRecords.Text = "RECORDS";
            this.mnuRecords.Visible = false;
            // 
            // mnuRecordsDelivery
            // 
            this.mnuRecordsDelivery.Name = "mnuRecordsDelivery";
            this.mnuRecordsDelivery.Size = new System.Drawing.Size(286, 22);
            this.mnuRecordsDelivery.Text = "SUPPLY DELIVERY RECORDS";
            this.mnuRecordsDelivery.Click += new System.EventHandler(this.mnuRecordsDelivery_Click);
            // 
            // mnuRecordsIsuuance
            // 
            this.mnuRecordsIsuuance.Name = "mnuRecordsIsuuance";
            this.mnuRecordsIsuuance.Size = new System.Drawing.Size(286, 22);
            this.mnuRecordsIsuuance.Text = "ISSUANCE RECORDS";
            this.mnuRecordsIsuuance.Click += new System.EventHandler(this.mnuRecordsIsuuance_Click);
            // 
            // mniDivider2
            // 
            this.mniDivider2.Name = "mniDivider2";
            this.mniDivider2.Size = new System.Drawing.Size(283, 6);
            // 
            // mnuInventoryAdjsutment
            // 
            this.mnuInventoryAdjsutment.Name = "mnuInventoryAdjsutment";
            this.mnuInventoryAdjsutment.Size = new System.Drawing.Size(286, 22);
            this.mnuInventoryAdjsutment.Text = "INVENTORY - ADJUSTMENT";
            this.mnuInventoryAdjsutment.Click += new System.EventHandler(this.mnuInventoryAdjsutment_Click);
            // 
            // mnuInventoryBalance
            // 
            this.mnuInventoryBalance.Name = "mnuInventoryBalance";
            this.mnuInventoryBalance.Size = new System.Drawing.Size(286, 22);
            this.mnuInventoryBalance.Text = "INVENTORY - BALANCE";
            this.mnuInventoryBalance.Click += new System.EventHandler(this.mnuInventoryBalance_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransInventoryEntry,
            this.mnuRequest,
            this.mnuApproval,
            this.mnu1stDivider,
            this.mnuTransAckowlegdement,
            this.mnuTransCustodian});
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.tToolStripMenuItem.Text = "TRANSACTION";
            // 
            // mnuTransInventoryEntry
            // 
            this.mnuTransInventoryEntry.Name = "mnuTransInventoryEntry";
            this.mnuTransInventoryEntry.Size = new System.Drawing.Size(240, 22);
            this.mnuTransInventoryEntry.Text = "SUPPLY DELIVERY - PURCHASE";
            this.mnuTransInventoryEntry.Visible = false;
            this.mnuTransInventoryEntry.Click += new System.EventHandler(this.mnuTransInventoryEntry_Click);
            // 
            // mnuRequest
            // 
            this.mnuRequest.Name = "mnuRequest";
            this.mnuRequest.Size = new System.Drawing.Size(240, 22);
            this.mnuRequest.Text = "ISSUANCE SLIP - REQUEST";
            this.mnuRequest.Visible = false;
            this.mnuRequest.Click += new System.EventHandler(this.mnuRequest_Click);
            // 
            // mnuApproval
            // 
            this.mnuApproval.Name = "mnuApproval";
            this.mnuApproval.Size = new System.Drawing.Size(240, 22);
            this.mnuApproval.Text = "ISSUANCE SLIP - APPROVAL";
            this.mnuApproval.Visible = false;
            this.mnuApproval.Click += new System.EventHandler(this.mnuApproval_Click);
            // 
            // mnu1stDivider
            // 
            this.mnu1stDivider.Name = "mnu1stDivider";
            this.mnu1stDivider.Size = new System.Drawing.Size(237, 6);
            this.mnu1stDivider.Visible = false;
            // 
            // mnuTransAckowlegdement
            // 
            this.mnuTransAckowlegdement.Name = "mnuTransAckowlegdement";
            this.mnuTransAckowlegdement.Size = new System.Drawing.Size(240, 22);
            this.mnuTransAckowlegdement.Text = "ACKNOWLEGDEMENT RECEIPT";
            this.mnuTransAckowlegdement.Visible = false;
            // 
            // mnuTransCustodian
            // 
            this.mnuTransCustodian.Name = "mnuTransCustodian";
            this.mnuTransCustodian.Size = new System.Drawing.Size(240, 22);
            this.mnuTransCustodian.Text = "INVENTORY CUSTODIAN SLIP";
            this.mnuTransCustodian.Visible = false;
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportSchedule,
            this.mnuReportAckonwledgement,
            this.mnuReportInventoryCustodian,
            this.mnuReportInventoryAdjustment});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(68, 20);
            this.mnuReports.Text = "REPORTS";
            this.mnuReports.Visible = false;
            // 
            // mnuReportSchedule
            // 
            this.mnuReportSchedule.Name = "mnuReportSchedule";
            this.mnuReportSchedule.Size = new System.Drawing.Size(294, 22);
            this.mnuReportSchedule.Text = "REPORT - SCHEDULE OF DELIVERIES";
            this.mnuReportSchedule.Visible = false;
            // 
            // mnuReportAckonwledgement
            // 
            this.mnuReportAckonwledgement.Name = "mnuReportAckonwledgement";
            this.mnuReportAckonwledgement.Size = new System.Drawing.Size(294, 22);
            this.mnuReportAckonwledgement.Text = "REPORT - ACKNOWLEDGEMENT RECEIPT";
            this.mnuReportAckonwledgement.Visible = false;
            // 
            // mnuReportInventoryCustodian
            // 
            this.mnuReportInventoryCustodian.Name = "mnuReportInventoryCustodian";
            this.mnuReportInventoryCustodian.Size = new System.Drawing.Size(294, 22);
            this.mnuReportInventoryCustodian.Text = "REPORT - INVENTORY CUSTODIAN";
            this.mnuReportInventoryCustodian.Visible = false;
            // 
            // mnuReportInventoryAdjustment
            // 
            this.mnuReportInventoryAdjustment.Name = "mnuReportInventoryAdjustment";
            this.mnuReportInventoryAdjustment.Size = new System.Drawing.Size(294, 22);
            this.mnuReportInventoryAdjustment.Text = "REPORT - INVENTORY ADJUSTMENT";
            this.mnuReportInventoryAdjustment.Click += new System.EventHandler(this.mnuReportInventoryAdjustment_Click);
            // 
            // mnuFooter
            // 
            this.mnuFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.sep1,
            this.lblRole,
            this.lblTime});
            this.mnuFooter.Location = new System.Drawing.Point(0, 540);
            this.mnuFooter.Name = "mnuFooter";
            this.mnuFooter.Size = new System.Drawing.Size(784, 22);
            this.mnuFooter.TabIndex = 2;
            this.mnuFooter.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = false;
            this.lblUser.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.Image")));
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.IsLink = true;
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUser.Size = new System.Drawing.Size(150, 17);
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(10, 17);
            this.sep1.Text = "|";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = false;
            this.lblRole.Image = ((System.Drawing.Image)(resources.GetObject("lblRole.Image")));
            this.lblRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRole.Name = "lblRole";
            this.lblRole.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblRole.Size = new System.Drawing.Size(150, 17);
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = false;
            this.lblTime.Image = ((System.Drawing.Image)(resources.GetObject("lblTime.Image")));
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTime.Size = new System.Drawing.Size(459, 17);
            this.lblTime.Spring = true;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mnuFooter);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROPERTY INVENTORY MANAGEMENT MODULE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.SizeChanged += new System.EventHandler(this.FrmAdmin_SizeChanged);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.mnuFooter.ResumeLayout(false);
            this.mnuFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMaintenance;
        private System.Windows.Forms.ToolStripMenuItem mnuUnits;
        private System.Windows.Forms.ToolStripMenuItem mnuItems;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuColleges;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRequest;
        private System.Windows.Forms.ToolStripMenuItem mnuApproval;
        private System.Windows.Forms.ToolStripSeparator mnu1stDivider;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuRecords;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordsIsuuance;
        private System.Windows.Forms.ToolStripSeparator mniDivider2;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuInventoryAdjsutment;
        private System.Windows.Forms.ToolStripMenuItem mnuInventoryBalance;
        private System.Windows.Forms.ToolStripMenuItem mnuTransAckowlegdement;
        private System.Windows.Forms.ToolStripMenuItem mnuTransCustodian;
        private System.Windows.Forms.StatusStrip mnuFooter;
        private System.Windows.Forms.ToolStripMenuItem mnuReportSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuReportAckonwledgement;
        private System.Windows.Forms.ToolStripMenuItem mnuReportInventoryCustodian;
        private System.Windows.Forms.ToolStripMenuItem mnuTransInventoryEntry;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordsDelivery;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel sep1;
        private System.Windows.Forms.ToolStripStatusLabel lblRole;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripMenuItem mnuReportInventoryAdjustment;
    }
}