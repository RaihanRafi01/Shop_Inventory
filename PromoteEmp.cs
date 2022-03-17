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
    public partial class PromoteEmp : UserControl
    {
        public PromoteEmp()
        {
            InitializeComponent();
        }
        DataAccess db = new DataAccess();
        private void Reload() 
        {
            this.dgvPromote.Visible = true;
            string sql = "select Id,Name,Mail,Contact_number,Role from Login";
            db.ExecuteQuery(sql);

            this.dgvPromote.DataSource = db.Ds.Tables[0];
        }
        private void PromoteEmp_Load(object sender, EventArgs e)
        {
            Reload();
        }



        private void btnPromote_Click(object sender, EventArgs e)
        {
            string dml = @"UPDATE Login SET Role = '"+cmbBoxR.Text+"' WHERE Id = '"+txtSetId.Text+"';";
            db.ExecuteDMLQuery(dml);
            MessageBox.Show("ok");
            Reload(); 
        }

        private void dgvPromote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow row = dgvPromote.Rows[index];


            txtSetId.Text = row.Cells[0].Value.ToString();
        }
    }
}
