using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using EntityLayer;
using System; // DateTime için gerekli

namespace DataAccessLayer
{
    public class SatisDal : IRepository<Satis>
    {
        DbBaglanti db = new DbBaglanti();

        // --- DÜZELTME 1: EKLE METODU ---
        public void Ekle(Satis p)
        {
            MySqlConnection baglanti = db.BaglantiGetir();

            // ESKİSİ: SELECT ... (Yanlıştı)
            // YENİSİ: INSERT INTO ... (Doğrusu bu)
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

            // Veritabanındaki ismin urun_adi olduğunu doğrulamıştık
            string sql = "SELECT s.id, s.adet, s.fiyat, s.tarih, u.urun_adi, m.ad_soyad " +
                         "FROM Satislar s " +
                         "JOIN Urunler u ON s.urun_id = u.id " +
                         "JOIN Musteriler m ON s.musteri_id = m.id " +
                         "ORDER BY s.id DESC"; // Yeniler üstte görünsün

            MySqlCommand komut = new MySqlCommand(sql, baglanti);

            List<Satis> satislar = new List<Satis>();

            try
            {
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Satis s = new Satis();
                    s.Id = int.Parse(dr["id"].ToString());

                    // !!! HATA BURADAYDI: ["urun_ad"] yazıyordu, ["urun_adi"] yaptık !!!
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
                // Hata olursa boş liste dönsün, program patlamasın
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