using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LAZYANT_LIB;

namespace PMIS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }      

        #region " CODE - FORM "

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

            this.lblUser.Text = Current.User.Name.ToUpper();
            this.lblRole.Text = Current.User.Role.Name.ToUpper().Replace("_","");
            this.lblTime.Text = DateTime.Today.ToLongDateString();

            switch (Current.User.Role.ID)
            {
                case 1: //USER = ADMIN
                        this.mnuMaintenance.Visible = true;
                        this.mnuRequest.Visible = true;
                        this.mnuApproval.Visible = true;
                        this.mnu1stDivider.Visible = true;
                        this.mnuRecords.Visible = true;
                        this.mnuReports.Visible = true;
                        this.mnuTransInventoryEntry.Visible = true;
                        break;
                case 2: //USER = COLLEGE
                        this.mnuRequest.Visible = true;
                        break;
                case 3: //USER = PROPERTY
                        this.mnuMaintenance.Visible = true;
                        this.mnuApproval.Visible = true;
                        this.mnu1stDivider.Visible = true;
                        this.mnuRecords.Visible = true;
                        this.mnuTransCustodian.Visible = true;
                        this.mnuReports.Visible = true;
                        this.mnuTransInventoryEntry.Visible = true;
                        break;         
            }

        }

        private void FrmAdmin_SizeChanged(object sender, EventArgs e)
        {
            String BG_Path = @Application.StartupPath.ToString() + @"\Design\bg.jpeg";
            if (File.Exists(BG_Path))
            {
                this.BackgroundImage = Image.FromFile(BG_Path);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        #endregion

        #region " CODE - MENU FILE "

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion  

        #region " CODE - MENU MAINTENANCE "

        private void mnuUnits_Click(object sender, EventArgs e)
        {
            FrmUnits f = new FrmUnits();
            f.ShowDialog();
        }

        private void mnuItems_Click(object sender, EventArgs e)
        {
            FrmItems f  = new FrmItems();
            f.ShowDialog();
        }

        private void mnuColleges_Click(object sender, EventArgs e)
        {
            FrmCollege f = new FrmCollege();
            f.ShowDialog();
        }

        private void mnuUsers_Click(object sender, EventArgs e)
        {
            FrmUsers f = new FrmUsers();
            f.ShowDialog();
        }

        #endregion

        #region " CODE - MENU RECORDS "

        private void mnuRecordsDelivery_Click(object sender, EventArgs e)
        {
            FrmRecordsDelibery f = new FrmRecordsDelibery();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuRecordsIsuuance_Click(object sender, EventArgs e)
        {
            FrmRecordsIssuance f = new FrmRecordsIssuance();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuInventoryAdjsutment_Click(object sender, EventArgs e)
        {
            FrmRecordsAdjustment f = new FrmRecordsAdjustment();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuInventoryBalance_Click(object sender, EventArgs e)
        {
            FrmRecordsInventoryStock f = new FrmRecordsInventoryStock();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        #endregion

        #region " CODE - MENU TRANSACTION "

        private void mnuRequest_Click(object sender, EventArgs e)
        {
            FrmRequestList f = new FrmRequestList();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuApproval_Click(object sender, EventArgs e)
        {
            FrmApprovalList f = new FrmApprovalList();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuTransInventoryEntry_Click(object sender, EventArgs e)
        {
            FrmDeliveryList f = new FrmDeliveryList();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        #endregion          

        #region " CODE - MENU REPORTS "

        private void mnuReportInventoryAdjustment_Click(object sender, EventArgs e)
        {
            FrmMonthlyAdjustment f = new FrmMonthlyAdjustment();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        #endregion

        private void mnuInventoryCustodianSlip_Click(object sender, EventArgs e)
        {

        }


    }
}
