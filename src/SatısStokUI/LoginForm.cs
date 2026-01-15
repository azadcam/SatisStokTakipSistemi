using SatisStokUI.BLL;
using SatisStokUI.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace SatisStokUI
{
    public partial class LoginForm : Form
    {
        AdminManager am = new AdminManager();
        string[] resimYollari;
        int resimSayaci = 0;
        Image[] images;
        Image[] scaledImages;
        PictureBox pbArkaPlan;
        Timer slaytTimer;

        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.Load += LoginForm_Load;
            this.Resize += LoginForm_Resize;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Fotolar Hazırlık
            ArkaPlanPictureBoxHazirla();
            OverlayKontrolleriPictureBoxaBagla();

            try
            {
                string gorselKlasoru = Path.Combine(Application.StartupPath, "Gorseller");
                if (!Directory.Exists(gorselKlasoru)) Directory.CreateDirectory(gorselKlasoru);

                resimYollari = new string[] {
                    Path.Combine(gorselKlasoru, "resim1.jpg"),
                    Path.Combine(gorselKlasoru, "resim2.jpg"),
                    Path.Combine(gorselKlasoru, "resim3.jpg")
                };

                images = new Image[resimYollari.Length];
                for (int i = 0; i < resimYollari.Length; i++)
                {
                    if (File.Exists(resimYollari[i]))
                    {
                        using (var tmp = Image.FromFile(resimYollari[i]))
                            images[i] = new Bitmap(tmp);
                    }
                }
                YenidenOlcekle();
                if (scaledImages != null && scaledImages.Length > 0) pbArkaPlan.Image = scaledImages[0];
            }
            catch { }

            // Görsel Ayarlar ve Yerleşim
            GorselAyarlariYap();
            KutulariYerlestir();

            // Placeholder (Beyaz Kutuya Göre Hizalı)
            if (kullaniciTextBox != null) PlaceholderEkle(kullaniciTextBox, "Kullanıcı Adı");
            if (sifreTextBox != null) PlaceholderEkle(sifreTextBox, "Şifre");

            // Slayt Zamanlayıcı (5 Saniye)
            slaytTimer = new Timer();
            slaytTimer.Interval = 5000;
            slaytTimer.Tick += (s, ev) => {
                if (scaledImages != null && scaledImages.Length > 0)
                {
                    resimSayaci = (resimSayaci + 1) % scaledImages.Length;
                    pbArkaPlan.Image = scaledImages[resimSayaci];
                }
            };
            slaytTimer.Start();
        }

        private void ArkaPlanPictureBoxHazirla()
        {
            if (pbArkaPlan != null) return;
            pbArkaPlan = new PictureBox { Name = "pbArkaPlan", Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.StretchImage, BackColor = Color.Black };
            this.Controls.Add(pbArkaPlan);
            pbArkaPlan.SendToBack();
        }

        private void OverlayKontrolleriPictureBoxaBagla()
        {
            if (pbArkaPlan == null) return;
            if (pnlLogin != null) pnlLogin.Parent = pbArkaPlan;
            if (pnlİsim != null) pnlİsim.Parent = pbArkaPlan;
        }

        private void YenidenOlcekle()
        {
            try
            {
                if (images == null) return;
                scaledImages = new Image[images.Length];
                int w = Math.Max(1, this.ClientSize.Width);
                int h = Math.Max(1, this.ClientSize.Height);

                for (int i = 0; i < images.Length; i++)
                {
                    if (images[i] == null) continue;
                    Bitmap bmp = new Bitmap(w, h);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(images[i], 0, 0, w, h);
                    }
                    scaledImages[i] = bmp;
                }
            }
            catch { }
        }

        // TextBox'ları Beyaz Yapan ve Yazıyı Dikey Ortalamaya Hazırlayan Metot
        private void GorselAyarlariYap()
        {
            if (pnlİsim != null)
            {
                pnlİsim.BackColor = Color.Transparent;
                foreach (Control item in pnlİsim.Controls) if (item is Label) item.ForeColor = Color.White;
            }

            if (pnlLogin != null)
            {
                pnlLogin.BackColor = Color.Transparent;

                if (kullaniciTextBox != null)
                {
                    kullaniciTextBox.BackColor = Color.White;
                    kullaniciTextBox.ForeColor = Color.Black;
                    kullaniciTextBox.BorderStyle = BorderStyle.None;
                    kullaniciTextBox.Multiline = true; // Dikey ortalama için şart
                    kullaniciTextBox.Height = 40;
                }
                if (sifreTextBox != null)
                {
                    sifreTextBox.BackColor = Color.White;
                    sifreTextBox.ForeColor = Color.Black;
                    sifreTextBox.BorderStyle = BorderStyle.None;
                    sifreTextBox.Multiline = true; // Dikey ortalama için şart
                    sifreTextBox.Height = 40;
                }
            }
        }

        // POLZ MOBİLYA'yı Kutunun Üstüne Ortalayan Metot
        private void KutulariYerlestir()
        {
            if (pnlLogin != null)
            {
                pnlLogin.Left = (this.ClientSize.Width - pnlLogin.Width) / 2;
                pnlLogin.Top = (this.ClientSize.Height - pnlLogin.Height) / 2 + 50;
            }

            if (pnlİsim != null && pnlLogin != null)
            {
                pnlİsim.Left = (this.ClientSize.Width - pnlİsim.Width) / 2;
                pnlİsim.Top = pnlLogin.Top - pnlİsim.Height - 20;

                foreach (Control item in pnlİsim.Controls)
                    if (item is Label) item.Left = (pnlİsim.Width - item.Width) / 2;
            }
        }

        // Placeholder'ı Yeni Yüksekliğe Göre Ortala
        private void PlaceholderEkle(TextBox kutu, string yazi)
        {
            Label lbl = new Label { Text = yazi, ForeColor = Color.Gray, BackColor = Color.White, AutoSize = true, Cursor = Cursors.IBeam };

            // 40px yükseklik için dikey orta nokta yaklaşık +10/+12'dir
            lbl.Location = new Point(kutu.Location.X + 8, kutu.Location.Y + 11);

            lbl.Click += (s, e) => kutu.Focus();
            kutu.TextChanged += (s, e) => lbl.Visible = (kutu.Text.Length == 0);
            kutu.Parent.Controls.Add(lbl);
            lbl.BringToFront();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            Admin girisYapan = am.GirisYap(kullaniciTextBox.Text, sifreTextBox.Text);
            if (girisYapan != null)
            {
                MessageBox.Show("Hoşgeldin: " + girisYapan.Username, "SİSTEM GİRİŞİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new DashboardForm(girisYapan.Role).Show();
                this.Hide();
            }
            else MessageBox.Show("Hatalı Giriş!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            KutulariYerlestir();
            YenidenOlcekle();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (slaytTimer != null) slaytTimer.Stop();
            Application.Exit();
        }
    }
}