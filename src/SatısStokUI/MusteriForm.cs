using System;
using System.Drawing;
using System.Windows.Forms;
using SatisStokUI.BLL;
using SatisStokUI.Domain;

namespace SatisStokUI
{
    public partial class MusteriForm : Form
    {
        MusteriManager mm = new MusteriManager();
        int secilenMusteriId = 0;

        // Placeholder metinleri
        private const string PH_ADSOYAD = "Ad Soyadı";
        private const string PH_TELEFON = "Telefon No";
        private const string PH_ADRES = "Adres";

        public MusteriForm()
        {
            InitializeComponent();

            //  Placeholderları ayarla
            PlaceholderAyarla(adSoyadText, PH_ADSOYAD);
            PlaceholderAyarla(telefonText, PH_TELEFON);
            PlaceholderAyarla(adresText, PH_ADRES);

            // Form açıldığında verileri yükle
            try { Listele(); } catch { }
        }

        
        //  PLACEHOLDER MANTIĞI
        
        void PlaceholderAyarla(TextBox tb, string placeholder)
        {
            if (tb == null) return;

            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            tb.GotFocus += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };

            tb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }

        private bool PlaceholderMi(TextBox tb, string ph)
        {
            return tb != null && tb.Text.Trim() == ph && tb.ForeColor == Color.Gray;
        }

        // =========================
        // --- İŞ MANTIĞI METOTLARI ---
        // =========================
        void Listele()
        {
            dataGridView1.DataSource = mm.Listele();
            if (dataGridView1.Columns["Id"] != null) dataGridView1.Columns["Id"].Visible = false;
        }

        void Temizle()
        {
            secilenMusteriId = 0;

            //  placeholderları geri bas
            adSoyadText.Text = PH_ADSOYAD;
            adSoyadText.ForeColor = Color.Gray;

            telefonText.Text = PH_TELEFON;
            telefonText.ForeColor = Color.Gray;

            adresText.Text = PH_ADRES;
            adresText.ForeColor = Color.Gray;

            tipCmb.SelectedIndex = -1;
        }

        
        // --- BUTON OLAYLARI ---
        
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //  placeholder textleri gerçek veri sayma
                string adSoyad = PlaceholderMi(adSoyadText, PH_ADSOYAD) ? "" : adSoyadText.Text.Trim();
                string telefon = PlaceholderMi(telefonText, PH_TELEFON) ? "" : telefonText.Text.Trim();
                string adres = PlaceholderMi(adresText, PH_ADRES) ? "" : adresText.Text.Trim();

                if (string.IsNullOrWhiteSpace(adSoyad))
                {
                    MessageBox.Show("Ad Soyadı boş olamaz!");
                    return;
                }

                mm.MusteriEkle(new Musteri
                {
                    AdSoyad = adSoyad,
                    Telefon = telefon,
                    Adres = adres,
                    MusteriTipi = tipCmb.Text
                });

                MessageBox.Show("Müşteri başarıyla eklendi!");
                Listele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (secilenMusteriId != 0)
            {
                mm.MusteriSil(secilenMusteriId);
                MessageBox.Show("Müşteri silindi.");
                Listele();
                Temizle();
            }
            else MessageBox.Show("Lütfen listeden bir müşteri seçin!");
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (secilenMusteriId != 0)
            {
                //  placeholder textleri gerçek veri sayma
                string adSoyad = PlaceholderMi(adSoyadText, PH_ADSOYAD) ? "" : adSoyadText.Text.Trim();
                string telefon = PlaceholderMi(telefonText, PH_TELEFON) ? "" : telefonText.Text.Trim();
                string adres = PlaceholderMi(adresText, PH_ADRES) ? "" : adresText.Text.Trim();

                if (string.IsNullOrWhiteSpace(adSoyad))
                {
                    MessageBox.Show("Ad Soyadı boş olamaz!");
                    return;
                }

                mm.MusteriGuncelle(new Musteri
                {
                    Id = secilenMusteriId,
                    AdSoyad = adSoyad,
                    Telefon = telefon,
                    Adres = adres,
                    MusteriTipi = tipCmb.Text
                });

                MessageBox.Show("Bilgiler güncellendi!");
                Listele();
                Temizle();
            }
            else MessageBox.Show("Lütfen güncellemek istediğiniz müşteriyi seçin!");
        }

        private void listeleBtn_Click(object sender, EventArgs e) => Listele();

        
        private void btnCikis_Click(object sender, EventArgs e) => this.Close();

        // =========================
        // --- GRID OLAYLARI ---
        // =========================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                secilenMusteriId = Convert.ToInt32(row.Cells[0].Value); // ID sütunu genelde 0. indextedir

                adSoyadText.ForeColor = Color.Black;
                telefonText.ForeColor = Color.Black;
                adresText.ForeColor = Color.Black;

                adSoyadText.Text = row.Cells["AdSoyad"].Value?.ToString();
                telefonText.Text = row.Cells["Telefon"].Value?.ToString();
                adresText.Text = row.Cells["Adres"].Value?.ToString();
                tipCmb.Text = row.Cells["MusteriTipi"].Value?.ToString();
            }
        }
    }
}
