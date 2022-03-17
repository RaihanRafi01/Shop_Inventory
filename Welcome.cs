using System;
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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

       

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //Login
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            //sing up
            this.Hide();
            SingUp sg = new SingUp();
            sg.Show();
        }
    }
}
