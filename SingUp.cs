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
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        DataAccess si = new DataAccess();

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
           
            string sql = @"insert into Login (Id,Name,Password,Mail,Role,Contact_number) values 
                        ('" + txtBoxId.Text + "','" + txtBoxName.Text + "','" + txtBoxPass.Text + "','" + txtBoxMail.Text + "','" + cmbBoxRole.Text + "','" + txtBoxContact.Text + "')";
            si.ExecuteDMLQuery(sql);
            MessageBox.Show("ok");
            this.Hide();
            Login lo = new Login();
            lo.Show();

        }

        private void lvlSingIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void AutoGenId()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0USD5B6;Initial Catalog=Project;User ID=sa;Password=Raihan.90#");
            con.Open();
            string sql = "select max(Id) from Login";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int Id = Convert.ToInt32(dr[0]);
            Id++;
            txtBoxId.Text = Id.ToString();
        }

        private void SingUp_Load(object sender, EventArgs e)
        {
            AutoGenId();
        }
    }
}
