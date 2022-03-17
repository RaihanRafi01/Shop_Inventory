using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Supervisor : Form
    {
        public Supervisor()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        private void hidee()
        {
            promoteEmp1.Hide();
            dgvFinance.Hide();
            dgvInventory.Hide();
            dgvLogin.Hide();
            lvlShowing.Hide();
            
            txtBoxSearchId.Hide();
            txtBoxSearchMail.Hide();
            txtBoxSearchName.Hide();
            txtBoxSearchRole.Hide();
            txtBoxSearchCont.Hide();
            btnSearchId.Hide();
            btnSearchMail.Hide();
            btnSearchRole.Hide();
            btnSearchName.Hide();
            btnSearchCont.Hide();
        }

        private void Reload() 
        {
            string sql = "select Id,Name,Mail,Contact_number,Role from Login";
            da.ExecuteQuery(sql);
            this.dgvLogin.Visible = true;
            this.dgvLogin.DataSource = da.Ds.Tables[0];
        }

        private void dgvLogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            lvlShowing.Text = " showing Employee Information ";
            lvlShowing.Show();
            Reload();
            
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            lvlShowing.Text = " showing  Inventory ";
            lvlShowing.Show();
            string sql = "select Product_name,Avaiable_quantity,MSRP_per_item,Purchase_date from Inventoryy";
            da.ExecuteQuery(sql);
            this.dgvInventory.Visible = true;
            this.dgvInventory.DataSource = da.Ds.Tables[0];
        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            lvlShowing.Text = " showing Finance ";
            lvlShowing.Show();
            string sql = "select * from Finance";
            da.ExecuteQuery(sql);
            this.dgvFinance.Visible = true;
            this.dgvFinance.DataSource = da.Ds.Tables[0];
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            


        }

        private void byIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            txtBoxSearchId.Show();
            btnSearchId.Show();
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            string se = "select Id,Name,Mail,Contact_number,Role  from Login where id = "+txtBoxSearchId.Text+"";
            da.ExecuteQuery(se);
            this.dgvLogin.Visible = true;
            this.dgvLogin.DataSource = da.Ds.Tables[0];
            txtBoxSearchId.Text = "";
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            btnSearchName.Show();
            txtBoxSearchName.Show();
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string se = "select Id,Name,Mail,Contact_number,Role  from Login where Name = '" + txtBoxSearchName.Text + "'";
            da.ExecuteQuery(se);
            this.dgvLogin.Visible = true;
            this.dgvLogin.DataSource = da.Ds.Tables[0];
            txtBoxSearchName.Text = "";
        }

        private void byMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            btnSearchMail.Show();
            txtBoxSearchMail.Show();
        }

        private void btnSearchMail_Click(object sender, EventArgs e)
        {
            string se = "select Id,Name,Mail,Contact_number,Role  from Login where Mail = '" + txtBoxSearchMail.Text + "'";
            da.ExecuteQuery(se);
            this.dgvLogin.Visible = true;
            this.dgvLogin.DataSource = da.Ds.Tables[0];
            txtBoxSearchMail.Text = "";
        }

        private void byRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            btnSearchRole.Show();
            txtBoxSearchRole.Show();
            
        }

        private void btnSearchRole_Click(object sender, EventArgs e)
        {
            string se = "select Id,Name,Mail,Contact_number,Role  from Login where Role = '" + txtBoxSearchRole.Text + "'";
            da.ExecuteQuery(se);
            this.dgvLogin.Visible = true;
            this.dgvLogin.DataSource = da.Ds.Tables[0];
            
        }

        private void byContactNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidee();
            btnSearchCont.Show();
            txtBoxSearchCont.Show();
        }

        private void btnSearchCont_Click(object sender, EventArgs e)
        {
            string se = "select Id,Name,Mail,Contact_number,Role  from Login where Contact_number = '" + txtBoxSearchCont.Text + "'";
            da.ExecuteQuery(se);
            this.dgvLogin.Visible = true;
            this.dgvLogin.DataSource = da.Ds.Tables[0];
            txtBoxSearchCont.Text = "";
        }

       

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeePositionTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.promoteEmp1.Show();
        }

        private void toPurchaseManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msGsuperSend1.Show();
        }

        private void toSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgShowSupervisor1.Show();
        }
    }
}
