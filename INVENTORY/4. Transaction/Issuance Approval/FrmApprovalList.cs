using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;
using LAZYANT_LIB;

namespace PMIS
{

    public partial class FrmApprovalList : Form
    {

        public FrmApprovalList()
        {
            InitializeComponent();
        }

        Hashtable SelectedTrans = new Hashtable();
         
        #region " CODE - FORM "

        private void ListofApprovalIssuance_Load(object sender, EventArgs e)
        {
            loadtrans();
        }

        #endregion

        #region " CODE - FILL "

        void loadtrans()
        {
            DataTable dt = new DataTable();
            dt = Server.ToData("SELECT * FROM vw_trans WHERE Approve = 0");
            GrdList.DataSource = null;
            GrdList.DataSource = dt;

            if (dt == null || dt.Rows.Count == 0)
            {
                this.BtnApproveRequest.Enabled = false;  
            }
            else
            {
                this.BtnApproveRequest.Enabled = true;
                this.SelectedTrans["transId"] = dt.Rows[0]["transId"].ToString();
            }

            this.GrdList.Columns["transId"].Visible = false;
            this.GrdList.Columns["transTypeId"].Visible = false;
            this.GrdList.Columns["trans_type"].Visible = false;
            this.GrdList.Columns["ApproveBy"].Visible = false;
            this.GrdList.Columns["ApproveDate"].Visible = false;
            this.GrdList.Columns["RecieveBy"].Visible = false;
            this.GrdList.Columns["RecieveDate"].Visible = false;
            this.GrdList.Columns["IssuedBy"].Visible = false;
            this.GrdList.Columns["IssuedDate"].Visible = false;
            this.GrdList.Columns["Approve"].Visible = false;
            this.GrdList.Columns["EncoderId"].Visible = false;
            this.GrdList.Columns["UserName"].Visible = false;
            this.GrdList.Columns["CollegeId"].Visible = false;

        }

        #endregion

        #region " CODE - GRID "

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SelectedTrans["transId"] = this.GrdList.Rows[e.RowIndex].Cells["transId"].Value.ToString();
        }

        #endregion

        #region " CODE - BUTTON "

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnApproveRequest_Click(object sender, EventArgs e)
        {
            int transId = Convert.ToInt32(this.SelectedTrans["transId"]);
            FrmApprovalSlip f = new FrmApprovalSlip(transId,SelectedTrans);
            f.ShowDialog();
            this.loadtrans();
        }

        #endregion   

    }
}
