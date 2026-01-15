namespace SatisStokUI
{
    partial class SatisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.musteriCmb = new System.Windows.Forms.ComboBox();
            this.urunCmb = new System.Windows.Forms.ComboBox();
            this.adetText = new System.Windows.Forms.TextBox();
            this.fiyatText = new System.Windows.Forms.TextBox();
            this.satisYapBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subeCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriCmb
            // 
            this.musteriCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musteriCmb.FormattingEnabled = true;
            this.musteriCmb.Location = new System.Drawing.Point(24, 88);
            this.musteriCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.musteriCmb.Name = "musteriCmb";
            this.musteriCmb.Size = new System.Drawing.Size(137, 31);
            this.musteriCmb.TabIndex = 1;
            // 
            // urunCmb
            // 
            this.urunCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunCmb.FormattingEnabled = true;
            this.urunCmb.Location = new System.Drawing.Point(185, 88);
            this.urunCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urunCmb.Name = "urunCmb";
            this.urunCmb.Size = new System.Drawing.Size(132, 31);
            this.urunCmb.TabIndex = 2;
            // 
            // adetText
            // 
            this.adetText.Location = new System.Drawing.Point(348, 87);
            this.adetText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adetText.Name = "adetText";
            this.adetText.Size = new System.Drawing.Size(112, 30);
            this.adetText.TabIndex = 3;
            // 
            // fiyatText
            // 
            this.fiyatText.Location = new System.Drawing.Point(502, 89);
            this.fiyatText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fiyatText.Name = "fiyatText";
            this.fiyatText.Size = new System.Drawing.Size(112, 30);
            this.fiyatText.TabIndex = 4;
            // 
            // satisYapBtn
            // 
            this.satisYapBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.satisYapBtn.FlatAppearance.BorderSize = 0;
            this.satisYapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisYapBtn.Location = new System.Drawing.Point(874, 58);
            this.satisYapBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satisYapBtn.Name = "satisYapBtn";
            this.satisYapBtn.Size = new System.Drawing.Size(143, 61);
            this.satisYapBtn.TabIndex = 5;
            this.satisYapBtn.Text = "Satışı Tamamla";
            this.satisYapBtn.UseVisualStyleBackColor = false;
            this.satisYapBtn.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(45, 248);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 232);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.subeCmb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adetText);
            this.groupBox1.Controls.Add(this.fiyatText);
            this.groupBox1.Controls.Add(this.urunCmb);
            this.groupBox1.Controls.Add(this.satisYapBtn);
            this.groupBox1.Controls.Add(this.musteriCmb);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(45, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞ İŞLEMLERİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(192, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Seçimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Seçimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şube Seçimi";
            // 
            // subeCmb
            // 
            this.subeCmb.FormattingEnabled = true;
            this.subeCmb.Location = new System.Drawing.Point(687, 89);
            this.subeCmb.Name = "subeCmb";
            this.subeCmb.Size = new System.Drawing.Size(121, 31);
            this.subeCmb.TabIndex = 11;
            // 
            // SatisForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1140, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SatisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox musteriCmb;
        private System.Windows.Forms.ComboBox urunCmb;
        private System.Windows.Forms.TextBox adetText;
        private System.Windows.Forms.TextBox fiyatText;
        private System.Windows.Forms.Button satisYapBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subeCmb;
        private System.Windows.Forms.Label label5;
    }
}