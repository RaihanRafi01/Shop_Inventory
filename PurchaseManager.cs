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
    public partial class PurchaseManager : Form
    {
        public PurchaseManager()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        private void hidee() 
        {
            dgvPmFi.Hide();
            dgvPmIn.Hide();
            lvlShowing.Hide();
            //insertOrder1.Hide();
            inventoryUpdate1.Hide();
            orderUpdate1.Hide();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            lvlShowing.Text = " showing Monthly Budget ";
            lvlShowing.Show();
            string sql = "select Monthly_budget from Finance";
            da.ExecuteQuery(sql);
            this.dgvPmFi.Visible = true;
            this.dgvPmFi.DataSource = da.Ds.Tables[0];
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            lvlShowing.Text = " showing Inventory ";
            lvlShowing.Show();
            string sql = "select * from Inventoryy";
            da.ExecuteQuery(sql);
            this.dgvPmIn.Visible = true;
            this.dgvPmIn.DataSource = da.Ds.Tables[0];
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
          

        }

        private void pendingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            string sql = "select * from Orderr";
            lvlShowing.Text = " showing Pending Order";
            lvlShowing.Show();
            da.ExecuteQuery(sql);
            this.dgvPmIn.Visible = true;
            this.dgvPmIn.DataSource = da.Ds.Tables[0];
        }

        private void inventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hidee();
            inventoryUpdate1.Show();
        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            orderUpdate1.Show();
        }
    }
}
