namespace SatisStokUI
{
    partial class MusteriForm
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
            this.adSoyadText = new System.Windows.Forms.TextBox();
            this.telefonText = new System.Windows.Forms.TextBox();
            this.adresText = new System.Windows.Forms.TextBox();
            this.tipCmb = new System.Windows.Forms.ComboBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMusteri = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlMusteri.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // adSoyadText
            // 
            this.adSoyadText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adSoyadText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adSoyadText.ForeColor = System.Drawing.Color.Black;
            this.adSoyadText.Location = new System.Drawing.Point(172, 20);
            this.adSoyadText.Multiline = true;
            this.adSoyadText.Name = "adSoyadText";
            this.adSoyadText.Size = new System.Drawing.Size(100, 22);
            this.adSoyadText.TabIndex = 0;
            this.adSoyadText.Text = "Adı Soyadı";
            // 
            // telefonText
            // 
            this.telefonText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telefonText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefonText.ForeColor = System.Drawing.Color.Black;
            this.telefonText.Location = new System.Drawing.Point(325, 20);
            this.telefonText.Multiline = true;
            this.telefonText.Name = "telefonText";
            this.telefonText.Size = new System.Drawing.Size(100, 22);
            this.telefonText.TabIndex = 1;
            this.telefonText.Text = "Adres";
            // 
            // adresText
            // 
            this.adresText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adresText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adresText.ForeColor = System.Drawing.Color.Black;
            this.adresText.Location = new System.Drawing.Point(473, 20);
            this.adresText.Multiline = true;
            this.adresText.Name = "adresText";
            this.adresText.Size = new System.Drawing.Size(116, 22);
            this.adresText.TabIndex = 2;
            this.adresText.Text = "Telefon No";
            // 
            // tipCmb
            // 
            this.tipCmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tipCmb.BackColor = System.Drawing.Color.White;
            this.tipCmb.ForeColor = System.Drawing.Color.Black;
            this.tipCmb.FormattingEnabled = true;
            this.tipCmb.Items.AddRange(new object[] {
            "Toptancı",
            "Perakendeci"});
            this.tipCmb.Location = new System.Drawing.Point(640, 20);
            this.tipCmb.Name = "tipCmb";
            this.tipCmb.Size = new System.Drawing.Size(121, 24);
            this.tipCmb.TabIndex = 3;
            this.tipCmb.Text = "Alıcı Tipi";
            // 
            // ekleBtn
            // 
            this.ekleBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ekleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ekleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekleBtn.FlatAppearance.BorderSize = 0;
            this.ekleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleBtn.ForeColor = System.Drawing.Color.White;
            this.ekleBtn.Location = new System.Drawing.Point(172, 65);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(100, 23);
            this.ekleBtn.TabIndex = 4;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.silBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.silBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silBtn.FlatAppearance.BorderSize = 0;
            this.silBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.ForeColor = System.Drawing.Color.White;
            this.silBtn.Location = new System.Drawing.Point(640, 65);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(121, 23);
            this.silBtn.TabIndex = 5;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // listeleBtn
            // 
            this.listeleBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listeleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.listeleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listeleBtn.FlatAppearance.BorderSize = 0;
            this.listeleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeleBtn.ForeColor = System.Drawing.Color.White;
            this.listeleBtn.Location = new System.Drawing.Point(473, 65);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(116, 23);
            this.listeleBtn.TabIndex = 6;
            this.listeleBtn.Text = "LİSTELE";
            this.listeleBtn.UseVisualStyleBackColor = false;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.guncelleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelleBtn.FlatAppearance.BorderSize = 0;
            this.guncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleBtn.ForeColor = System.Drawing.Color.White;
            this.guncelleBtn.Location = new System.Drawing.Point(325, 65);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(100, 23);
            this.guncelleBtn.TabIndex = 7;
            this.guncelleBtn.Text = "GÜNCELLE";
            this.guncelleBtn.UseVisualStyleBackColor = false;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 578);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(794, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kurumsal Yönetim Paneli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "POLZ MOBİLYA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMusteri
            // 
            this.pnlMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.pnlMusteri.Controls.Add(this.guncelleBtn);
            this.pnlMusteri.Controls.Add(this.listeleBtn);
            this.pnlMusteri.Controls.Add(this.adSoyadText);
            this.pnlMusteri.Controls.Add(this.ekleBtn);
            this.pnlMusteri.Controls.Add(this.tipCmb);
            this.pnlMusteri.Controls.Add(this.telefonText);
            this.pnlMusteri.Controls.Add(this.silBtn);
            this.pnlMusteri.Controls.Add(this.adresText);
            this.pnlMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMusteri.Location = new System.Drawing.Point(0, 100);
            this.pnlMusteri.Name = "pnlMusteri";
            this.pnlMusteri.Size = new System.Drawing.Size(881, 109);
            this.pnlMusteri.TabIndex = 11;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(948, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(59, 41);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 578);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 100);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pnlMusteri);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(74, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 787);
            this.panel3.TabIndex = 15;
            // 
            // MusteriForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1007, 864);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlMusteri.ResumeLayout(false);
            this.pnlMusteri.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox adSoyadText;
        private System.Windows.Forms.TextBox telefonText;
        private System.Windows.Forms.TextBox adresText;
        private System.Windows.Forms.ComboBox tipCmb;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMusteri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}