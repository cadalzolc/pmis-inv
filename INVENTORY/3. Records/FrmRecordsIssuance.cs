using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LAZYANT_LIB;

namespace PMIS
{
    public partial class FrmRecordsIssuance : Form
    {
        public FrmRecordsIssuance()
        {
            InitializeComponent();
        }

        Hashtable SelectedTrans = new Hashtable();
        DataTable dtList;

        #region " CODE - FORM "

        private void FrmRecordsIssuance_Load(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - FILL "

        void Fill()
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Server.Connection;
                cmd.CommandText = "SELECT * FROM (SELECT * FROM vw_trans WHERE Approve=1 ) V WHERE RequestedBy LIKE '%'+@rsb+'%' OR ApproveBy LIKE'%'+@ab+'%' " + 
                                        " OR RecieveBy LIKE'%'+@rb+'%' OR College LIKE'%'+@cl+'%' OR Code LIKE'%'+@cd+'%' ORDER BY TransDate DESC";
                cmd.Parameters.AddWithValue("@rsb", this.txtSearch.Text);
                cmd.Parameters.AddWithValue("@ab", this.txtSearch.Text);
                cmd.Parameters.AddWithValue("@rb", this.txtSearch.Text);
                cmd.Parameters.AddWithValue("@cl", this.txtSearch.Text);
                cmd.Parameters.AddWithValue("@cd", this.txtSearch.Text);
                cmd.ExecuteNonQuery();

                this.dtList = Server.ToData(cmd);
                GrdList.DataSource = null;
                GrdList.DataSource = this.dtList;

                if (dtList == null || dtList.Rows.Count == 0)
                {
                    this.BtnExportToExcel.Enabled = false;
                }
                else
                {
                    this.BtnExportToExcel.Enabled = true;
                    this.mySel(0);
                }

                this.GrdList.Columns["transId"].Visible = false;
                this.GrdList.Columns["transTypeId"].Visible = false;
                this.GrdList.Columns["trans_Type"].Visible = false;
                this.GrdList.Columns["CollegeId"].Visible = false;
                this.GrdList.Columns["EncoderId"].Visible = false;
                this.GrdList.Columns["UserName"].Visible = false;
            }

        #endregion

        #region " CODE - TEXTBOX "

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - GRID"

        private void GrdList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.mySel(e.RowIndex);
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

        #region " CODE - BUTTON "

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            String transId = this.SelectedTrans["transId"].ToString();
            DataTable dt = Server.ToData("SELECT * FROM vw_trans_dtl where transId =" + transId);
            Export.ToExcel.Issuance(false, dt, SelectedTrans);
        }

        #endregion     

    }
}
