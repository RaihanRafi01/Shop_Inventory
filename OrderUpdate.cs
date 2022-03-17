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
    public partial class OrderUpdate : UserControl
    {
        public OrderUpdate()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();

        private void Reload()

        {
            string sql = "select * from Orderr";
            da.ExecuteQuery(sql);
            this.dgvOrUp.Visible = true;
            this.dgvOrUp.DataSource = da.Ds.Tables[0];
        }

        private void AutoGenSerial()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0USD5B6;Initial Catalog=Project;User ID=sa;Password=Raihan.90#");
            con.Open();
            string sql = "select max(Product_Serial) from Orderr";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int Id = Convert.ToInt32(dr[0]);
            Id++;
            txtSerial.Text = Id.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"update Orderr SET Product_Name = '"+txtName.Text+"' , Order_Quantity = "+txtQuantity.Text+" , Order_Date = '"+txtOrderDate.Text+"' , Deadline_Date = '"+txtDeadlineDate.Text+"' WHERE Product_Serial = "+txtSerial.Text+";";
            da.ExecuteDMLQuery(sql);
            MessageBox.Show("ok");
            Reload();
        }

        private void OrderUpdate_Load(object sender, EventArgs e)
        {
            AutoGenSerial();
            Reload();
        }

        private void Clear()
        {
            txtDeadlineDate.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtOrderDate.Text = "";
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
            AutoGenSerial();
            Clear();
        }

        private void dgvOrUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvOrUp.Rows[index];
            txtName.Text = row.Cells[0].Value.ToString();
            txtQuantity.Text = row.Cells[1].Value.ToString();
            txtOrderDate.Text = row.Cells[2].Value.ToString();
            txtDeadlineDate.Text = row.Cells[3].Value.ToString();
            txtSerial.Text = row.Cells[4].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = @"insert into Orderr (Product_Name,Order_Quantity,Order_Date,Deadline_Date,Product_Serial) VALUES ('"+txtName.Text+"' , "+txtQuantity.Text+" , '"+txtOrderDate.Text+"' , '"+txtDeadlineDate.Text+"' , "+txtSerial.Text+");";
            da.ExecuteDMLQuery(sql);
            MessageBox.Show("ok");
            Reload();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"delete from Orderr where Product_Serial = " + txtSerial.Text + ";";
            da.ExecuteDMLQuery(sql);
            MessageBox.Show("Item Deleted");
            Reload();
            Clear();
        }
    }
}
