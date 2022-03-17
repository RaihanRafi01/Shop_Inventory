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
    public partial class MSGpmShow : UserControl
    {
        public MSGpmShow()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string filepath = @"E:\C#\PROJECT\STARTUP\FinalProject\MSG\PM.txt";
            StreamReader sr = new StreamReader(filepath);
            txtShow.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
