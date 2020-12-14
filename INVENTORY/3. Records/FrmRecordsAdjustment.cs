using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using LAZYANT_LIB;

namespace PMIS
{
    public partial class FrmRecordsAdjustment : Form
    {
        public FrmRecordsAdjustment()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        #region " CODE - FORM "

        private void FrmRecordsAdjustment_Load(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - FILL "

        void Fill()
        { 

            String sql = "SELECT *,((Stock_Begin+Stock_Purchase)-Stock_Out) AS Stock_End FROM ( " +
                            "SELECT I.ItemNo,I.Stock_No,I.ItemUnit,I.ItemName,I.ItemDescription, " +
                                "ISNULL((SELECT TOP 1 unitPrice FROM vw_delivery_dtl WHERE Item_No=I.ItemNo ORDER BY deliverydtlid ASC),0) AS UnitPrice," +
                                "ABS(ISNULL((SELECT SUM(Quantity) FROM vw_stocks_dtl WHERE TransDate <= '" + this.TxtDate.Value.AddDays(-1).ToString("yyyy-MM-dd") + "' AND Item_No=I.ItemNo),0)) AS Stock_Begin, " +
                                "ABS(ISNULL((SELECT SUM(Quantity) FROM vw_stocks_dtl WHERE TransType='DELIVERY' AND TransDate='" + this.TxtDate.Value.ToString("yyyy-MM-dd") + "' AND Item_No=I.ItemNo),0)) AS Stock_Purchase, " +
                                "ABS(ISNULL((SELECT SUM(Quantity) FROM vw_stocks_dtl WHERE TransType='ISSUED' AND TransDate='" + this.TxtDate.Value.ToString("yyyy-MM-dd") + "' AND Item_No=I.ItemNo),0)) AS Stock_Out " +
                            "FROM vw_item I " +
                            " ) Adj WHERE ItemNo LIKE '%'+@in+'%' OR Stock_No LIKE'%'+@sn+'%' " +
                                    " OR ItemUnit LIKE'%'+@u+'%' OR ItemName LIKE'%'+@inam+'%' ORDER BY ItemName ASC";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Server.Connection;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@in", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@sn", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@inam", this.txtSearch.Text);
            cmd.Parameters.AddWithValue("@u", this.txtSearch.Text);
            cmd.ExecuteNonQuery();

            dt = Server.ToData(cmd);

            this.GrdList.DataSource = null;
            this.GrdList.DataSource = dt;

            GrdList.Columns["ItemNo"].Width = 100;
            GrdList.Columns["Stock_No"].Width = 120;
            GrdList.Columns["ItemUnit"].Width = 70;
            GrdList.Columns["ItemName"].Width = 250;
            GrdList.Columns["ItemDescription"].Width = 250;
            GrdList.Columns["Stock_Begin"].Width = 100;
            GrdList.Columns["Stock_Purchase"].Width = 100;
            GrdList.Columns["Stock_Out"].Width = 100;
            GrdList.Columns["Stock_End"].Width = 100;

            GrdList.Columns["ItemNo"].HeaderText = "ITEM NO";
            GrdList.Columns["Stock_No"].HeaderText = "STOCK NO";
            GrdList.Columns["ItemUnit"].HeaderText = "UNIT";
            GrdList.Columns["ItemName"].HeaderText = "ITEM";
            GrdList.Columns["ItemDescription"].HeaderText = "DESCRIPTION";
            GrdList.Columns["Stock_Begin"].HeaderText = "BEGIN";
            GrdList.Columns["Stock_Purchase"].HeaderText = "DELIVERY";
            GrdList.Columns["Stock_Out"].HeaderText = "ISSUED";
            GrdList.Columns["Stock_End"].HeaderText = "ENDING";

            GrdList.Columns["Stock_Begin"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GrdList.Columns["Stock_Purchase"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GrdList.Columns["Stock_Out"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GrdList.Columns["Stock_End"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GrdList.Columns["Stock_Begin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GrdList.Columns["Stock_Purchase"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GrdList.Columns["Stock_Out"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GrdList.Columns["Stock_End"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        #endregion

        #region " CODE - FORM "

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - DATE TIME PICKER "

        private void TxtDate_ValueChanged(object sender, EventArgs e)
        {
            this.Fill();
        }

        #endregion

        #region " CODE - BUTTON "

        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            Export.ToExcel.AdjustmentDaily(dt, TxtDate.Value);
        }

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
