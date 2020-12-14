using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Configuration;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using LAZYANT_LIB;

namespace PMIS
{
    public partial class FrmApprovalSlip : Form
    {
        public FrmApprovalSlip(int KeyID, Hashtable h)
        {
            InitializeComponent();
            transId = KeyID;
            hd = h;
        }

        int transId;
        Hashtable hd = new Hashtable();
        DataTable dtInfo, dtDetail;

        #region " CODE - FORM "

        private void ApprovalSlip_Load(object sender, EventArgs e)
        {
            this.fillInfo();
        }

        #endregion

        #region " CODE - FILL "

        void fillInfo()
        {

            //GET REQUEST INFO
            this.dtInfo = Server.ToData("SELECT * FROM vw_trans WHERE transId = " + transId.ToString());

            txtrb.Text = this.dtInfo.Rows[0]["RequestedBy"].ToString();
            txtrd.Text = this.dtInfo.Rows[0]["RequestedDate"].ToString();
            txtcollege.Text = this.dtInfo.Rows[0]["College"].ToString();
            txtRC.Text = this.dtInfo.Rows[0]["RC"].ToString();
            txtRN.Text = this.dtInfo.Rows[0]["RISNo"].ToString();
            txtCode.Text = this.dtInfo.Rows[0]["Code"].ToString();
            txtSN.Text = this.dtInfo.Rows[0]["SAINo"].ToString();
            txtPurpose.Text = this.dtInfo.Rows[0]["Purpose"].ToString();
            txtTotal.Text = this.dtInfo.Rows[0]["Total"].ToString();
        
            //GET REQUEST DETAILS
            this.dtDetail = Server.ToData("SELECT * FROM vw_trans_dtl WHERE transId =" + transId.ToString());

            GrdDetails.DataSource = null;
            GrdDetails.DataSource = this.dtDetail;

            this.GrdDetails.Columns["transid"].Visible = false;
            this.GrdDetails.Columns["ItemUnitId"].Visible = false;
            this.GrdDetails.Columns["ItemDescription"].Visible = false;
            this.GrdDetails.Columns["transdtlId"].Visible = false;
            this.GrdDetails.Columns["Stock_no"].Visible = false;
            this.GrdDetails.Columns["transDate"].Visible = false;
            this.GrdDetails.Columns["approve"].Visible = false;

            this.GrdDetails.Columns["item_no"].Width = 100;
            this.GrdDetails.Columns["ItemName"].Width = 150;
            this.GrdDetails.Columns["Unit"].Width = 50;
            this.GrdDetails.Columns["UnitPrice"].Width = 50;
            this.GrdDetails.Columns["Quantity"].Width = 50;
            this.GrdDetails.Columns["totalCost"].Width = 50;

            this.GrdDetails.Columns["item_no"].ReadOnly = true;
            this.GrdDetails.Columns["ItemName"].ReadOnly = true;
            this.GrdDetails.Columns["Unit"].ReadOnly = true;
            this.GrdDetails.Columns["totalCost"].ReadOnly = true;

        }

        #endregion

        #region " CODE - BUTTON "

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (this.txtApprove.Text == "") {
                Msg.Warn("Please input approved by!");
                this.txtApprove.Focus();
                return;
            }

            if (this.txtIssuedBy.Text == "")
            {
                Msg.Warn("Please input issued by!");
                this.txtIssuedBy.Focus();
                return;
            }

            if (this.txtReceiveBy.Text == "")
            {
                Msg.Warn("Please input receive by!");
                this.txtReceiveBy.Focus();
                return;
            }

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Server.Connection;
            cmd.CommandText ="UPDATE tbl_trans SET Approve=1,ApproveBy=@ab,ApproveDate=@ad,IssuedBy=@ib,IssuedDate=@id,RecieveBy=@rb,RecieveDate=@rd WHERE transID=" + this.transId.ToString();
            cmd.Parameters.AddWithValue("@ab", this.txtApprove.Text);
            cmd.Parameters.AddWithValue("@ad", this.txtApproveDate.Text);
            cmd.Parameters.AddWithValue("@ib", this.txtIssuedBy.Text);
            cmd.Parameters.AddWithValue("@id", this.txtIssuedDate.Text);
            cmd.Parameters.AddWithValue("@rb", this.txtReceiveBy.Text);
            cmd.Parameters.AddWithValue("@rd", this.txtReceivedDate.Text);
            cmd.ExecuteNonQuery();

            Msg.Info("Successfully Approved!");
            Export.ToExcel.Issuance(false, dtDetail, hd);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
