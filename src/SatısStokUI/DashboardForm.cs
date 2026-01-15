using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SatisStokUI
{
    public partial class DashboardForm : Form
    {
        public string Rol { get; set; }
        Panel kartUrun, kartMusteri, kartSatis, kartRapor;

        public DashboardForm(string gelenRol = "Yönetici") // Varsayılan olarak Yönetici
        {
            InitializeComponent();
            Rol = gelenRol;
            AyarlariYukle();
        }

        private void AyarlariYukle()
        {
            this.Load += DashboardForm_Load;
            this.Resize += DashboardForm_Resize;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized; // Tam ekran açılması için
            this.BackColor = Color.FromArgb(50, 55, 65); // Gunmetal Gri
            this.DoubleBuffered = true;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Panelleri şeffaflaştır
            if (pnlDash != null) pnlDash.BackColor = Color.Transparent;
            if (pnlMenu != null) pnlMenu.BackColor = Color.Transparent;

            // Başlık yazı rengini düzelt
            foreach (Control item in pnlDash?.Controls)
                if (item is Label) item.ForeColor = Color.FromArgb(240, 240, 235);

            MenuKartlariniOlustur();
            CikisButonuEkle();
            OrtalaHerSeyi();
        }

        private void MenuKartlariniOlustur()
        {
            if (pnlMenu == null) return;
            pnlMenu.Controls.Clear();

            string ikonPath = Path.Combine(Application.StartupPath, "Gorseller", "ikonlar");

            // Kartları oluştur
            kartUrun = Kart("ÜRÜN YÖNETİMİ", DosyadanResimYukle(Path.Combine(ikonPath, "urun.png")), (s, e) => new UrunlerForm().ShowDialog());
            kartMusteri = Kart("MÜŞTERİLER", DosyadanResimYukle(Path.Combine(ikonPath, "musteri.png")), (s, e) => new MusteriForm().ShowDialog());
            kartSatis = Kart("SATIŞLAR", DosyadanResimYukle(Path.Combine(ikonPath, "satis.png")), (s, e) => new SatisForm().ShowDialog());
            kartRapor = Kart("RAPORLAR", DosyadanResimYukle(Path.Combine(ikonPath, "rapor.png")), (s, e) => new RaporlarForm().ShowDialog());

            // --- YETKİ KONTROLÜ (İSTEDİĞİN MANTIK) ---
            if (Rol == "Depo Görevlisi")
            {
                // Sadece Ürün Yönetimi
                kartMusteri.Visible = kartSatis.Visible = kartRapor.Visible = false;
            }
            else if (Rol == "Satış Elemanı")
            {
                // Sadece Müşteriler ve Satışlar
                kartUrun.Visible = kartRapor.Visible = false;
            }
            // Yönetici ise hepsi zaten true (varsayılan)

            // Görünür olanları panele ekle
            pnlMenu.Controls.Add(kartUrun);
            pnlMenu.Controls.Add(kartMusteri);
            pnlMenu.Controls.Add(kartSatis);
            pnlMenu.Controls.Add(kartRapor);

            PozisyonlariAyarla();
        }

        private void PozisyonlariAyarla()
        {
            int w = 240, h = 180, bosluk = 120;

            // Kartların konumlarını 2x2 düzende ayarla
            kartUrun.Location = new Point(0, 0);
            kartMusteri.Location = new Point(w + bosluk, 0);
            kartSatis.Location = new Point(0, h + bosluk);
            kartRapor.Location = new Point(w + bosluk, h + bosluk);

            pnlMenu.Size = new Size((w * 2) + bosluk, (h * 2) + bosluk);
            OrtalaHerSeyi();
        }

        private Panel Kart(string yazi, Image ikon, EventHandler clickEvent)
        {
            Panel p = new Panel { Size = new Size(240, 180), BackColor = Color.FromArgb(30, 30, 35), Cursor = Cursors.Hand };
            PictureBox pb = new PictureBox { Size = new Size(80, 80), SizeMode = PictureBoxSizeMode.Zoom, Image = ikon, Enabled = false, Location = new Point(80, 30) };
            Label lbl = new Label { Text = yazi, Size = new Size(240, 40), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.White, Location = new Point(0, 120), Enabled = false };

            p.Controls.Add(pb);
            p.Controls.Add(lbl);
            p.Click += clickEvent;

            // Hover Efektleri
            p.MouseEnter += (s, e) => p.BackColor = Color.FromArgb(60, 60, 70);
            p.MouseLeave += (s, e) => p.BackColor = Color.FromArgb(30, 30, 35);

            return p;
        }

        private void OrtalaHerSeyi()
        {
            if (pnlDash != null)
            {
                pnlDash.Left = (this.ClientSize.Width - pnlDash.Width) / 2;
                pnlDash.Top = 60;
            }
            if (pnlMenu != null)
            {
                pnlMenu.Left = (this.ClientSize.Width - pnlMenu.Width) / 2;
                pnlMenu.Top = (this.ClientSize.Height - pnlMenu.Height) / 2 + 60;
            }
        }

        private void DashboardForm_Resize(object sender, EventArgs e) => OrtalaHerSeyi();

        private void CikisButonuEkle()
        {
            Button btnCikis = new Button { Text = "X", Size = new Size(40, 30), FlatStyle = FlatStyle.Flat, ForeColor = Color.White, Cursor = Cursors.Hand };
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCikis.Location = new Point(this.ClientSize.Width - 40, 0);
            btnCikis.Click += (s, e) => Application.Exit();
            this.Controls.Add(btnCikis);
            btnCikis.BringToFront();
        }

        private Image DosyadanResimYukle(string yol) => File.Exists(yol) ? Image.FromFile(yol) : null;
    }
}