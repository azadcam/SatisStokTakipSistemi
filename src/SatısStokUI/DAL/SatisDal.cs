using System.Collections.Generic;
using System.Data;                // ✅ EKLENDİ
using System.Data.SqlClient;      // (Gereksiz ama sende vardı, kalsın)
using MySql.Data.MySqlClient;
using SatisStokUI.Domain;
using System; // DateTime için gerekli

namespace SatisStokUI.DAL
{
    public class SatisDal : IRepository<Satis>
    {
        DbBaglanti db = new DbBaglanti();

        // ✅ YENİ: ŞUBE LİSTELE (ComboBox doldurmak için)
        public DataTable SubeleriGetir()
        {
            MySqlConnection baglanti = db.BaglantiGetir();

            string sql = "SELECT id, sube_adi FROM Subeler ORDER BY sube_adi";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            baglanti.Close();
            return dt;
        }

        // --- DÜZELTME 1: EKLE METODU ---
        public void Ekle(Satis p)
        {
            MySqlConnection baglanti = db.BaglantiGetir();

            // ❗ Eğer Satislar tablosuna sube_id eklediysen ve satış eklerken şube de kaydetmek istiyorsan:
            // string sql = "INSERT INTO Satislar (urun_id, musteri_id, adet, fiyat, tarih, sube_id) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
            // Şimdilik mevcut halini bozmayalım diye aynı bıraktım.

            string sql = "INSERT INTO Satislar (urun_id, musteri_id, adet, fiyat, tarih) VALUES (@p1, @p2, @p3, @p4, @p5)";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@p1", p.UrunId);
            komut.Parameters.AddWithValue("@p2", p.MusteriId);
            komut.Parameters.AddWithValue("@p3", p.Adet);
            komut.Parameters.AddWithValue("@p4", p.Fiyat);
            komut.Parameters.AddWithValue("@p5", p.Tarih);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        // --- DÜZELTME 2: LİSTELE METODU ---
        public List<Satis> Listele()
        {
            MySqlConnection baglanti = db.BaglantiGetir();

            string sql = "SELECT s.id, s.adet, s.fiyat, s.tarih, u.urun_adi, m.ad_soyad " +
                         "FROM Satislar s " +
                         "JOIN Urunler u ON s.urun_id = u.id " +
                         "JOIN Musteriler m ON s.musteri_id = m.id " +
                         "ORDER BY s.id DESC";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);

            List<Satis> satislar = new List<Satis>();

            try
            {
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Satis s = new Satis();
                    s.Id = int.Parse(dr["id"].ToString());

                    if (dr["urun_adi"] != DBNull.Value)
                        s.UrunAd = dr["urun_adi"].ToString();

                    if (dr["ad_soyad"] != DBNull.Value)
                        s.MusteriAd = dr["ad_soyad"].ToString();

                    s.Adet = int.Parse(dr["adet"].ToString());
                    s.Fiyat = decimal.Parse(dr["fiyat"].ToString());
                    s.Tarih = DateTime.Parse(dr["tarih"].ToString());

                    satislar.Add(s);
                }
            }
            catch
            {
                // Hata olursa boş liste dönsün
            }
            finally
            {
                baglanti.Close();
            }

            return satislar;
        }

        public void Sil(int id) { }
        public void Guncelle(Satis p) { }
        public Satis Getir(int id) { return null; }
    }
}
