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
using System.Data.SqlClient;
using System.Configuration;
using LAZYANT_LIB;

namespace PMIS
{
    public partial class FrmRequestList : Form
    {
        public FrmRequestList()
        {
            InitializeComponent();         
        }

        Hashtable SelectedTrans = new Hashtable();

        #region " CODE - FORM "

        private void ListIssuance_Load(object sender, EventArgs e)
        {
            loadtrans();
        }

        #endregion

        #region " CODE - FILL "

        void loadtrans()
        {

            DataTable dt = Server.ToData("SELECT * FROM vw_trans WHERE approve=0");
            GrdList.DataSource = dt;

            if (dt == null || dt.Rows.Count == 0)
            {
                this.BtnCancelRequest.Enabled = false;
                this.BtnExportRequest.Enabled = false;
            }
            else
            {
                this.BtnCancelRequest.Enabled = true;
                this.BtnExportRequest.Enabled = true;
                this.mySel(0);
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
            this.mySel(e.RowIndex);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int r = Convert.ToInt32(this.GrdList.Rows[e.RowIndex].Cells["transId"].Value);
            FrmRequestSlip nr = new FrmRequestSlip(Convert.ToInt32(r),SelectedTrans);
            nr.ShowDialog();
            this.loadtrans();
        }

        private void mySel(int RowIndex)
        {
            this.SelectedTrans["transId"] = this.GrdList.Rows[RowIndex].Cells["transId"].Value.ToString();
            this.SelectedTrans["Code"] = this.GrdList.Rows[RowIndex].Cells["Code"].Value;
            this.SelectedTrans["RISNo"] = this.GrdList.Rows[RowIndex].Cells["RISNo"].Value;
            this.SelectedTrans["SAINo"] = this.GrdList.Rows[RowIndex].Cells["SAINo"].Value;
            this.SelectedTrans["Total"] = this.GrdList.Rows[RowIndex].Cells["Total"].Value;
            this.SelectedTrans["Purpose"] = this.GrdList.Rows[RowIndex].Cells["Purpose"].Value;
            this.SelectedTrans["College"] = this.GrdList.Rows[RowIndex].Cells["College"].Value;
            this.SelectedTrans["IssuedBy"] = this.GrdList.Rows[RowIndex].Cells["IssuedBy"].Value;
            this.SelectedTrans["ApproveBy"] = this.GrdList.Rows[RowIndex].Cells["ApproveBy"].Value;
            this.SelectedTrans["RecieveBy"] = this.GrdList.Rows[RowIndex].Cells["RecieveBy"].Value;
            this.SelectedTrans["IssuedDate"] = this.GrdList.Rows[RowIndex].Cells["IssuedDate"].Value;
            this.SelectedTrans["IssuedDate"] = this.GrdList.Rows[RowIndex].Cells["IssuedDate"].Value;
            this.SelectedTrans["RequestedBy"] = this.GrdList.Rows[RowIndex].Cells["RequestedBy"].Value;
            this.SelectedTrans["ApproveDate"] = this.GrdList.Rows[RowIndex].Cells["ApproveDate"].Value;
            this.SelectedTrans["RecieveDate"] = this.GrdList.Rows[RowIndex].Cells["RecieveDate"].Value;
            this.SelectedTrans["RequestedDate"] = this.GrdList.Rows[RowIndex].Cells["RequestedDate"].Value;
        }

        #endregion

        #region " CODE - BUTTON 

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewRequest_Click(object sender, EventArgs e)
        {
            FrmRequestSlip nr = new FrmRequestSlip(0,new Hashtable());
            nr.ShowDialog();
            loadtrans();
        }

        private void BtnCancelRequest_Click(object sender, EventArgs e)
        {

            if (this.SelectedTrans != null)
            {

                String transId = this.SelectedTrans["transId"].ToString();

                if (Msg.Confirm("Are your sure you want to delete this request?", "DELETE REQUEST") == DialogResult.Yes)
                {
                    Server.Delete("tbl_trans", "where transId=" + transId);
                    Server.Delete("tbl_trans_dtl", "where transId=" + transId);
                    this.loadtrans();
                }
            }
            else {
                Msg.Warn("Please select atleast one request to delete!");
            }

        }

        private void BtnExportRequest_Click(object sender, EventArgs e)
        {
            String transId = this.SelectedTrans["transId"].ToString();
            DataTable dt = Server.ToData("SELECT * FROM vw_trans_dtl where transId =" + transId);
            Export.ToExcel.Issuance(true, dt, SelectedTrans);
        }

        #endregion
         
    }
}
