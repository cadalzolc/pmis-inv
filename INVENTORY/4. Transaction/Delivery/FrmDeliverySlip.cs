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
    public partial class FrmDeliverySlip : Form
    {
        public FrmDeliverySlip(int KeyID)
        {
            InitializeComponent();
            deliveryId = KeyID;
        }

        int deliveryId;
        DataTable dtItem, dtInfo, dtDetail;

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

        private void FrmDeliverySlip_Load(object sender, EventArgs e)
        {
            this.fillInfo();
            this.fillLstBox();
        }

        #endregion

        #region " CODE - FILL "

        void fillInfo()
        {

            //GET REQUEST INFO
            this.dtInfo = Server.ToData("SELECT * FROM vw_delivery WHERE deliveryId =" + deliveryId.ToString() + "");

            if (this.dtInfo == null || this.dtInfo.Rows.Count == 0)
            {
                txtTotal.Text = "0.00";
            }
            else
            {
                this.txtdeliverydate.Text = this.dtInfo.Rows[0]["deliveryDate"].ToString();
                this.txtDeliveryNo.Text = this.dtInfo.Rows[0]["deliveryNo"].ToString();
                this.txtsupplier.Text = this.dtInfo.Rows[0]["supplier"].ToString();
                this.txtTotal.Text = this.dtInfo.Rows[0]["TotalAmount"].ToString();
            }


            //GET REQUEST DETAILS
            this.dtDetail = Server.ToData("SELECT * FROM vw_delivery_dtl WHERE deliveryId =" + deliveryId.ToString());

            GrdDetails.DataSource = null;
            GrdDetails.DataSource = this.dtDetail;

            this.GrdDetails.Columns["deliveryId"].Visible = false;
            this.GrdDetails.Columns["ItemUnitId"].Visible = false;
            this.GrdDetails.Columns["deliverydtlId"].Visible = false;
            this.GrdDetails.Columns["approve"].Visible = false;
            this.GrdDetails.Columns["deliveryDate"].Visible = false;
            this.GrdDetails.Columns["stock_No"].Visible = false;
            this.GrdDetails.Columns["itemdescription"].Visible = false;
       

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

        void fillLstBox()
        {
            dtItem = Server.ToData("SELECT * FROM vw_item_unit");
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

        private void GrdDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Invalid Input");
        }

        private void GrdDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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

        private void GrdDetails_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.GetTotal();
        }

        #endregion

        #region " CODE - BUTTON "

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.dtDetail.AcceptChanges();


            if(this.txtsupplier.Text=="")
            {
                Msg.Warn("Please input Supplier");
                this.txtsupplier.Focus();
                return;
            }

            if (this.txtDeliveryNo.Text == "")
            {
                Msg.Warn("Please input delivery no");
                this.txtDeliveryNo.Focus();
                return;
            }

            string get = "";

            if (deliveryId == 0) //CHECK CURRENT ID ( 0 = INSERT | ELSE = UPDATE )
            {
                //INSERT QUERY
                get = "INSERT INTO tbl_delivery (Supplier,DeliveryNo,DeliveryDate,TotalAmount,ReceivedBy,ReceivedDate,EncoderId) VALUES (@s,@dn,@dd,@ta,@rb,@rd,@ei)";
            }
            else
            {
                //UPDATE QUERY
                get = "UPDATE tbl_delivery SET Supplier=@s, DeliveryNo=@dn, DeliveryDate=@dd, TotalAmount=@ta, ReceivedBy=@rb, ReceivedDate=@rd, EncoderId=@ei WHERE deliveryId=" + deliveryId.ToString();
            }

            //FILL DATA BASED ON GIVEN PARAMETERS
            SqlCommand cmd = new SqlCommand(get, Server.Connection);

            cmd.Parameters.AddWithValue("@s", this.txtsupplier.Text);
            cmd.Parameters.AddWithValue("@dn", this.txtDeliveryNo.Text);
            cmd.Parameters.AddWithValue("@dd", this.txtdeliverydate.Text);
            cmd.Parameters.AddWithValue("@ta", this.txtTotal.Text);
            cmd.Parameters.AddWithValue("@rb", this.txtReceivedBy.Text);
            cmd.Parameters.AddWithValue("@rd", this.txtReceivedDate.Text);
            cmd.Parameters.AddWithValue("@ei", Current.User.ID);
            cmd.ExecuteNonQuery();

            //GET PRIMARY KEY AFTER SAVING! FOR AUTOGENERATED ROWS COLUMN ONLY
            if (deliveryId == 0)
            {
                get = "SELECT @@IDENTITY";
                cmd = new SqlCommand(get, Server.Connection);
                deliveryId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            //DELETE OLD DETAILS IN TABLE
            get = "DELETE FROM tbl_delivery_dtl WHERE deliveryId=" + deliveryId.ToString();
            cmd = new SqlCommand(get, Server.Connection);
            cmd.ExecuteNonQuery();

            //LOOP ALL THRU ROW DETAILS
            foreach (DataRow row in this.dtDetail.Rows)
            {
                //INSERT NEW DETAILS IN TABLE
                get = "INSERT INTO tbl_delivery_dtl(deliveryId, Item_no, UnitPrice, Quantity, totalCost)VALUES(@deliveryI, @IN, @UP, @q,@tC)";
                cmd = new SqlCommand(get, Server.Connection);
                cmd.Parameters.AddWithValue("@deliveryI", deliveryId.ToString());
                cmd.Parameters.AddWithValue("@IN", row["item_no"].ToString());
                cmd.Parameters.AddWithValue("@UP", row["UnitPrice"].ToString());
                cmd.Parameters.AddWithValue("@q", row["Quantity"].ToString());
                cmd.Parameters.AddWithValue("@tC", row["totalCost"].ToString());
                cmd.ExecuteNonQuery();
            }

            Msg.Info("Delivery successfuly saved!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
