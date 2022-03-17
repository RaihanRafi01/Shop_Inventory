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
    public partial class MSGpmSend : UserControl
    {
        public MSGpmSend()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMsg.Text == "")
            {
                MessageBox.Show("Please Type Some Message to Send");
            }
            else
            {
                lblTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
                if (cmbRole.Text == "Supervisor")
                {

                    string filepath = @"E:\C#\PROJECT\STARTUP\FinalProject\MSG\Super.txt";
                    List<string> lines = File.ReadAllLines(filepath).ToList();
                    lines.Add("Purchase Manager : " + txtMsg.Text + " - " + lblTime.Text + "");
                    File.WriteAllLines(filepath, lines);
                    MessageBox.Show("Message Sent!!!");
                    txtMsg.Text = "";

                }
                else if (cmbRole.Text == "Seller")
                {
                    string filepath = @"E:\C#\PROJECT\STARTUP\FinalProject\MSG\Seller.txt";
                    List<string> lines = File.ReadAllLines(filepath).ToList();
                    lines.Add("Purchase Manager : " + txtMsg.Text + " - " + lblTime.Text + "");
                    File.WriteAllLines(filepath, lines);
                    MessageBox.Show("Message Sent!!!");
                    txtMsg.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Select a Role");

                }
            }
        }
    }
}
