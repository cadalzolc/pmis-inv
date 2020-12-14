using System;
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
    public partial class FrmRecordsDelibery : Form
    {
        public FrmRecordsDelibery()
        {
            InitializeComponent();
        }

        DataTable dtList;

        #region " CODE - FORM "

        private void FrmRecordsDelibery_Load(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - FILL "

        void Fill()
        {

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Server.Connection;
            cmd.CommandText = "SELECT * FROM (SELECT * FROM vw_delivery WHERE Approve=1 ) V WHERE deliveryNo LIKE '%'+@dn+'%' OR Supplier LIKE'%'+@s+'%' " +
                                    " OR ReceivedBy LIKE'%'+@rb+'%' OR ReceivedDate LIKE'%'+@rd+'%' ORDER BY deliveryDate DESC";

            cmd.Parameters.AddWithValue("@dn", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@s", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@rb", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@rd", this.txtSearch.Text);
            cmd.ExecuteNonQuery();

            this.dtList = Server.ToData(cmd);
            GrdList.DataSource = null;
            GrdList.DataSource = this.dtList;

            this.GrdList.Columns["deliveryId"].Visible = false;
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

        #region " CODE - BUTTON "

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

    }
}
