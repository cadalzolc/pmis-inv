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
    public partial class FrmItems : Form
    {
        public FrmItems()
        {
            InitializeComponent();
        }

        String ItemNo = "";
        DataTable dt = new DataTable();

        #region " CODE - FORM "

        private void FrmItems_Load(object sender, EventArgs e)
        {
            this.FillList();
            MyForm.Combo.Fill(CboUnit, "SELECT * FROM tbl_Unit", "Unit", "UnitId");
        }

        #endregion

        #region " CODE - FILL "

        void FillList()
        {
            dt = Server.ToData("SELECT * FROM vw_Item");
            this.GrdList.DataSource = dt;

            if (dt == null || dt.Rows.Count == 0)
            {
                this.btnDelete.Enabled = false;
                this.BtnEdit.Enabled = false;
            }

            this.GrdList.Columns["ItemUnitId"].Visible = false;

        }

        #endregion

        #region " CODE - GRID "

        private void GrdList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ItemNo = GrdList.Rows[e.RowIndex].Cells["ItemNo"].Value.ToString();
            TxtItemNo.Text = ItemNo;
            TxtItemName.Text = GrdList.Rows[e.RowIndex].Cells["ItemName"].Value.ToString();
            TxtDescription.Text = GrdList.Rows[e.RowIndex].Cells["ItemDescription"].Value.ToString();
            TxtStockNo.Text = GrdList.Rows[e.RowIndex].Cells["Stock_No"].Value.ToString();
            CboUnit.SelectedValue = Convert.ToInt32(GrdList.Rows[e.RowIndex].Cells["ItemUnitID"].Value);
            this.btnDelete.Enabled = true;
            this.BtnEdit.Enabled = true;
        }

        #endregion

        #region " CODE - BUTTON "

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ItemNo = "";
            TxtItemNo.Text = this.GetItemNo();
            TxtStockNo.Text="";
            TxtDescription.Text="";
            TxtItemName.Text = "";
            CboUnit.SelectedIndex = -1;
            this.GrpItem.Enabled = true;
            this.btnDelete.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.GrpItem.Enabled = true;
            this.btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Msg.Confirm("Are you sure you want to delete " + this.TxtItemName.Text + "?", "DELETE Item") == DialogResult.Yes)
            {
                int rowCnt = 0;


                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Server.Connection;
                Cmd.CommandText = "SELECT COUNT(*) FROM vw_delivery_dtl WHERE Item_No='" + ItemNo + "'";
                rowCnt = Convert.ToInt32(Cmd.ExecuteScalar());

                if (rowCnt != 0)
                {
                    Msg.Warn("Sorry you cannot delete " + this.TxtItemName.Text + "! Because it being used in delivery.");
                    return;
                }

                Cmd = new SqlCommand();
                Cmd.Connection = Server.Connection;
                Cmd.CommandText = "SELECT COUNT(*) FROM vw_trans_dtl WHERE Item_No='" + ItemNo + "'";
                rowCnt = Convert.ToInt32(Cmd.ExecuteScalar());

                if (rowCnt != 0)
                {
                    Msg.Warn("Sorry you cannot delete " + this.TxtItemName.Text + "! Because it being used in issuance.");
                    return;
                }

                Server.Delete("tbl_Item", "WHERE ItemNo='" + ItemNo + "'");

                Msg.Info("Successfully Deleted");

                this.BtnNew.PerformClick();
                this.FillList();
                this.GrpItem.Enabled = false;

            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (this.TxtItemNo.Text == "")
            {
                Msg.Warn("Please input item no");
                this.TxtItemName.Focus();
                return;
            }

            if (this.TxtStockNo.Text == "")
            {
                Msg.Warn("Please input stock no");
                this.TxtStockNo.Focus();
                return;
            }

            if (this.CboUnit.SelectedIndex == -1)
            {
                Msg.Warn("Please select unit");
                this.CboUnit.Focus();
                return;
            }

            if (this.TxtItemName.Text == "")
            {
                Msg.Warn("Please input Item");
                this.TxtItemName.Focus();
                return;
            }

            if (this.TxtDescription.Text == "")
            {
                Msg.Warn("Please input description");
                this.TxtItemName.Focus();
                return;
            }


            SqlCommand cmd = new SqlCommand();
            String sql = "";

            if (ItemNo == "")
            {
                sql = "INSERT INTO tbl_Item (ItemNo,Stock_No,ItemName,ItemDescription,ItemUnitId) VALUES (@ItemNo,@Stock_No,@ItemName,@ItemDescription,@ItemUnitId)";
            }
            else
            {
                sql = "UPDATE tbl_Item SET Stock_No=@Stock_No,ItemName=@ItemName,ItemDescription=@ItemDescription,ItemUnitId=@ItemUnitId WHERE ItemNo=@ItemNo";
            }

            try
            {
                cmd.Connection = Server.Connection;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@ItemNo", this.TxtItemNo.Text);
                cmd.Parameters.AddWithValue("@Stock_No", this.TxtStockNo.Text);
                cmd.Parameters.AddWithValue("@ItemName", this.TxtItemName.Text);
                cmd.Parameters.AddWithValue("@ItemDescription", this.TxtDescription.Text);
                cmd.Parameters.AddWithValue("@ItemUnitId", this.CboUnit.SelectedValue);
                cmd.ExecuteNonQuery();

                Msg.Info("Successfuly saved.");

                this.BtnNew.PerformClick();
                this.FillList();
                this.GrpItem.Enabled = false;
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message.ToString());
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (ItemNo == "")
            {
                this.BtnNew.PerformClick();
            }
            this.GrpItem.Enabled = false;
        }

        #endregion

        #region " CODE - SUB "

        String GetItemNo()
        {
            String s, v, x;
            int i = 10001, m;

            DataTable st = new DataTable();
            st = Server.ToData("SELECT MAX(ItemNo) AS M FROM tbl_Item");
            m = Convert.ToInt32(st.Rows[0]["M"]);
            return  Convert.ToString(m+1);
        }

        #endregion

    }
}
