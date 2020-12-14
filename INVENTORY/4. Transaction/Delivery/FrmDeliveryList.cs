using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LAZYANT_LIB;

namespace PMIS
{
    public partial class FrmDeliveryList : Form
    {
        public FrmDeliveryList()
        {
            InitializeComponent();
        }

        Hashtable SelectedTrans = new Hashtable();

        #region " CODE - FORM "

        private void FrmInventoryList_Load(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - FILL "

        void Fill()
        {
            DataTable dt = Server.ToData("SELECT * FROM tbl_delivery WHERE approve=0");
            GrdList.DataSource = dt;

            if (dt == null || dt.Rows.Count == 0)
            {
                this.BtnApprovedDelivery.Enabled = false;
                this.BtnDeleteDelivery.Enabled = false;
            }
            else
            {
                this.BtnApprovedDelivery.Enabled = true;
                this.BtnDeleteDelivery.Enabled = true;
                this.SelectedTrans["deliveryId"] = dt.Rows[0]["deliveryId"].ToString();
            }

            this.GrdList.Columns["deliveryId"].Visible = false;
            this.GrdList.Columns["approve"].Visible = false;
            this.GrdList.Columns["EncoderId"].Visible = false;

        }

        #endregion

        #region " CODE - GRID "

        private void GrdList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SelectedTrans["deliveryId"] = this.GrdList.Rows[e.RowIndex].Cells["deliveryId"].Value;
        }

        private void GrdList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmDeliverySlip f = new FrmDeliverySlip(Convert.ToInt32(this.GrdList.Rows[e.RowIndex].Cells["deliveryId"].Value));
            f.ShowDialog();
            this.Fill();
        }

        #endregion

        #region " CODE - BUTTON "

        private void BtnNewDelivery_Click(object sender, EventArgs e)
        {
            FrmDeliverySlip f = new FrmDeliverySlip(0);
            f.ShowDialog();
            this.Fill();
        }

        private void BtnApprovedDelivery_Click(object sender, EventArgs e)
        {
            String ID = this.SelectedTrans["deliveryId"].ToString();
            if (Msg.Confirm("Are your sure you want to approve this delivery?", "APPROVED DELIVERY") == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Server.Connection;
                cmd.CommandText = "UPDATE tbl_delivery SET Approve=1 WHERE deliveryId=" + ID;
                cmd.ExecuteNonQuery();
                this.Fill();
            }
        }

        private void BtnDeleteDelivery_Click(object sender, EventArgs e)
        {
            String ID = this.SelectedTrans["deliveryId"].ToString();
            if (Msg.Confirm("Are your sure you want to delete this delivery?", "DELETE DELIVERY") == DialogResult.Yes)
            {
                Server.Delete("tbl_delivery", "where deliveryId=" + ID);
                Server.Delete("tbl_delivery_dtl", "where deliveryId=" + ID);
                this.Fill();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion           

    }
}
