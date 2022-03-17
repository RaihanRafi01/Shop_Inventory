
namespace FinalProject
{
    partial class Seller
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnX = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOrder = new MetroFramework.Controls.MetroGrid();
            this.lvlShowing = new MetroFramework.Controls.MetroLabel();
            this.btnAddItem = new MetroFramework.Controls.MetroButton();
            this.lblSetName = new MetroFramework.Controls.MetroLabel();
            this.lblQuantity = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.txtWholeSell = new MetroFramework.Controls.MetroTextBox();
            this.lblMonth = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(745, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(43, 38);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseSelectable = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrder.Location = new System.Drawing.Point(-12, 243);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(711, 325);
            this.dgvOrder.TabIndex = 2;
            this.dgvOrder.Visible = false;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // lvlShowing
            // 
            this.lvlShowing.AutoSize = true;
            this.lvlShowing.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lvlShowing.Location = new System.Drawing.Point(94, 201);
            this.lvlShowing.Name = "lvlShowing";
            this.lvlShowing.Size = new System.Drawing.Size(347, 25);
            this.lvlShowing.TabIndex = 7;
            this.lvlShowing.Text = "Showing Order List Select item for dropoff";
            this.lvlShowing.Visible = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(705, 243);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(93, 110);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseSelectable = true;
            this.btnAddItem.Visible = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblSetName
            // 
            this.lblSetName.AutoSize = true;
            this.lblSetName.Location = new System.Drawing.Point(227, 128);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(66, 20);
            this.lblSetName.TabIndex = 11;
            this.lblSetName.Text = "set name";
            this.lblSetName.Visible = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(227, 153);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 20);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "set Quantity";
            this.lblQuantity.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(225, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(84, 20);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "today\'s Date";
            this.lblDate.Visible = false;
            // 
            // txtWholeSell
            // 
            // 
            // 
            // 
            this.txtWholeSell.CustomButton.Image = null;
            this.txtWholeSell.CustomButton.Location = new System.Drawing.Point(139, 2);
            this.txtWholeSell.CustomButton.Name = "";
            this.txtWholeSell.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtWholeSell.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWholeSell.CustomButton.TabIndex = 1;
            this.txtWholeSell.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWholeSell.CustomButton.UseSelectable = true;
            this.txtWholeSell.CustomButton.Visible = false;
            this.txtWholeSell.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWholeSell.Lines = new string[0];
            this.txtWholeSell.Location = new System.Drawing.Point(621, 196);
            this.txtWholeSell.MaxLength = 32767;
            this.txtWholeSell.Name = "txtWholeSell";
            this.txtWholeSell.PasswordChar = '\0';
            this.txtWholeSell.PromptText = "Enter WholeSell Price";
            this.txtWholeSell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWholeSell.SelectedText = "";
            this.txtWholeSell.SelectionLength = 0;
            this.txtWholeSell.SelectionStart = 0;
            this.txtWholeSell.ShortcutsEnabled = true;
            this.txtWholeSell.Size = new System.Drawing.Size(167, 30);
            this.txtWholeSell.TabIndex = 15;
            this.txtWholeSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWholeSell.UseSelectable = true;
            this.txtWholeSell.Visible = false;
            this.txtWholeSell.WaterMark = "Enter WholeSell Price";
            this.txtWholeSell.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWholeSell.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(227, 81);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(71, 20);
            this.lblMonth.TabIndex = 16;
            this.lblMonth.Text = "set Month";
            this.lblMonth.Visible = false;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtWholeSell);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSetName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lvlShowing);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Seller";
            this.Text = "Seller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnX;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid dgvOrder;
        private MetroFramework.Controls.MetroLabel lvlShowing;
        private MetroFramework.Controls.MetroButton btnAddItem;
        private MetroFramework.Controls.MetroLabel lblSetName;
        private MetroFramework.Controls.MetroLabel lblQuantity;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroTextBox txtWholeSell;
        private MetroFramework.Controls.MetroLabel lblMonth;
    }
}