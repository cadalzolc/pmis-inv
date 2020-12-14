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
    public partial class FrmUnits : Form
    {
        public FrmUnits()
        {
            InitializeComponent();
        }

        Boolean HasLoad = true;
        int UnitID;
        DataTable dt = new DataTable();

        #region " CODE - FORM "

        private void FrmUnits_Load(object sender, EventArgs e)
        {
            this.FillList();
        }

        #endregion

        #region " CODE - FILL "

        void FillList()
        {
            dt = Server.ToData("SELECT * FROM tbl_Unit");
            this.LstBox.DataSource = dt;
            this.LstBox.DisplayMember = "Unit";
            this.LstBox.ValueMember = "UnitId";

            if (dt == null || dt.Rows.Count == 0)
            {
                this.btnDelete.Enabled = false;
                this.BtnEdit.Enabled=false;
            }

        }

        #endregion

        #region " CODE - LISTBOX "

        private void LstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HasLoad == false) 
            {
                UnitID = Convert.ToInt32(this.LstBox.SelectedValue);
                TxtUnit.Text = this.dt.Rows[this.LstBox.SelectedIndex]["Unit"].ToString();
                BtnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            
        }
        
        private void LstBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.HasLoad = false;
        }

        #endregion

        #region " CODE - BUTTON "

        private void BtnNew_Click(object sender, EventArgs e)
        {
            UnitID = 0;
            this.TxtUnit.Text = "";
            this.GrpUnit.Enabled = true;
            this.BtnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.GrpUnit.Enabled = true;
            this.btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Msg.Confirm("Are you sure you want to delete " + this.TxtUnit.Text + "?", "DELETE UNIT") == DialogResult.Yes)
            {
                int rowCnt = 0;


                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Server.Connection;
                Cmd.CommandText = "SELECT COUNT(*) FROM tbl_Item WHERE ItemUnitId="+UnitID;
                rowCnt = Convert.ToInt32(Cmd.ExecuteScalar());

                if (rowCnt != 0) {
                    Msg.Warn("Sorry you cannot delete " + this.TxtUnit.Text + "! Because it being used by an item.");
                    return;
                }

                Server.Delete("tbl_Unit", "WHERE UnitId=" + UnitID);

                Msg.Info("Successfully Deleted");

                this.BtnNew.PerformClick();
                this.FillList();
                this.GrpUnit.Enabled = false;

            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.TxtUnit.Text == "") 
            {
                Msg.Warn("Please input unit");
                this.TxtUnit.Focus();
                return;
            }

            SqlCommand cmd = new SqlCommand();
            String sql = "";

            if (UnitID == 0)
            {
                sql = "INSERT INTO tbl_Unit (Unit) VALUES (@Unit)";    
            }
            else 
            {
                sql = "UPDATE tbl_Unit SET Unit=@Unit WHERE UnitID=" + UnitID;
            }

            try
            {
                cmd.Connection = Server.Connection;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Unit", this.TxtUnit.Text);
                cmd.ExecuteNonQuery();

                Msg.Info("Successfuly saved.");

                this.BtnNew.PerformClick();
                this.FillList();
                this.GrpUnit.Enabled = false;
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message.ToString());
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (UnitID == 0)
            {
                this.BtnNew.PerformClick();
            }
            this.GrpUnit.Enabled = false;
        }

        #endregion
    }
}
