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
    public partial class FrmRecordsInventoryStock : Form
    {
        public FrmRecordsInventoryStock()
        {
            InitializeComponent();
        }

        DataTable dtList;

        #region " CODE - FORM "

        private void FrmRecordsInventoryStock_Load(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - TEXTBOX "

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - FILL "

        void Fill()
        {

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Server.Connection;
            cmd.CommandText = "SELECT * FROM vw_stocks WHERE item_No LIKE '%'+@in+'%' OR stock_No LIKE'%'+@sn+'%' " +
                                    " OR unit LIKE'%'+@u+'%' OR ItemName LIKE'%'+@inam+'%' ORDER BY ItemName ASC";
            cmd.Parameters.AddWithValue("@in", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@sn", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@inam", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@u", this.txtSearch.Text);
            cmd.ExecuteNonQuery();

            this.dtList = Server.ToData(cmd);
            GrdList.DataSource = null;
            GrdList.DataSource = this.dtList;

        }

        #endregion

        #region "CODE - BUTTON "

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
