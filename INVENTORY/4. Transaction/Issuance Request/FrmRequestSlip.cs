using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using LAZYANT_LIB;

namespace PMIS
{
    public partial class FrmRequestSlip : Form
    {
        public FrmRequestSlip(int KeyID, Hashtable h)
        {
            InitializeComponent();
            transID = KeyID;
            hd = h;
        }

        int transID;
        Hashtable hd = new Hashtable();
        DataTable dtInfo, dtDetail, dtItem;

        #region " CODE - GET TOTAL "

        void GetTotal()
        {
            this.dtDetail.AcceptChanges();
            double t = 0;
            foreach (DataRow row in this.dtDetail.Rows)
            {
                t = t + Convert.ToDouble(row["totalCOst"]);
            }
            this.txtTotal.Text = t.ToString("#0.00");
        }


        #endregion

        #region " CODE - FORM "

        private void New_Request_Load(object sender, EventArgs e)
        {
            this.fillInfo();
            this.fillCmb();
            this.fillLstBox();
        }

        #endregion

        #region " CODE - FILL "

        void fillInfo()
        {

            //GET REQUEST INFO
            this.dtInfo = Server.ToData("SELECT * FROM vw_trans WHERE transId=" + transID);

            if (this.dtInfo == null || this.dtInfo.Rows.Count == 0)
            {
                txtTotal.Text = "0.00";
            }
            else
            {

                txtrb.Text = this.dtInfo.Rows[0]["RequestedBy"].ToString();
                txtrd.Text = this.dtInfo.Rows[0]["RequestedDate"].ToString();
                comboBox1.Text = this.dtInfo.Rows[0]["College"].ToString();
                txtRC.Text = this.dtInfo.Rows[0]["RC"].ToString();
                txtRN.Text = this.dtInfo.Rows[0]["RISNo"].ToString();
                txtCode.Text = this.dtInfo.Rows[0]["Code"].ToString();
                txtSN.Text = this.dtInfo.Rows[0]["SAINo"].ToString();
                txtPurpose.Text = this.dtInfo.Rows[0]["Purpose"].ToString();
                txtTotal.Text = this.dtInfo.Rows[0]["Total"].ToString();
            }


            //GET REQUEST DETAILS
            this.dtDetail = Server.ToData("SELECT * FROM vw_trans_dtl WHERE transId =" + transID.ToString());

            GrdDetails.DataSource = null;
            GrdDetails.DataSource = this.dtDetail;

            this.GrdDetails.Columns["transid"].Visible = false;
            this.GrdDetails.Columns["ItemUnitId"].Visible = false;
            this.GrdDetails.Columns["ItemDescription"].Visible = false;
            this.GrdDetails.Columns["transdtlId"].Visible = false;
            this.GrdDetails.Columns["Stock_no"].Visible = false;
            this.GrdDetails.Columns["approve"].Visible = false;
            this.GrdDetails.Columns["transDate"].Visible = false;

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

        void fillCmb()
        {
            comboBox1.DataSource = Server.ToData("SELECT * FROM tbl_College");
            comboBox1.DisplayMember = "College";
            comboBox1.ValueMember = "CollegeId";
        }

        void fillLstBox()
        {
            dtItem=Server.ToData("SELECT * FROM vw_item_unit");
            LstItems.DataSource = this.dtItem;
            LstItems.DisplayMember = "ItemName";
            LstItems.ValueMember = "ItemNo";
        }

        #endregion

        #region " CODE - LISTBOX "

        private void LstItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataRow r = this.dtDetail.NewRow();
            r["item_no"] = this.dtItem.Rows[this.LstItems.SelectedIndex]["itemno"];
            r["ItemName"] = this.dtItem.Rows[this.LstItems.SelectedIndex]["itemName"];
            r["Unit"] = this.dtItem.Rows[this.LstItems.SelectedIndex]["Unit"];
            r["UnitPrice"] = 0;
            r["Quantity"] = 0;
            r["totalCost"] = 0;
            this.dtDetail.Rows.Add(r);
            this.dtDetail.AcceptChanges();
        }
      
        #endregion

        #region " CODE - GRID "

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow g = this.GrdDetails.Rows[e.RowIndex];
            if (Convert.ToInt32(g.Cells["quantity"].Value) < 0)
            {
                g.Cells["quantity"].Value = 0;
            }
            else if (Convert.ToInt32(g.Cells["unitprice"].Value) < 0)
            {
                g.Cells["unitprice"].Value = 0;
            }
            else { }

            g.Cells["totalCost"].Value = Convert.ToInt32(g.Cells["quantity"].Value) * Convert.ToInt32(g.Cells["unitprice"].Value);

            this.GetTotal();

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Invalid Input");
        }

        private void GrdDetails_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {  
            this.GetTotal();
        }

        #endregion

        #region " CODE - BUTON "

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            this.dtDetail.AcceptChanges();
            string get = "";

            if (transID == 0) //CHECK CURRENT ID ( 0 = INSERT | ELSE = UPDATE )
            {   
                //INSERT QUERY
                get = "INSERT INTO tbl_trans(transTypeId,CollegeId, RequestedBy, RequestedDate, RISNo, SAINo,RC,Code,Total,Purpose,EncoderId)VALUES(2, @CI, @rb, @rd,@rn,@sn,@rc,@c,@t,@p,@ei)";

                this.hd["Code"] = this.txtCode.Text;
                this.hd["RISNo"] = this.txtRN.Text;
                this.hd["SAINo"] = this.txtSN.Text;
                this.hd["Total"] = this.txtTotal.Text;
                this.hd["Purpose"] = this.txtPurpose.Text;
                this.hd["College"] = this.comboBox1.Text;
                this.hd["RequestedBy"] = this.txtrb.Text;
                this.hd["RequestedDate"] = this.txtrd.Text;
            }
            else
            {   
                //UPDATE QUERY
                get = "UPDATE tbl_trans SET CollegeId=@CI, RequestedBy=@rb, RequestedDate=@rd, RISNo=@rn, SAINo=@sn,RC=@rc,Code=@c,Total=@t,Purpose=@p,EncoderId=@ei WHERE transid=" + transID.ToString();
            }

            //FILL DATA BASED ON GIVEN PARAMETERS
            SqlCommand cmd = new SqlCommand(get, Server.Connection);

            cmd.Parameters.AddWithValue("@CI", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@rb", txtrb.Text);
            cmd.Parameters.AddWithValue("@rd", txtrd.Text);
            cmd.Parameters.AddWithValue("@rn", txtRN.Text);
            cmd.Parameters.AddWithValue("@sn", txtSN.Text);
            cmd.Parameters.AddWithValue("@c", txtCode.Text);
            cmd.Parameters.AddWithValue("@rc", txtRC.Text);
            cmd.Parameters.AddWithValue("@t", txtTotal.Text);
            cmd.Parameters.AddWithValue("@p", txtPurpose.Text);
            cmd.Parameters.AddWithValue("@ei", Current.User.ID);
            cmd.ExecuteNonQuery();

            //GET PRIMARY KEY AFTER SAVING! FOR AUTOGENERATED ROWS COLUMN ONLY
            if (transID == 0)
            {
                get = "SELECT @@IDENTITY";
                cmd = new SqlCommand(get, Server.Connection);
                transID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            //DELETE OLD DETAILS IN TABLE
            get = "DELETE FROM tbl_Trans_dtl WHERE transid=" + transID.ToString();
            cmd = new SqlCommand(get, Server.Connection);
            cmd.ExecuteNonQuery();

            //LOOP ALL THRU ROW DETAILS
            foreach (DataRow row in this.dtDetail.Rows)
            {
                //INSERT NEW DETAILS IN TABLE
                get = "INSERT INTO tbl_Trans_dtl(transId, Item_no, UnitPrice, Quantity, totalCost)VALUES(@transI, @IN, @UP, @q,@tC)";
                cmd = new SqlCommand(get, Server.Connection);
                cmd.Parameters.AddWithValue("@transI", transID.ToString());
                cmd.Parameters.AddWithValue("@IN", row["item_no"].ToString());
                cmd.Parameters.AddWithValue("@UP", row["UnitPrice"].ToString());
                cmd.Parameters.AddWithValue("@q", row["Quantity"].ToString());
                cmd.Parameters.AddWithValue("@tC", row["totalCost"].ToString());
                cmd.ExecuteNonQuery();
            }

            Msg.Info("Request has been submitted!");
            Export.ToExcel.Issuance(true, dtDetail, hd);

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion     

    }
}
