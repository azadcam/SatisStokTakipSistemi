namespace SatisStokUI
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.kullaniciTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlİsim = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin.SuspendLayout();
            this.pnlİsim.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullaniciTextBox
            // 
            this.kullaniciTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTextBox.Location = new System.Drawing.Point(154, 29);
            this.kullaniciTextBox.Multiline = true;
            this.kullaniciTextBox.Name = "kullaniciTextBox";
            this.kullaniciTextBox.Size = new System.Drawing.Size(178, 37);
            this.kullaniciTextBox.TabIndex = 0;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextBox.Location = new System.Drawing.Point(154, 87);
            this.sifreTextBox.Multiline = true;
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(178, 36);
            this.sifreTextBox.TabIndex = 1;
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.girisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisButton.FlatAppearance.BorderSize = 0;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.ForeColor = System.Drawing.Color.White;
            this.girisButton.Location = new System.Drawing.Point(154, 163);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(178, 50);
            this.girisButton.TabIndex = 2;
            this.girisButton.Text = "GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(266, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kurumsal Yönetim Paneli";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(78, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 106);
            this.label2.TabIndex = 4;
            this.label2.Text = "POLZ MOBİLYA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.sifreTextBox);
            this.pnlLogin.Controls.Add(this.kullaniciTextBox);
            this.pnlLogin.Controls.Add(this.girisButton);
            this.pnlLogin.Location = new System.Drawing.Point(163, 220);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(483, 245);
            this.pnlLogin.TabIndex = 5;
            // 
            // pnlİsim
            // 
            this.pnlİsim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlİsim.BackColor = System.Drawing.Color.Transparent;
            this.pnlİsim.Controls.Add(this.label1);
            this.pnlİsim.Controls.Add(this.label2);
            this.pnlİsim.Location = new System.Drawing.Point(59, 12);
            this.pnlİsim.Name = "pnlİsim";
            this.pnlİsim.Size = new System.Drawing.Size(698, 170);
            this.pnlİsim.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(769, 514);
            this.Controls.Add(this.pnlİsim);
            this.Controls.Add(this.pnlLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POLZ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlİsim.ResumeLayout(false);
            this.pnlİsim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlİsim;
        private System.Windows.Forms.Timer timer1;
    }
}