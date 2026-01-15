using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System.Configuration;

using SatisStokUI.BLL;
using SatisStokUI.Domain;

namespace SatisStokUI
{
    public partial class SatisForm : Form
    {
        private readonly SatisManager sm = new SatisManager();
        private readonly UrunManager um = new UrunManager();
        private readonly MusteriManager mm = new MusteriManager();

        private Panel pnlContainer;

        // ✅ DB bağlantısı (App.config -> MyDb)
        private string ConnStr
        {
            get
            {
                string cs = null;
                try { cs = ConfigurationManager.ConnectionStrings["MyDb"]?.ConnectionString; } catch { }

                if (!string.IsNullOrWhiteSpace(cs)) return cs;

                // fallback (istersen sil)
                return "Server=172.21.54.253;Port=3306;Database=26_132430016;Uid=26_132430016;Pwd=İnif123.;Charset=utf8mb4;";
            }
        }

        public SatisForm()
        {
            InitializeComponent();
            TasarimiGuncelle();

            // Eventleri garanti bağla
            if (satisYapBtn != null) satisYapBtn.Click += btnSatisYap_Click;
            if (urunCmb != null) urunCmb.SelectedIndexChanged += urunCmb_SelectedIndexChanged;

            // ✅ combolar
            KutulariDoldur();
            SubeComboDoldur();   // 🔥 yeni
            Listele();

            // Ekran boyutu değiştikçe
            this.Resize += (s, e) =>
            {
                OrtalaContainer();
                CikisButonunuKonumlandir();
            };

            this.Shown += (s, e) => this.ActiveControl = null;
        }

        // ✅ Ürün seçince fiyat otomatik
        private void urunCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (urunCmb?.SelectedItem is Urun u)
                {
                    // fiyatı otomatik yaz
                    fiyatText.Text = u.Fiyat.ToString("0.##", CultureInfo.InvariantCulture);
                }
            }
            catch { }
        }

        // =========================
        // ✅ ŞUBE COMBO DOLDUR (DB’den)
        // =========================
        private void SubeComboDoldur()
        {
            // Designer’da subeCmb yoksa patlamasın
            if (subeCmb == null) return;

            try
            {
                var dt = new DataTable();
                using (var conn = new MySqlConnection(ConnStr))
                using (var cmd = new MySqlCommand("SELECT id, sube_adi FROM Subeler ORDER BY sube_adi", conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    conn.Open();
                    da.Fill(dt);
                }

                subeCmb.DataSource = null;
                subeCmb.DisplayMember = "sube_adi";
                subeCmb.ValueMember = "id";
                subeCmb.DataSource = dt;
                subeCmb.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şube Combo doldurma hatası:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // ✅ SATIŞ KAYDET (SubeId ile) - Direkt DB Insert
        // =========================
        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (subeCmb == null || subeCmb.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen şube seç.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (urunCmb.SelectedValue == null || musteriCmb.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen müşteri ve ürün seç.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Adet parse (senin “adet hatalı” uyarısının ana sebebi boşluk/format)
                var adetRaw = (adetText.Text ?? "").Trim();
                if (!int.TryParse(adetRaw, NumberStyles.Integer, CultureInfo.InvariantCulture, out int adet) || adet <= 0)
                {
                    MessageBox.Show("Adet sayısı hatalı. (1,2,3... gibi sadece sayı gir)", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    adetText.Focus();
                    return;
                }

                // ✅ Fiyat parse: hem 12,5 hem 12.5 kabul et
                var fiyatRaw = (fiyatText.Text ?? "").Trim().Replace(",", ".");
                if (!decimal.TryParse(fiyatRaw, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal fiyat) || fiyat <= 0)
                {
                    // fiyat boşsa üründen çek
                    if (urunCmb.SelectedItem is Urun u2) fiyat = u2.Fiyat;
                    else
                    {
                        MessageBox.Show("Fiyat hatalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int urunId = Convert.ToInt32(urunCmb.SelectedValue);
                int musteriId = Convert.ToInt32(musteriCmb.SelectedValue);
                int subeId = Convert.ToInt32(subeCmb.SelectedValue);

                // ✅ DB’ye direkt ekle (başka dosyaya dokunmadan sube_id’yi garanti kaydederiz)
                using (var conn = new MySqlConnection(ConnStr))
                using (var cmd = new MySqlCommand(@"
INSERT INTO Satislar (urun_id, musteri_id, sube_id, adet, fiyat, tarih)
VALUES (@urun, @mus, @sube, @adet, @fiyat, @tarih);", conn))
                {
                    cmd.Parameters.AddWithValue("@urun", urunId);
                    cmd.Parameters.AddWithValue("@mus", musteriId);
                    cmd.Parameters.AddWithValue("@sube", subeId);
                    cmd.Parameters.AddWithValue("@adet", adet);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Liste yenile
                Listele();

                // input reset
                adetText.Text = "";
                // fiyat otomatik dolduğu için silmiyorum (istersen sileriz)
                this.ActiveControl = null;

                MessageBox.Show("Satış kaydedildi ✅", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış ekleme hatası:\n" + ex.ToString(), "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TasarimiGuncelle()
        {
            this.BackColor = Color.FromArgb(50, 55, 65);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            foreach (Control c in this.Controls)
                if (c is GroupBox) c.Visible = false;

            pnlContainer = new Panel();
            pnlContainer.Size = new Size(850, 650);
            pnlContainer.BackColor = Color.FromArgb(60, 65, 75);
            this.Controls.Add(pnlContainer);

            Label lblAnaBaslik = new Label
            {
                Text = "POLZ MOBİLYA",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true
            };
            lblAnaBaslik.Location = new Point((pnlContainer.Width - 220) / 2, 20);
            pnlContainer.Controls.Add(lblAnaBaslik);

            // ✅ ŞUBE (yeni)
            LabelEkle("Şube Seçimi:", 50, 120);
            ComboBoxSusle(subeCmb, 50, 145, 360);

            // Müşteri / Ürün
            LabelEkle("Müşteri Seçimi:", 440, 120);
            ComboBoxSusle(musteriCmb, 440, 145, 360);

            LabelEkle("Ürün Seçimi:", 50, 195);
            ComboBoxSusle(urunCmb, 50, 220, 360);

            LabelEkle("Adet:", 440, 195);
            TextBoxSusle(adetText, 440, 220, 120);

            LabelEkle("Fiyat:", 580, 195);
            TextBoxSusle(fiyatText, 580, 220, 220);

            ButtonSusle(satisYapBtn, "SATIŞI TAMAMLA ✅", Color.FromArgb(46, 204, 113), 50, 270);
            satisYapBtn.Size = new Size(750, 40);

            TabloyuSusle(dataGridView1);
            if (dataGridView1.Parent != null) dataGridView1.Parent.Controls.Remove(dataGridView1);
            pnlContainer.Controls.Add(dataGridView1);
            dataGridView1.Location = new Point(50, 330);
            dataGridView1.Size = new Size(750, 290);

            CikisButonuOlustur();
            OrtalaContainer();
        }

        private void Listele()
        {
            // sm.Listele() mevcut yapını bozmadan ekrana basar
            dataGridView1.DataSource = sm.Listele();

            string[] gizlenecekler = { "Id", "UrunId", "MusteriId", "SubeId" };
            foreach (string s in gizlenecekler)
                if (dataGridView1.Columns[s] != null) dataGridView1.Columns[s].Visible = false;
        }

        private void KutulariDoldur()
        {
            urunCmb.DataSource = um.TumunuListele();
            urunCmb.DisplayMember = "UrunAd";
            urunCmb.ValueMember = "Id";

            musteriCmb.DataSource = mm.Listele();
            musteriCmb.DisplayMember = "AdSoyad";
            musteriCmb.ValueMember = "Id";

            urunCmb.SelectedIndex = -1;
            musteriCmb.SelectedIndex = -1;

            // ürün seçilince fiyat otomatik
            if (urunCmb != null) urunCmb.SelectedIndexChanged += urunCmb_SelectedIndexChanged;
        }

        // --- ÇIKIŞ BUTONU ---
        private void CikisButonuOlustur()
        {
            Button btnX = new Button();
            btnX.Name = "btnKapat";
            btnX.Text = "X";
            btnX.Size = new Size(45, 35);
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.ForeColor = Color.White;
            btnX.BackColor = Color.Transparent;
            btnX.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnX.Cursor = Cursors.Hand;

            btnX.MouseEnter += (s, e) => btnX.BackColor = Color.Red;
            btnX.MouseLeave += (s, e) => btnX.BackColor = Color.Transparent;
            btnX.Click += (s, e) => this.Close();

            this.Controls.Add(btnX);
            btnX.BringToFront();
            CikisButonunuKonumlandir();
        }

        private void CikisButonunuKonumlandir()
        {
            Control btn = this.Controls["btnKapat"];
            if (btn != null)
                btn.Location = new Point(this.ClientSize.Width - btn.Width, 0);
        }

        private void OrtalaContainer()
        {
            if (pnlContainer != null)
            {
                pnlContainer.Left = (this.ClientSize.Width - pnlContainer.Width) / 2;
                pnlContainer.Top = (this.ClientSize.Height - pnlContainer.Height) / 2;
            }
        }

        private void LabelEkle(string text, int x, int y)
        {
            Label lbl = new Label
            {
                Text = text,
                ForeColor = Color.LightGray,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(x, y)
            };
            pnlContainer.Controls.Add(lbl);
        }

        private void ComboBoxSusle(ComboBox cmb, int x, int y, int width)
        {
            if (cmb == null) return;
            if (cmb.Parent != null) cmb.Parent.Controls.Remove(cmb);
            pnlContainer.Controls.Add(cmb);
            cmb.Location = new Point(x, y);
            cmb.Width = width;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.FlatStyle = FlatStyle.Flat;
        }

        private void TextBoxSusle(TextBox tb, int x, int y, int width)
        {
            if (tb == null) return;
            if (tb.Parent != null) tb.Parent.Controls.Remove(tb);
            pnlContainer.Controls.Add(tb);
            tb.Location = new Point(x, y);
            tb.Width = width;
            tb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ButtonSusle(Button btn, string text, Color renk, int x, int y)
        {
            if (btn == null) return;
            if (btn.Parent != null) btn.Parent.Controls.Remove(btn);
            pnlContainer.Controls.Add(btn);
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.BackColor = renk;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void TabloyuSusle(DataGridView dgv)
        {
            if (dgv == null) return;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(45, 50, 60);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 35);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(60, 65, 75);
            dgv.DefaultCellStyle.ForeColor = Color.White;
        }
    }
}
