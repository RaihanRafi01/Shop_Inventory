
namespace FinalProject
{
    partial class InsertOrder
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
            this.cmbBoxItem = new MetroFramework.Controls.MetroComboBox();
            this.DateDeadline = new MetroFramework.Controls.MetroDateTime();
            this.btnInsertOrder = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dateOrder = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cmbBoxItem
            // 
            this.cmbBoxItem.FormattingEnabled = true;
            this.cmbBoxItem.ItemHeight = 24;
            this.cmbBoxItem.Items.AddRange(new object[] {
            "Chips",
            "Pepsi",
            "Dew",
            "Coke"});
            this.cmbBoxItem.Location = new System.Drawing.Point(53, 88);
            this.cmbBoxItem.Name = "cmbBoxItem";
            this.cmbBoxItem.Size = new System.Drawing.Size(121, 30);
            this.cmbBoxItem.TabIndex = 0;
            this.cmbBoxItem.UseSelectable = true;
            // 
            // DateDeadline
            // 
            this.DateDeadline.CustomFormat = "yyyy-MM-dd";
            this.DateDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDeadline.Location = new System.Drawing.Point(366, 88);
            this.DateDeadline.MinDate = new System.DateTime(2021, 8, 21, 0, 0, 0, 0);
            this.DateDeadline.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateDeadline.Name = "DateDeadline";
            this.DateDeadline.Size = new System.Drawing.Size(200, 30);
            this.DateDeadline.TabIndex = 3;
            this.DateDeadline.Value = new System.DateTime(2021, 8, 21, 1, 25, 56, 0);
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Location = new System.Drawing.Point(401, 139);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(146, 56);
            this.btnInsertOrder.TabIndex = 4;
            this.btnInsertOrder.Text = "Place Order";
            this.btnInsertOrder.UseSelectable = true;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(425, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Deadline";
            // 
            // txtBoxAmount
            // 
            // 
            // 
            // 
            this.txtBoxAmount.CustomButton.Image = null;
            this.txtBoxAmount.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtBoxAmount.CustomButton.Name = "";
            this.txtBoxAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxAmount.CustomButton.TabIndex = 1;
            this.txtBoxAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxAmount.CustomButton.UseSelectable = true;
            this.txtBoxAmount.CustomButton.Visible = false;
            this.txtBoxAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBoxAmount.Lines = new string[0];
            this.txtBoxAmount.Location = new System.Drawing.Point(193, 88);
            this.txtBoxAmount.MaxLength = 32767;
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.PasswordChar = '\0';
            this.txtBoxAmount.PromptText = "Amount";
            this.txtBoxAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxAmount.SelectedText = "";
            this.txtBoxAmount.SelectionLength = 0;
            this.txtBoxAmount.SelectionStart = 0;
            this.txtBoxAmount.ShortcutsEnabled = true;
            this.txtBoxAmount.Size = new System.Drawing.Size(154, 23);
            this.txtBoxAmount.TabIndex = 1;
            this.txtBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAmount.UseSelectable = true;
            this.txtBoxAmount.WaterMark = "Amount";
            this.txtBoxAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(53, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Select Item";
            // 
            // dateOrder
            // 
            this.dateOrder.AutoSize = true;
            this.dateOrder.Location = new System.Drawing.Point(256, 37);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(74, 20);
            this.dateOrder.TabIndex = 7;
            this.dateOrder.Text = "order date";
            this.dateOrder.Visible = false;
            // 
            // InsertOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnInsertOrder);
            this.Controls.Add(this.DateDeadline);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.cmbBoxItem);
            this.Name = "InsertOrder";
            this.Size = new System.Drawing.Size(618, 249);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbBoxItem;
        private MetroFramework.Controls.MetroDateTime DateDeadline;
        private MetroFramework.Controls.MetroButton btnInsertOrder;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBoxAmount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel dateOrder;
    }
}
