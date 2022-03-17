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
    public partial class InsertOrder : UserControl
    {
        public InsertOrder()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            dateOrder.Text = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = @"INSERT INTO Orderr (Product_Name , Order_Quantity , Order_Date , Deadline_Date)
            VALUES ('"+cmbBoxItem.Text+"', "+txtBoxAmount.Text+", '"+dateOrder.Text+"' , '"+DateDeadline.Text+"' )";
            da.ExecuteDMLQuery(sql);
            MessageBox.Show("Order placed !!");
            txtBoxAmount.Text = "";
            cmbBoxItem.Text = "";
            


        }
    }
}
