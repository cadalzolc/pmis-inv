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
    public partial class FrmCollege : Form
    {
        public FrmCollege()
        {
            InitializeComponent();
        }

        Boolean HasLoad = true;
        int CollegeID;
        DataTable dt = new DataTable();

        #region " CODE - FORM "

        private void FrmCollege_Load(object sender, EventArgs e)
        {
            this.FillList();
            this.HasLoad = false;
        }

        #endregion

        #region " CODE - FILL "

        void FillList()
        {
            dt = Server.ToData("SELECT * FROM tbl_College");
            this.LstBox.DataSource = dt;
            this.LstBox.DisplayMember = "College";
            this.LstBox.ValueMember = "CollegeId";

            if (dt == null || dt.Rows.Count == 0)
            {
                this.btnDelete.Enabled = false;
                this.BtnEdit.Enabled = false;
            }
            
        }

        #endregion

        #region " CODE - LISTBOX "

        private void LstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HasLoad == false)
            {
                CollegeID = Convert.ToInt32(this.LstBox.SelectedValue);
                TxtCollege.Text = this.dt.Rows[this.LstBox.SelectedIndex]["College"].ToString();
                this.BtnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
        }

        #endregion

        #region " CODE - BUTTON "

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CollegeID = 0;
            this.TxtCollege.Text = "";
            this.GrpCollege.Enabled = true;
            this.BtnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.GrpCollege.Enabled = true;
            this.btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Msg.Confirm("Are you sure you want to delete " + this.TxtCollege.Text + "?", "DELETE College") == DialogResult.Yes)
            {
                int rowCnt = 0;


                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Server.Connection;
                Cmd.CommandText = "SELECT COUNT(*) FROM tbl_UserCollege WHERE CollegeId=" + CollegeID;
                rowCnt = Convert.ToInt32(Cmd.ExecuteScalar());

                if (rowCnt != 0)
                {
                    Msg.Warn("Sorry you cannot delete " + this.TxtCollege.Text + "! Because it being used.");
                    return;
                }

                Server.Delete("tbl_College", "WHERE CollegeId=" + CollegeID);

                Msg.Info("Successfully Deleted");

                this.BtnNew.PerformClick();
                this.FillList();
                this.GrpCollege.Enabled = false;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.TxtCollege.Text == "")
            {
                Msg.Warn("Please input College");
                this.TxtCollege.Focus();
                return;
            }

            SqlCommand cmd = new SqlCommand();
            String sql = "";

            if (CollegeID == 0)
            {
                sql = "INSERT INTO tbl_College (College) VALUES (@College)";
            }
            else
            {
                sql = "UPDATE tbl_College SET College=@College WHERE CollegeID=" + CollegeID;
            }

            try
            {
                cmd.Connection = Server.Connection;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@College", this.TxtCollege.Text);
                cmd.ExecuteNonQuery();

                Msg.Info("Successfuly saved.");

                this.BtnNew.PerformClick();
                this.FillList();
                this.GrpCollege.Enabled = false;
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message.ToString());
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (CollegeID == 0)
            {
                this.BtnNew.PerformClick();
            }
            this.GrpCollege.Enabled = false;
        }

        #endregion

    }
}
