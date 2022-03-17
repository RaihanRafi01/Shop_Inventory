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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();

        private void txtID_Enter(object sender, EventArgs e)
        {
            txtID.ForeColor = Color.Black;
            if (txtID.Text == "E-Mail or ID")
            {
                txtID.Text = "";

            }
        }

        private void txtPASS_Enter(object sender, EventArgs e)
        {
            txtPASS.UseSystemPasswordChar = true;
            txtPASS.ForeColor = Color.Black;
            if (txtPASS.Text == "Password")
            {
                txtPASS.Text = "";

            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            
            if (this.txtID.Text == "")
            {
                txtID.Text = "E-Mail or ID";
                
            }
            else
            {
                return;
            }
        }

        private void txtPASS_Leave(object sender, EventArgs e)
        {
            
            if (this.txtPASS.Text == "")
            {
                txtPASS.UseSystemPasswordChar = false;
                txtPASS.Text = "Password";
            }
            
            else
            {
                txtPASS.UseSystemPasswordChar = true;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login

            string sql = @"select * from Login where Password = '" + txtPASS.Text + "' and id = '" + txtID.Text + "'or Mail = '" + txtID.Text + "';";

            da.ExecuteQuery(sql);

            if (da.Ds.Tables[0].Rows.Count == 1)
            {

                MessageBox.Show("Login Valid");


                if (da.Ds.Tables[0].Rows[0][4].ToString() == "Supervisor")
                {
                    MessageBox.Show(" welcome Supervisor "+ da.Ds.Tables[0].Rows[0][1].ToString());
                    this.Hide();
                    Supervisor s1 = new Supervisor();
                    s1.Show();
                }
                else if (da.Ds.Tables[0].Rows[0][4].ToString() == "Purchase Manager")
                {
                    MessageBox.Show(" welcome Purchase Manager " + da.Ds.Tables[0].Rows[0][1].ToString());
                    this.Hide();
                    PurchaseManager p1 = new PurchaseManager();
                    p1.Show();
                }
                else if (da.Ds.Tables[0].Rows[0][4].ToString() == "Seller")
                {
                    MessageBox.Show(" welcome Seller " + da.Ds.Tables[0].Rows[0][1].ToString());
                    this.Hide();
                    Seller se1 = new Seller();
                    se1.Show();
                }
            
            }
            else
                {
                    MessageBox.Show("Login Invalid");

                }

            }

        private void lvlSingup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingUp sg = new SingUp();
            sg.Show();
        }




    }
        
}


