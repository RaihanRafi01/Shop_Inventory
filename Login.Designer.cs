
namespace FinalProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.createacc = new System.Windows.Forms.Label();
            this.lvlSingup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtID.Location = new System.Drawing.Point(43, 517);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(600, 61);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "E-Mail or ID";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // txtPASS
            // 
            this.txtPASS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPASS.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASS.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPASS.Location = new System.Drawing.Point(43, 603);
            this.txtPASS.Margin = new System.Windows.Forms.Padding(4);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(600, 61);
            this.txtPASS.TabIndex = 2;
            this.txtPASS.Text = "Password";
            this.txtPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPASS.Enter += new System.EventHandler(this.txtPASS_Enter);
            this.txtPASS.Leave += new System.EventHandler(this.txtPASS_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(619, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 39);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(212, 689);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(253, 60);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // createacc
            // 
            this.createacc.AutoSize = true;
            this.createacc.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createacc.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createacc.Location = new System.Drawing.Point(171, 774);
            this.createacc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createacc.Name = "createacc";
            this.createacc.Size = new System.Drawing.Size(189, 31);
            this.createacc.TabIndex = 10;
            this.createacc.Text = "Not a Member ? ";
            // 
            // lvlSingup
            // 
            this.lvlSingup.AutoSize = true;
            this.lvlSingup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvlSingup.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.lvlSingup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lvlSingup.Location = new System.Drawing.Point(364, 774);
            this.lvlSingup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlSingup.Name = "lvlSingup";
            this.lvlSingup.Size = new System.Drawing.Size(147, 31);
            this.lvlSingup.TabIndex = 11;
            this.lvlSingup.Text = "Sing Up here";
            this.lvlSingup.Click += new System.EventHandler(this.lvlSingup_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(684, 820);
            this.Controls.Add(this.lvlSingup);
            this.Controls.Add(this.createacc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPASS);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label createacc;
        private System.Windows.Forms.Label lvlSingup;
    }
}