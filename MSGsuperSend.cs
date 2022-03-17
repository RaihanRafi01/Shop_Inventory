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
    public partial class MSGsuperSend : UserControl
    {
        public MSGsuperSend()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cmbRole.Text == "Purchase Manager")
            {
                
                string filepath = @"E:\C#\PROJECT\STARTUP\FinalProject\MSG\PM.txt";
                List<string> lines = File.ReadAllLines(filepath).ToList();
                lines.Add("Supervisor : " + txtMsg.Text + " ");
                File.WriteAllLines(filepath, lines);
                MessageBox.Show("Msg Sent!!!");
                txtMsg.Text = "";

            }
            else if (cmbRole.Text == "Seller")
            {
                string filepath = @"E:\C#\PROJECT\STARTUP\FinalProject\MSG\Seller.txt";
                List<string> lines = File.ReadAllLines(filepath).ToList();
                lines.Add("Supervisor : " + txtMsg.Text + " ");
                File.WriteAllLines(filepath, lines);
                MessageBox.Show("Msg Sent!!!");
                txtMsg.Text = "";
            }
            else
            {
                 MessageBox.Show("Please Select a Role");
            }

        }
    }
}
