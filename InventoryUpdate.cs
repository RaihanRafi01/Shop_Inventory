using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class InventoryUpdate : UserControl
    {
        public InventoryUpdate()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE Inventoryy SET Product_name = '"+txtName.Text+"', Avaiable_quantity = "+txtQuantity.Text+" , " +
                         "MSRP_per_item = '"+txtMSRP.Text+"' , Purchase_date = '"+txtDate.Text+"' , Spent_total = '"+txtSpent.Text+"' WHERE Serial_no = "+txtSerial.Text+";";
            da.ExecuteDMLQuery(sql);
            MessageBox.Show("ok");
            Reload();
        }

        private void dgvInUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvInUp.Rows[index];
            txtName.Text = row.Cells[0].Value.ToString();
            txtQuantity.Text = row.Cells[1].Value.ToString();
            txtMSRP.Text = row.Cells[2].Value.ToString();
            txtDate.Text = row.Cells[3].Value.ToString();
            txtSpent.Text = row.Cells[4].Value.ToString();
            txtSerial.Text = row.Cells[5].Value.ToString();
        }

        private void InventoryUpdate_Load(object sender, EventArgs e)
        {
            AutoGenSerial();
            Reload();
        }

        private void Reload()

        {
            string sql = "select * from Inventoryy";
            da.ExecuteQuery(sql);
            this.dgvInUp.Visible = true;
            this.dgvInUp.DataSource = da.Ds.Tables[0];
        }

        private void AutoGenSerial()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0USD5B6;Initial Catalog=Project;User ID=sa;Password=Raihan.90#");
            con.Open();
            string sql = "select max(Serial_no) from inventoryy";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int Id = Convert.ToInt32(dr[0]);
            Id++;
            txtSerial.Text = Id.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = @"insert into Inventoryy (Product_name , Avaiable_quantity , MSRP_per_item , Purchase_date , Spent_total , Serial_no) 
                         values ('"+txtName.Text+"' , "+txtQuantity.Text+" , '"+txtMSRP.Text+"' , '"+txtDate.Text+"' , '"+txtSpent.Text+"' , "+txtSerial.Text+");";
            da.ExecuteDMLQuery(sql);
            MessageBox.Show("ok");
            Reload();
            Clear();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
            AutoGenSerial();
            Clear();
        }
        private void Clear() 
        {
            txtDate.Text = "";
            txtMSRP.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtSpent.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"delete from Inventoryy where Serial_no = "+txtSerial.Text+";";
            da.ExecuteDMLQuery(sql);
            MessageBox.Show("Item Deleted");
            Reload();
            Clear();
        }
    }
}
