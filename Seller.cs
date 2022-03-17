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
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reload() 
        
        {
            string sql = "select * from Orderr";
            da.ExecuteQuery(sql);
            lvlShowing.Show();
            this.dgvOrder.Visible = true;
            this.dgvOrder.DataSource = da.Ds.Tables[0];
            txtWholeSell.Text = "";
        }

        private void Calculation() 
        {
            lblMonth.Text = DateTime.Now.ToString("MMM");
            string ca = @"update Finance SET Shoping_expence = (select sum(Spent_total) from Inventoryy ) where Month = '"+lblMonth.Text+"' ;";
            da.ExecuteDMLQuery(ca);
            string cb = @"Update Finance Set Monthly_profit = (select Total_revenue - Shoping_expence from Finance) where Month = '"+lblMonth.Text+"';";
            da.ExecuteDMLQuery(cb);           
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reload();
            txtWholeSell.Show();
            btnAddItem.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtWholeSell.Text == "")

            {
                MessageBox.Show("Please Enter WholeSale Value");

            }
            else
            {
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                string sql = @"UPDATE Inventoryy SET Avaiable_quantity += " + lblQuantity.Text + " , Purchase_date = '" + lblDate.Text + "' , Spent_total += " + txtWholeSell.Text + "*" + lblQuantity.Text + "  " +
                             "WHERE Product_name = '" + lblSetName.Text + "'";
                da.ExecuteDMLQuery(sql);
                MessageBox.Show("sucess");

                string sql2 = @"delete from Orderr where Product_Name = '" + lblSetName.Text + "';";
                da.ExecuteDMLQuery(sql2);
                Calculation();
                Reload();
            }
            
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            int index = e.RowIndex;
            DataGridViewRow row = dgvOrder.Rows[index];
            lblSetName.Text = row.Cells[0].Value.ToString();
            lblQuantity.Text = row.Cells[1].Value.ToString();
            
        }

      
    }
}
