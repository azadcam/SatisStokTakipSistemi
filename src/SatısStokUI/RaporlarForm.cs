using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using SatisStokUI.BLL;

namespace SatisStokUI
{
    public partial class RaporlarForm : Form
    {
        // Manager Sınıfları
        private readonly SatisManager sm = new SatisManager();
        private readonly UrunManager um = new UrunManager();

        // Kritik stok kartı yanıp sönme
        private Timer kritikStokTimer;
        private bool kritikRenkDurum = false;
        private Panel pnlKritikStokKart;
        private Color kritikNormalRenk = Color.FromArgb(45, 45, 48);

        // DB bağlantısı 
        private string ConnStr
        {
            get
            {
                string cs = null;
                try { cs = ConfigurationManager.ConnectionStrings["MyDb"]?.ConnectionString; } catch { }

                if (!string.IsNullOrWhiteSpace(cs))
                    return cs;

                MessageBox.Show(
                    "App.config içinde connectionStrings -> MyDb bulunamadı!\n" +
                    "Şimdilik fallback bağlantı kullanılacak.",
                    "DB Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return "Server=172.21.54.253;Port=3306;Database=26_132430016;Uid=26_132430016;Pwd=İnif123.;Charset=utf8mb4;";
            }
        }

        public RaporlarForm()
        {
            InitializeComponent();

            if (tvMenu != null) tvMenu.AfterSelect += tvMenu_AfterSelect;
            if (btnFiltrele != null) btnFiltrele.Click += btnFiltrele_Click;

            // Combobox değişince otomatik filtrele
            if (cmbSube != null) cmbSube.SelectedIndexChanged += cmbSube_SelectedIndexChanged;
            if (cmbKategori != null) cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;

            // ✅ Şube + Kategori doldur
            SubeComboDoldur();
            KategoriComboDoldur();

            // ✅ Tarih default: son 30 gün (designer’da 2026 kaldığı için boş geliyordu)
            TrySetDefaultDateRange();

            SayfaGoster("Satış Ve Ciro");
        }

        private void TrySetDefaultDateRange()
        {
            try
            {
                var dtps = FindAllControls<DateTimePicker>(this);
                var dtBas = dtps.FirstOrDefault(x => x.Name.Equals("dtBaslangic", StringComparison.OrdinalIgnoreCase));
                var dtBit = dtps.FirstOrDefault(x => x.Name.Equals("dtBitis", StringComparison.OrdinalIgnoreCase));

                if (dtBas != null && dtBit != null)
                {
                    dtBas.Value = DateTime.Today.AddDays(-30);
                    dtBit.Value = DateTime.Today;
                }
            }
            catch { }
        }

        // =========================
        // ✅ ŞUBE COMBO DOLDUR
        // =========================
        private void SubeComboDoldur()
        {
            if (cmbSube == null) return;

            var dt = new DataTable();
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                using (var cmd = new MySqlCommand("SELECT id, sube_adi FROM Subeler ORDER BY sube_adi", conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                cmbSube.DataSource = null;
                cmbSube.DisplayMember = "sube_adi";
                cmbSube.ValueMember = "id";
                cmbSube.DataSource = dt;
                cmbSube.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şube Combo doldurma hatası:\n" + ex, "Hata");
            }
        }

        private int? SeciliSubeId()
        {
            try
            {
                if (cmbSube == null) return null;
                if (cmbSube.SelectedValue == null) return null;
                if (cmbSube.SelectedValue is DataRowView) return null;

                if (int.TryParse(cmbSube.SelectedValue.ToString(), out int id))
                    return id;
            }
            catch { }
            return null;
        }

        // =========================
        // ✅ KATEGORİ COMBO DOLDUR
        // =========================
        private void KategoriComboDoldur()
        {
            if (cmbKategori == null) return;

            var dt = new DataTable();
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                using (var cmd = new MySqlCommand("SELECT id, kategori_adi FROM Kategoriler ORDER BY kategori_adi", conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                cmbKategori.DataSource = null;
                cmbKategori.DisplayMember = "kategori_adi";
                cmbKategori.ValueMember = "id";
                cmbKategori.DataSource = dt;
                cmbKategori.SelectedIndex = -1; // kategori seçilmesin default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori Combo doldurma hatası:\n" + ex, "Hata");
            }
        }

        private int? SeciliKategoriId()
        {
            try
            {
                if (cmbKategori == null) return null;
                if (cmbKategori.SelectedValue == null) return null;
                if (cmbKategori.SelectedValue is DataRowView) return null;

                if (int.TryParse(cmbKategori.SelectedValue.ToString(), out int id))
                    return id;
            }
            catch { }
            return null;
        }

        private void cmbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSube?.SelectedValue == null) return;
            if (cmbSube.SelectedValue is DataRowView) return;
            btnFiltrele_Click(null, null);
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kategori boş seçiliyse de filtre çalışsın (tüm kategoriler)
            if (cmbKategori?.SelectedValue is DataRowView) return;
            btnFiltrele_Click(null, null);
        }

        // =========================
        // ✅ KRİTİK STOK ANİMASYON
        // =========================
        private void KritikStokAnimasyonBaslat()
        {
            if (pnlKritikStokKart == null) return;

            if (kritikStokTimer == null)
            {
                kritikStokTimer = new Timer();
                kritikStokTimer.Interval = 500;
                kritikStokTimer.Tick += (s, e) =>
                {
                    kritikRenkDurum = !kritikRenkDurum;
                    pnlKritikStokKart.BackColor = kritikRenkDurum
                        ? Color.DarkRed
                        : Color.FromArgb(120, 0, 0);
                };
            }

            if (!kritikStokTimer.Enabled)
                kritikStokTimer.Start();
        }

        private void KritikStokAnimasyonDurdur()
        {
            if (kritikStokTimer != null) kritikStokTimer.Stop();
            if (pnlKritikStokKart != null) pnlKritikStokKart.BackColor = kritikNormalRenk;
        }

        // =========================
        // MENU -> SAYFA DEĞİŞTİR
        // =========================
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e?.Node == null) return;

            string secim = e.Node.Text.Trim();
            if (e.Node.Parent != null)
                secim = e.Node.Parent.Text.Trim();

            SayfaGoster(secim);
        }

        private void SayfaGoster(string secim)
        {
            if (pnlPageSatisCiro != null) pnlPageSatisCiro.Visible = false;
            if (pnlPageStokUretim != null) pnlPageStokUretim.Visible = false;
            if (pnlPageMusteri != null) pnlPageMusteri.Visible = false;
            if (pnlPageFinans != null) pnlPageFinans.Visible = false;

            switch (secim)
            {
                case "Satış Ve Ciro":
                case "Satış & Ciro":
                    if (pnlPageSatisCiro != null)
                    {
                        pnlPageSatisCiro.Visible = true;
                        pnlPageSatisCiro.BringToFront();
                        if (lblBaslik != null) lblBaslik.Text = "Satış & Ciro Raporları";
                        try { SatisSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    }
                    break;

                case "Stok Ve Uretim":
                case "Stok Ve Üretim":
                case "Stok & Üretim":
                    if (pnlPageStokUretim != null)
                    {
                        pnlPageStokUretim.Visible = true;
                        pnlPageStokUretim.BringToFront();
                        if (lblBaslik != null) lblBaslik.Text = "Stok & Üretim Raporları";
                        try { StokSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    }
                    break;

                case "Müşteri":
                    if (pnlPageMusteri != null)
                    {
                        pnlPageMusteri.Visible = true;
                        pnlPageMusteri.BringToFront();
                        if (lblBaslik != null) lblBaslik.Text = "Müşteri Raporları";
                        try { MusteriSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    }
                    break;

                case "Finansal Raporlar":
                case "Finans":
                    if (pnlPageFinans != null)
                    {
                        pnlPageFinans.Visible = true;
                        pnlPageFinans.BringToFront();
                        if (lblBaslik != null) lblBaslik.Text = "Finansal Raporlar";
                        try { FinansSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    }
                    break;

                default:
                    if (pnlPageSatisCiro != null)
                    {
                        pnlPageSatisCiro.Visible = true;
                        pnlPageSatisCiro.BringToFront();
                        if (lblBaslik != null) lblBaslik.Text = "Raporlar";
                        try { SatisSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    }
                    break;
            }
        }

        // =========================
        // FILTRELE
        // =========================
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (pnlPageSatisCiro != null && pnlPageSatisCiro.Visible)
            {
                try { SatisSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else if (pnlPageStokUretim != null && pnlPageStokUretim.Visible)
            {
                try { StokSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else if (pnlPageMusteri != null && pnlPageMusteri.Visible)
            {
                try { MusteriSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else if (pnlPageFinans != null && pnlPageFinans.Visible)
            {
                try { FinansSayfasiDoldur(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        // =========================
        // SATIŞ SAYFASI DOLDUR (✅ ŞUBE + KATEGORİ + TARİH)
        // =========================
        private void SatisSayfasiDoldur()
        {
            var range = GetDateRangeOrDefault();
            DateTime bas = range.Item1;
            DateTime bit = range.Item2;

            int? subeId = SeciliSubeId();
            int? katId = SeciliKategoriId();

            var dt = new DataTable();

            using (var conn = new MySqlConnection(ConnStr))
            using (var cmd = new MySqlCommand(@"
SELECT 
    s.id,
    s.tarih,
    u.urun_adi,
    m.ad_soyad,
    sb.sube_adi,
    s.adet,
    s.fiyat,
    (s.adet * s.fiyat) AS tutar,
    u.kategori_id
FROM Satislar s
JOIN Urunler u ON u.id = s.urun_id
JOIN Musteriler m ON m.id = s.musteri_id
JOIN Subeler sb ON sb.id = s.sube_id
WHERE s.tarih BETWEEN @bas AND @bit
  AND (@subeId IS NULL OR s.sube_id = @subeId)
  AND (@katId IS NULL OR u.kategori_id = @katId)
ORDER BY s.tarih DESC;", conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@bas", bas);
                cmd.Parameters.AddWithValue("@bit", bit);
                cmd.Parameters.AddWithValue("@subeId", (object)subeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@katId", (object)katId ?? DBNull.Value);
                da.Fill(dt);
            }

            // KPI
            decimal toplamCiro = 0m;
            int siparisSayisi = 0;

            if (dt.Rows.Count > 0)
            {
                toplamCiro = dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["tutar"]));
                siparisSayisi = dt.Rows.Count;
            }

            // Kritik stok (ürünler tablosundan)
            var urunler = um.TumunuListele();
            int kritikStokSayisi = urunler.Count(x => x.Stok <= 5);

            // Senin satış sayfası label isimleri:
            // lblUrunAdet -> Toplam Ciro (TL)
            // lblSatisDeger -> Toplam Satış (Sipariş sayısı)
            // lblStokDeger -> Kritik Stok (Ürün)
            if (lblUrunAdet != null) lblUrunAdet.Text = $"{toplamCiro:0.##} TL";
            if (lblSatisDeger != null) lblSatisDeger.Text = $"{siparisSayisi} Satış";
            if (lblStokDeger != null) lblStokDeger.Text = $"{kritikStokSayisi} Ürün";

            // Chart
            var chart = FindAllControls<Chart>(pnlPageSatisCiro).FirstOrDefault(c => c.Name == "chartSatis");
            if (chart != null)
            {
                SetupDarkChart(chart, "En Çok Kazandıran Ürünler");
                chart.Series.Clear();

                Series seri = new Series("Ciro");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;
                seri.LabelForeColor = Color.White;

                var analiz = dt.AsEnumerable()
                    .GroupBy(r => r["urun_adi"].ToString())
                    .Select(g => new { Urun = g.Key, Tutar = g.Sum(x => Convert.ToDecimal(x["tutar"])) })
                    .OrderByDescending(x => x.Tutar)
                    .Take(7)
                    .ToList();

                foreach (var veri in analiz)
                    seri.Points.AddXY(veri.Urun, veri.Tutar);

                chart.Series.Add(seri);
            }

            // Grid
            var grid = EnsureGrid(pnlPageSatisCiro);
            if (grid != null)
            {
                var view = dt.AsEnumerable()
                    .Take(50)
                    .Select(r => new
                    {
                        Tarih = Convert.ToDateTime(r["tarih"]).ToString("dd.MM.yyyy HH:mm"),
                        Şube = r["sube_adi"].ToString(),
                        Ürün = r["urun_adi"].ToString(),
                        Müşteri = r["ad_soyad"].ToString(),
                        Adet = Convert.ToInt32(r["adet"]),
                        BirimFiyat = Convert.ToDecimal(r["fiyat"]),
                        Tutar = Convert.ToDecimal(r["tutar"])
                    })
                    .ToList();

                grid.DataSource = view;
            }
        }

        // =========================
        // STOK SAYFASI DOLDUR
        // =========================
        private void StokSayfasiDoldur()
        {
            var urunler = um.TumunuListele();

            pnlKritikStokKart = FindAllControls<Panel>(pnlPageStokUretim)
                .FirstOrDefault(p => p.Name != null && p.Name.ToLower().Contains("kritik"));

            if (pnlKritikStokKart != null)
                kritikNormalRenk = pnlKritikStokKart.BackColor;

            int toplamUrun = urunler.Count;
            int toplamStok = urunler.Sum(x => x.Stok);
            int kritikStokSayisi = urunler.Count(x => x.Stok <= 5);

            if (lblToplamUrunDeger != null) lblToplamUrunDeger.Text = $"{toplamUrun} Ürün";
            if (lblToplamStokDeger != null) lblToplamStokDeger.Text = $"{toplamStok} Adet";
            if (lblKritikStokDeger != null) lblKritikStokDeger.Text = $"{kritikStokSayisi} Ürün";

            if (kritikStokSayisi > 0) KritikStokAnimasyonBaslat();
            else KritikStokAnimasyonDurdur();

            var chart = chartStok;
            var grid = EnsureGrid(pnlPageStokUretim);

            if (chart != null)
            {
                SetupDarkChart(chart, "Ürün Bazlı Stok Dağılımı");

                chart.Series.Clear();
                Series seri = new Series("Stok");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;
                seri.LabelForeColor = Color.White;

                var top = urunler
                    .OrderByDescending(x => x.Stok)
                    .Take(10)
                    .ToList();

                foreach (var u in top)
                    seri.Points.AddXY(u.UrunAd, u.Stok);

                chart.Series.Add(seri);
            }

            if (grid != null)
            {
                var liste = urunler
                    .OrderBy(x => x.Stok)
                    .Select(x => new
                    {
                        Ürün = x.UrunAd,
                        Stok = x.Stok,
                        Kritik = x.Stok <= 5 ? "Evet" : "Hayır"
                    })
                    .ToList();

                grid.DataSource = liste;
            }
        }

        // =========================
        // MÜŞTERİ SAYFASI DOLDUR (✅ ŞUBE + KATEGORİ + TARİH)
        // =========================
        private void MusteriSayfasiDoldur()
        {
            var range = GetDateRangeOrDefault();
            DateTime bas = range.Item1;
            DateTime bit = range.Item2;

            int? subeId = SeciliSubeId();
            int? katId = SeciliKategoriId();

            int toplamMusteri = 0;
            decimal toplamCiro = 0m;
            string enIyiMusteri = "-";

            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM Musteriler", conn))
                    toplamMusteri = Convert.ToInt32(cmd.ExecuteScalar());

                using (var cmd = new MySqlCommand(@"
SELECT IFNULL(SUM(s.adet * s.fiyat), 0)
FROM Satislar s
JOIN Urunler u ON u.id = s.urun_id
WHERE s.tarih BETWEEN @bas AND @bit
  AND (@subeId IS NULL OR s.sube_id = @subeId)
  AND (@katId IS NULL OR u.kategori_id = @katId)", conn))
                {
                    cmd.Parameters.AddWithValue("@bas", bas);
                    cmd.Parameters.AddWithValue("@bit", bit);
                    cmd.Parameters.AddWithValue("@subeId", (object)subeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@katId", (object)katId ?? DBNull.Value);
                    toplamCiro = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                using (var cmd = new MySqlCommand(@"
SELECT m.ad_soyad
FROM Musteriler m
JOIN Satislar s ON s.musteri_id = m.id
JOIN Urunler u ON u.id = s.urun_id
WHERE s.tarih BETWEEN @bas AND @bit
  AND (@subeId IS NULL OR s.sube_id = @subeId)
  AND (@katId IS NULL OR u.kategori_id = @katId)
GROUP BY m.id, m.ad_soyad
ORDER BY SUM(s.adet * s.fiyat) DESC
LIMIT 1;", conn))
                {
                    cmd.Parameters.AddWithValue("@bas", bas);
                    cmd.Parameters.AddWithValue("@bit", bit);
                    cmd.Parameters.AddWithValue("@subeId", (object)subeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@katId", (object)katId ?? DBNull.Value);

                    var val = cmd.ExecuteScalar();
                    if (val != null && val != DBNull.Value)
                        enIyiMusteri = val.ToString();
                }
            }

            if (lblEnIyiMusteriDeger != null) lblEnIyiMusteriDeger.Text = enIyiMusteri;
            if (lblToplamCiroDeger != null) lblToplamCiroDeger.Text = $"{toplamCiro:0.##} TL";
            if (lblToplamMusteriDeger != null) lblToplamMusteriDeger.Text = toplamMusteri.ToString();

            Chart chart = null;
            DataGridView grid = null;

            if (pnlPageMusteri != null)
            {
                chart = FindAllControls<Chart>(pnlPageMusteri).FirstOrDefault(c => c.Name == "chartMusterii");
                grid = FindAllControls<DataGridView>(pnlPageMusteri).FirstOrDefault(g => g.Name == "dgvMusteri");
            }

            if (chart != null)
            {
                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Titles.Clear();

                ChartArea area = new ChartArea("MainArea");
                area.BackColor = Color.Transparent;

                area.AxisX.LabelStyle.ForeColor = Color.White;
                area.AxisY.LabelStyle.ForeColor = Color.White;

                area.AxisX.LineColor = Color.Gray;
                area.AxisY.LineColor = Color.Gray;

                area.AxisX.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);
                area.AxisY.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);

                chart.ChartAreas.Add(area);

                Title t = new Title("En Çok Alışveriş Yapan Müşteriler");
                t.ForeColor = Color.White;
                t.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                chart.Titles.Add(t);

                Series seri = new Series("Ciro");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;
                seri.LabelForeColor = Color.White;

                var dtChart = new DataTable();
                using (var conn = new MySqlConnection(ConnStr))
                using (var cmd = new MySqlCommand(@"
SELECT 
    m.ad_soyad,
    SUM(s.adet * s.fiyat) AS toplam_ciro
FROM Musteriler m
JOIN Satislar s ON s.musteri_id = m.id
JOIN Urunler u ON u.id = s.urun_id
WHERE s.tarih BETWEEN @bas AND @bit
  AND (@subeId IS NULL OR s.sube_id = @subeId)
  AND (@katId IS NULL OR u.kategori_id = @katId)
GROUP BY m.id, m.ad_soyad
ORDER BY toplam_ciro DESC
LIMIT 7;", conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@bas", bas);
                    cmd.Parameters.AddWithValue("@bit", bit);
                    cmd.Parameters.AddWithValue("@subeId", (object)subeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@katId", (object)katId ?? DBNull.Value);
                    da.Fill(dtChart);
                }

                foreach (DataRow r in dtChart.Rows)
                {
                    string ad = r["ad_soyad"].ToString();
                    decimal ciro = Convert.ToDecimal(r["toplam_ciro"]);
                    seri.Points.AddXY(ad, ciro);
                }

                chart.Series.Add(seri);
            }

            if (grid != null)
            {
                var dtGrid = new DataTable();
                using (var conn = new MySqlConnection(ConnStr))
                using (var cmd = new MySqlCommand(@"
SELECT 
    m.ad_soyad AS Musteri,
    SUM(s.adet * s.fiyat) AS ToplamCiro,
    COUNT(s.id) AS SiparisSayisi,
    MAX(s.tarih) AS SonSatis
FROM Musteriler m
JOIN Satislar s ON s.musteri_id = m.id
JOIN Urunler u ON u.id = s.urun_id
WHERE s.tarih BETWEEN @bas AND @bit
  AND (@subeId IS NULL OR s.sube_id = @subeId)
  AND (@katId IS NULL OR u.kategori_id = @katId)
GROUP BY m.id, m.ad_soyad
ORDER BY ToplamCiro DESC
LIMIT 50;", conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@bas", bas);
                    cmd.Parameters.AddWithValue("@bit", bit);
                    cmd.Parameters.AddWithValue("@subeId", (object)subeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@katId", (object)katId ?? DBNull.Value);
                    da.Fill(dtGrid);
                }

                grid.DataSource = dtGrid;

                grid.ReadOnly = true;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.RowHeadersVisible = false;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        // =========================
        // FİNANS SAYFASI DOLDUR (✅ ŞUBE + KATEGORİ + TARİH)
        // =========================
        private void FinansSayfasiDoldur()
        {
            var range = GetDateRangeOrDefault();
            DateTime bas = range.Item1;
            DateTime bit = range.Item2;

            int? subeId = SeciliSubeId();
            int? katId = SeciliKategoriId();

            decimal toplamGelir = 0m;
            decimal toplamGider = 0m; // gider tablon yoksa 0 kalır
            decimal netKar = 0m;

            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(@"
SELECT IFNULL(SUM(s.adet * s.fiyat), 0)
FROM Satislar s
JOIN Urunler u ON u.id = s.urun_id
WHERE s.tarih BETWEEN @bas AND @bit
  AND (@subeId IS NULL OR s.sube_id = @subeId)
  AND (@katId IS NULL OR u.kategori_id = @katId)", conn))
                {
                    cmd.Parameters.AddWithValue("@bas", bas);
                    cmd.Parameters.AddWithValue("@bit", bit);
                    cmd.Parameters.AddWithValue("@subeId", (object)subeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@katId", (object)katId ?? DBNull.Value);
                    toplamGelir = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            netKar = toplamGelir - toplamGider;

            if (lblToplamGelirDeger != null) lblToplamGelirDeger.Text = toplamGelir.ToString("C2");
            if (lblToplamGiderDeger != null) lblToplamGiderDeger.Text = toplamGider.ToString("C2");
            if (lblNetKarDeger != null) lblNetKarDeger.Text = netKar.ToString("C2");

            var grid = FindAllControls<DataGridView>(pnlPageFinans).FirstOrDefault(g => g.Name == "dgvFinans");
            if (grid != null)
            {
                var dt = new DataTable();
                using (var conn = new MySqlConnection(ConnStr))
                using (var cmd = new MySqlCommand(@"
SELECT 
    DATE(s.tarih) AS Gun,
    IFNULL(SUM(s.adet * s.fiyat), 0) AS Gelir,
    0 AS Gider,
    IFNULL(SUM(s.adet * s.fiyat), 0) AS Net
FROM Satislar s
JOIN Urunler u ON u.id = s.urun_id
WHERE s.tarih BETWEEN @bas AND @bit
  AND (@subeId IS NULL OR s.sube_id = @subeId)
  AND (@katId IS NULL OR u.kategori_id = @katId)
GROUP BY DATE(s.tarih)
ORDER BY Gun DESC;", conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@bas", bas);
                    cmd.Parameters.AddWithValue("@bit", bit);
                    cmd.Parameters.AddWithValue("@subeId", (object)subeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@katId", (object)katId ?? DBNull.Value);
                    da.Fill(dt);
                }

                grid.DataSource = dt;

                grid.ReadOnly = true;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.RowHeadersVisible = false;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            var chart = FindAllControls<Chart>(pnlPageFinans).FirstOrDefault(c => c.Name == "chartFinans");
            if (chart != null)
            {
                SetupDarkChart(chart, "Günlük Gelir Trend");
                chart.Series.Clear();

                var seri = new Series("Gelir");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;
                seri.LabelForeColor = Color.White;

                using (var conn = new MySqlConnection(ConnStr))
                using (var cmd = new MySqlCommand(@"
SELECT 
    DATE(s.tarih) AS Gun,
    IFNULL(SUM(s.adet * s.fiyat), 0) AS Gelir
FROM Satislar s
JOIN Urunler u ON u.id = s.urun_id
WHERE s.tarih BETWEEN @bas AND @bit
  AND (@subeId IS NULL OR s.sube_id = @subeId)
  AND (@katId IS NULL OR u.kategori_id = @katId)
GROUP BY DATE(s.tarih)
ORDER BY Gun ASC;", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@bas", bas);
                    cmd.Parameters.AddWithValue("@bit", bit);
                    cmd.Parameters.AddWithValue("@subeId", (object)subeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@katId", (object)katId ?? DBNull.Value);

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string gun = Convert.ToDateTime(r["Gun"]).ToString("dd.MM");
                            decimal gelir = Convert.ToDecimal(r["Gelir"]);
                            seri.Points.AddXY(gun, gelir);
                        }
                    }
                }

                chart.Series.Add(seri);
            }
        }

        // dtBaslangic / dtBitis kontrolünü bulup aralık döndürür
        private Tuple<DateTime, DateTime> GetDateRangeOrDefault()
        {
            DateTimePicker dtBas = null;
            DateTimePicker dtBit = null;

            var dtps = FindAllControls<DateTimePicker>(this);
            dtBas = dtps.FirstOrDefault(x => x.Name.Equals("dtBaslangic", StringComparison.OrdinalIgnoreCase));
            dtBit = dtps.FirstOrDefault(x => x.Name.Equals("dtBitis", StringComparison.OrdinalIgnoreCase));

            if (dtBas != null && dtBit != null)
            {
                var bas = dtBas.Value.Date;
                var bit = dtBit.Value.Date.AddDays(1).AddSeconds(-1);
                return Tuple.Create(bas, bit);
            }

            // default: son 30 gün
            return Tuple.Create(DateTime.Today.AddDays(-30), DateTime.Today.AddDays(1).AddSeconds(-1));
        }

        // =========================
        // HELPER: Sayfa içinden DataGridView bul / yoksa ekle
        // =========================
        private DataGridView EnsureGrid(Control pageRoot)
        {
            if (pageRoot == null) return null;

            var existing = FindAllControls<DataGridView>(pageRoot).FirstOrDefault();
            if (existing != null) return existing;

            var gridHost = FindAllControls<Panel>(pageRoot)
                .FirstOrDefault(p => p.Name != null && p.Name.StartsWith("pnlTable", StringComparison.OrdinalIgnoreCase));

            if (gridHost == null) return null;

            var dgv = new DataGridView();
            dgv.Name = "dgvAuto";
            dgv.Dock = DockStyle.Fill;

            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgv.GridColor = Color.FromArgb(70, 70, 70);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 65);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;

            gridHost.Controls.Add(dgv);
            dgv.BringToFront();
            return dgv;
        }

        private void SetupDarkChart(Chart chart, string title)
        {
            if (chart == null) return;

            chart.ChartAreas.Clear();
            chart.Titles.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent;

            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;

            area.AxisX.LineColor = Color.Gray;
            area.AxisY.LineColor = Color.Gray;

            area.AxisX.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);

            chart.ChartAreas.Add(area);

            Title t = new Title(title);
            t.ForeColor = Color.White;
            t.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chart.Titles.Add(t);
        }

       
        private static List<T> FindAllControls<T>(Control root) where T : Control
        {
            var result = new List<T>();
            if (root == null) return result;

            foreach (Control c in root.Controls)
            {
                if (c is T t) result.Add(t);
                if (c.HasChildren) result.AddRange(FindAllControls<T>(c));
            }
            return result;
        }

        // Kapat butonu varsa
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RaporlarForm_Load(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void lblAktifMusteriBaslik_Click(object sender, EventArgs e) { }
        private void lblAktifMusteriDeger_Click(object sender, EventArgs e) { }
    }
}
