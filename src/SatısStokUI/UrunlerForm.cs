using SatisStokUI.BLL;
using SatisStokUI.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SatisStokUI
{
    public partial class UrunlerForm : Form
    {
        UrunManager um = new UrunManager();
        int secilenId = 0;

        // Tasarım için Panel
        Panel pnlContainer;

        public UrunlerForm()
        {
            InitializeComponent();

            // --- TASARIM AYARLARI ---
            TasarimiGuncelle();

            // Verileri Yükle
            Listele();

            // Placeholder Ayarları
            PlaceholderAyarla(adTextBox, "Ürün Adı");
            PlaceholderAyarla(fiyatTextBox, "Fiyat");
            PlaceholderAyarla(stokTextBox, "Stok Adedi");
            PlaceholderAyarla(minStokTextBox, "Min. Stok");
            PlaceholderAyarla(kategoriTextBox, "Kategori ID");

            // Açılışta odağı kaldır
            this.Shown += (s, e) => { this.ActiveControl = null; };
            // Ekran boyutu değişirse ortala
            this.Resize += (s, e) => { OrtalaContainer(); };
        }

        // ✅ Parent'tan söküp panele taşıyan güvenli taşıma
        private void MoveToContainer(Control c)
        {
            if (c == null || pnlContainer == null) return;
            c.Parent?.Controls.Remove(c);
            pnlContainer.Controls.Add(c);
        }

        private void TasarimiGuncelle()
        {
            // 1. Ana Form Rengi (Dashboard ile Aynı Gunmetal)
            this.BackColor = Color.FromArgb(50, 55, 65);
            this.FormBorderStyle = FormBorderStyle.None;

            // 2. Ortadaki Kapsayıcı Panel (ÖNCE OLUŞTUR)
            pnlContainer = new Panel();
            pnlContainer.Size = new Size(800, 600);
            pnlContainer.BackColor = Color.FromArgb(70, 75, 85); // Kart Rengi
            pnlContainer.Name = "pnlContainer";
            this.Controls.Add(pnlContainer);

            // 3. ESKİ GROUPBOX'LARI GİZLE (O Çerçeveyi Yok Et)
            foreach (Control c in this.Controls)
            {
                if (c is GroupBox) c.Visible = false;
            }

            // 4. Kapatma Butonu (Sağ Üst)
            Button btnCikis = new Button();
            btnCikis.Text = "X";
            btnCikis.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnCikis.ForeColor = Color.White;
            btnCikis.BackColor = Color.Transparent;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.Size = new Size(40, 30);
            btnCikis.Location = new Point(this.ClientSize.Width - 40, 0);
            btnCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.Click += (s, e) => { this.Close(); };
            this.Controls.Add(btnCikis);
            btnCikis.BringToFront();

            // 5. Başlık
            Label lblBaslik = new Label();
            lblBaslik.Text = "ÜRÜN YÖNETİM PANELİ";
            lblBaslik.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(30, 20);
            pnlContainer.Controls.Add(lblBaslik);

            // 6. Kontrolleri Düzenle
            // TextBox'lar
            TextBoxSusle(adTextBox, 30, 80);
            TextBoxSusle(fiyatTextBox, 250, 80);
            TextBoxSusle(stokTextBox, 470, 80);
            TextBoxSusle(minStokTextBox, 30, 140);
            TextBoxSusle(kategoriTextBox, 250, 140);

            // Butonlar
            ButtonSusle(ekleButton, "EKLE", Color.FromArgb(46, 204, 113), 30, 200);     // Yeşil
            ButtonSusle(silButton, "SİL", Color.FromArgb(231, 76, 60), 160, 200);      // Kırmızı
            ButtonSusle(guncelleButton, "GÜNCELLE", Color.FromArgb(52, 152, 219), 290, 200); // Mavi
            ButtonSusle(listeleButton, "LİSTELE", Color.FromArgb(155, 89, 182), 420, 200); // Mor

            // "Müşteriler" butonu (varsa)
            if (musterilerButton != null)
            {
                ButtonSusle(musterilerButton, "MÜŞTERİLER >", Color.Gray, 600, 200);
            }

            // 7. DataGridView Tasarımı + taşı
            TabloyuSusle(dataGridView1);
            MoveToContainer(dataGridView1);

            dataGridView1.Location = new Point(30, 270);
            dataGridView1.Size = new Size(740, 300);

            // Ek modern ayarlar
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // 8. Her Şeyi Hizala
            OrtalaContainer();
            pnlContainer.BringToFront();
        }

        private void OrtalaContainer()
        {
            if (pnlContainer != null)
            {
                pnlContainer.Left = (this.ClientSize.Width - pnlContainer.Width) / 2;
                pnlContainer.Top = (this.ClientSize.Height - pnlContainer.Height) / 2;
            }
        }

        private void TextBoxSusle(TextBox tb, int x, int y)
        {
            if (tb == null) return;

            MoveToContainer(tb);

            tb.Location = new Point(x, y);
            tb.Size = new Size(200, 30);
            tb.Font = new Font("Segoe UI", 11);
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.BackColor = Color.White;
        }

        private void ButtonSusle(Button btn, string text, Color renk, int x, int y)
        {
            if (btn == null) return;

            MoveToContainer(btn);

            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Size = new Size(120, 40);
            btn.BackColor = renk;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        private void TabloyuSusle(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.FromArgb(60, 65, 75);

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 40);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
        }

        private void PlaceholderAyarla(TextBox kutu, string metin)
        {
            if (kutu == null) return;

            kutu.Text = metin;
            kutu.ForeColor = Color.Gray;

            kutu.Enter += (sender, e) =>
            {
                if (kutu.Text == metin)
                {
                    kutu.Text = "";
                    kutu.ForeColor = Color.Black;
                }
            };

            kutu.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(kutu.Text))
                {
                    kutu.Text = metin;
                    kutu.ForeColor = Color.Gray;
                }
            };
        }

        // --- CRUD İŞLEMLERİ ---
        void Listele()
        {
            dataGridView1.DataSource = um.TumunuListele();
            if (dataGridView1.Columns["Id"] != null) dataGridView1.Columns["Id"].Visible = false;
        }

        private void listeleButton_Click(object sender, EventArgs e) => Listele();

        private void ekleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (adTextBox.Text == "Ürün Adı" || fiyatTextBox.Text == "Fiyat")
                {
                    MessageBox.Show("Lütfen bilgileri giriniz.");
                    return;
                }

                Urun u = new Urun();
                u.UrunAd = adTextBox.Text;
                u.Fiyat = decimal.Parse(fiyatTextBox.Text);
                u.Stok = int.Parse(stokTextBox.Text == "Stok Adedi" ? "0" : stokTextBox.Text);
                u.MinStok = int.Parse(minStokTextBox.Text == "Min. Stok" ? "0" : minStokTextBox.Text);
                u.KategoriId = int.Parse(kategoriTextBox.Text == "Kategori ID" ? "0" : kategoriTextBox.Text);

                um.UrunEkle(u);
                MessageBox.Show("Ürün Eklendi!");
                Listele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (secilenId != 0)
            {
                um.UrunSil(secilenId);
                MessageBox.Show("Ürün Silindi.");
                Listele();
                Temizle();
            }
            else { MessageBox.Show("Lütfen silinecek ürüne tıklayın."); }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenId != 0)
                {
                    Urun u = new Urun();
                    u.Id = secilenId;
                    u.UrunAd = adTextBox.Text;
                    u.Fiyat = decimal.Parse(fiyatTextBox.Text);
                    u.Stok = int.Parse(stokTextBox.Text);
                    u.MinStok = int.Parse(minStokTextBox.Text);
                    u.KategoriId = int.Parse(kategoriTextBox.Text);

                    um.UrunGuncelle(u);
                    MessageBox.Show("Güncellendi.");
                    Listele();
                    Temizle();
                }
                else { MessageBox.Show("Lütfen güncellenecek ürüne tıklayın."); }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["Id"].Value != null)
                    secilenId = int.Parse(row.Cells["Id"].Value.ToString());
                else
                    secilenId = int.Parse(row.Cells[0].Value.ToString());

                adTextBox.ForeColor = Color.Black;
                fiyatTextBox.ForeColor = Color.Black;
                stokTextBox.ForeColor = Color.Black;
                minStokTextBox.ForeColor = Color.Black;
                kategoriTextBox.ForeColor = Color.Black;

                try
                {
                    // senin kolona göre UrunAdi / UrunAd olabilir
                    if (row.Cells["UrunAdi"] != null && row.Cells["UrunAdi"].Value != null)
                        adTextBox.Text = row.Cells["UrunAdi"].Value.ToString();
                    else if (row.Cells["UrunAd"] != null && row.Cells["UrunAd"].Value != null)
                        adTextBox.Text = row.Cells["UrunAd"].Value.ToString();

                    fiyatTextBox.Text = row.Cells["Fiyat"].Value?.ToString();
                    stokTextBox.Text = row.Cells["Stok"].Value?.ToString();
                    minStokTextBox.Text = row.Cells["MinStok"].Value?.ToString();
                    kategoriTextBox.Text = row.Cells["KategoriId"].Value?.ToString();
                }
                catch { }
            }
        }

        void Temizle()
        {
            secilenId = 0;
            adTextBox.Text = ""; PlaceholderAyarla(adTextBox, "Ürün Adı");
            fiyatTextBox.Text = ""; PlaceholderAyarla(fiyatTextBox, "Fiyat");
            stokTextBox.Text = ""; PlaceholderAyarla(stokTextBox, "Stok Adedi");
            minStokTextBox.Text = ""; PlaceholderAyarla(minStokTextBox, "Min. Stok");
            kategoriTextBox.Text = ""; PlaceholderAyarla(kategoriTextBox, "Kategori ID");
            this.ActiveControl = null;
        }

        private void UrunlerForm_Load(object sender, EventArgs e) { }

        private void musterilerButton_Click(object sender, EventArgs e)
        {
            MusteriForm frm = new MusteriForm();
            frm.ShowDialog();
        }
    }
}
