using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using LAZYANT_LIB;

namespace PMIS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region " CODE - BUTTON "

        private void btnLogin_Click(object sender, EventArgs e)
        {
  
            string get = "SELECT * FROM vw_user WHERE UserName=@user AND UserPass=@pass";

            SqlConnection conn = new SqlConnection(Server.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(get,conn);
            SqlDataReader sdr = null;

            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                sdr.Read();    
                Current.User.ID = Convert.ToInt32(sdr["UserId"]);
                Current.User.Name = txtUser.Text;
                Current.User.Pass = txtPass.Text;
                Current.User.Role.ID = Convert.ToInt32(sdr["UserRoleId"]);
                Current.User.Role.Name = sdr["UserRole"].ToString();
                sdr.Close();
                this.Close();
            }
            else 
            {
                Msg.Warn("Invalud username or password;");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        
    }
}
