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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        int UserId = 0;
        DataTable dt = new DataTable();

        #region " CODE - FORM "

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            this.FillList();
            MyForm.Combo.Fill(this.CboRole, "SELECT * FROM tbl_UserRole", "UserRole", "UserRoleId");
        }

        #endregion

        #region " CODE - FILL "

        void FillList()
        {
            dt = Server.ToData("SELECT * FROM vw_user WHERE Active=1");
            this.GrdList.DataSource = dt;

            if (dt == null || dt.Rows.Count == 0)
            {
                this.btnDelete.Enabled = false;
                this.BtnEdit.Enabled = false;
            }

            this.GrdList.Columns["UserId"].Visible = false;
            this.GrdList.Columns["UserRoleId"].Visible = false;
            this.GrdList.Columns["UserPass"].Visible = false;

        }

        #endregion

        #region " CODE - GRID "

        private void GrdList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserId = Convert.ToInt32(GrdList.Rows[e.RowIndex].Cells["UserId"].Value);
            this.TxtUsername.Text = GrdList.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            this.TxtPassword.Text = GrdList.Rows[e.RowIndex].Cells["UserPass"].Value.ToString();
            this.CboRole.SelectedValue = Convert.ToInt32(GrdList.Rows[e.RowIndex].Cells["UserRoleId"].Value);
            this.BtnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
        }

        #endregion

        #region " CODE - BUTTON "

        private void BtnNew_Click(object sender, EventArgs e)
        {
            UserId = 0;
            this.TxtUsername.Text = "";
            this.TxtPassword.Text = "";
            this.CboRole.SelectedIndex = -1;
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
            if (Msg.Confirm("Are you sure you want to deactivate " + this.TxtUsername.Text + "?", "DEACTIVATE USER") == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
            
                try
                {
                    cmd.Connection = Server.Connection;
                    cmd.CommandText = "UPDATE tbl_User SET Active=0 WHERE UserId=" + UserId.ToString();
                    cmd.ExecuteNonQuery();

                    Msg.Info("Deactivdated.");

                    this.BtnNew.PerformClick();
                    this.FillList();
                    this.GrpItem.Enabled = false;
                }
                catch (Exception ex)
                {
                    Msg.Error(ex.Message.ToString());
                }
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.TxtUsername.Text == "")
            {
                Msg.Warn("Please input username");
                this.TxtUsername.Focus();
                return;
            }

            if (this.TxtPassword.Text == "")
            {
                Msg.Warn("Please input password");
                this.TxtPassword.Focus();
                return;
            }

            if (this.CboRole.SelectedIndex == -1)
            {
                Msg.Warn("Please select role");
                this.CboRole.Focus();
                return;
            }

       
            SqlCommand cmd = new SqlCommand();
            String sql = "";

            if (UserId == 0)
            {
                sql = "INSERT INTO tbl_User (UserName,UserPass,UserRoleId) VALUES (@UserName,@UserPass,@UserRoleId)";
            }
            else
            {
                sql = "UPDATE tbl_User SET UserName=@UserName,UserPass=@UserPass,UserRoleId=@UserRoleId WHERE UserId=" + UserId.ToString();
            }

            try
            {
                cmd.Connection = Server.Connection;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@UserName", this.TxtUsername.Text);
                cmd.Parameters.AddWithValue("@UserPass", this.TxtPassword.Text);
                cmd.Parameters.AddWithValue("@UserRoleId", this.CboRole.SelectedValue);
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
            if (this.TxtUsername.Text == "")
            {
                this.BtnNew.PerformClick();
            }
            this.GrpItem.Enabled = false;
        }

        #endregion      

    }
}
