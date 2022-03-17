
namespace FinalProject
{
    partial class PromoteEmp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSetId = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbBoxR = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnPromote = new MetroFramework.Controls.MetroButton();
            this.dgvPromote = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromote)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSetId
            // 
            this.txtSetId.Location = new System.Drawing.Point(3, 3);
            this.txtSetId.Name = "txtSetId";
            this.txtSetId.Size = new System.Drawing.Size(15, 22);
            this.txtSetId.TabIndex = 1;
            this.txtSetId.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(149, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Promote User To";
            // 
            // cmbBoxR
            // 
            this.cmbBoxR.FormattingEnabled = true;
            this.cmbBoxR.ItemHeight = 24;
            this.cmbBoxR.Items.AddRange(new object[] {
            "Supervisor",
            "Purchase Manager",
            "Seller"});
            this.cmbBoxR.Location = new System.Drawing.Point(294, 46);
            this.cmbBoxR.Name = "cmbBoxR";
            this.cmbBoxR.Size = new System.Drawing.Size(121, 30);
            this.cmbBoxR.TabIndex = 3;
            this.cmbBoxR.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(231, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(258, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Select Employee To Promote or Demote";
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(434, 53);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(116, 23);
            this.btnPromote.TabIndex = 5;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseSelectable = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // dgvPromote
            // 
            this.dgvPromote.AllowUserToAddRows = false;
            this.dgvPromote.AllowUserToDeleteRows = false;
            this.dgvPromote.AllowUserToResizeRows = false;
            this.dgvPromote.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPromote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPromote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPromote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPromote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPromote.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPromote.EnableHeadersVisualStyles = false;
            this.dgvPromote.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPromote.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPromote.Location = new System.Drawing.Point(3, 142);
            this.dgvPromote.Name = "dgvPromote";
            this.dgvPromote.ReadOnly = true;
            this.dgvPromote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromote.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPromote.RowHeadersWidth = 51;
            this.dgvPromote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPromote.RowTemplate.Height = 24;
            this.dgvPromote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromote.Size = new System.Drawing.Size(782, 317);
            this.dgvPromote.TabIndex = 6;
            this.dgvPromote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromote_CellClick);
            // 
            // PromoteEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPromote);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbBoxR);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSetId);
            this.Name = "PromoteEmp";
            this.Size = new System.Drawing.Size(784, 459);
            this.Load += new System.EventHandler(this.PromoteEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSetId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbBoxR;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnPromote;
        private MetroFramework.Controls.MetroGrid dgvPromote;
    }
}
