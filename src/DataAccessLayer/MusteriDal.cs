using System.Collections.Generic;
using MySql.Data.MySqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class MusteriDal : IRepository<Musteri>
    {
        DbBaglanti db = new DbBaglanti();

        public void Ekle(Musteri p)
        {
            MySqlConnection baglanti = db.BaglantiGetir();
            // SQL'deki sütun isimlerine dikkat!
            string sql = "INSERT INTO Musteriler (ad_soyad, telefon, adres, musteri_tipi) VALUES (@p1, @p2, @p3, @p4)";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@p1", p.AdSoyad);
            komut.Parameters.AddWithValue("@p2", p.Telefon);
            komut.Parameters.AddWithValue("@p3", p.Adres);
            komut.Parameters.AddWithValue("@p4", p.MusteriTipi);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil(int id)
        {
            MySqlConnection baglanti = db.BaglantiGetir();
            MySqlCommand komut = new MySqlCommand("DELETE FROM Musteriler WHERE id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Guncelle(Musteri p)
        {
            MySqlConnection baglanti = db.BaglantiGetir();
            string sql = "UPDATE Musteriler SET ad_soyad=@p1, telefon=@p2, adres=@p3, musteri_tipi=@p4 WHERE id=@id";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@p1", p.AdSoyad);
            komut.Parameters.AddWithValue("@p2", p.Telefon);
            komut.Parameters.AddWithValue("@p3", p.Adres);
            komut.Parameters.AddWithValue("@p4", p.MusteriTipi);
            komut.Parameters.AddWithValue("@id", p.Id);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public List<Musteri> Listele()
        {
            MySqlConnection baglanti = db.BaglantiGetir();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM Musteriler", baglanti);
            MySqlDataReader dr = komut.ExecuteReader();

            List<Musteri> musteriler = new List<Musteri>();

            while (dr.Read())
            {
                Musteri m = new Musteri();
                m.Id = int.Parse(dr["id"].ToString());
                m.AdSoyad = dr["ad_soyad"].ToString();
                m.Telefon = dr["telefon"].ToString();
                m.Adres = dr["adres"].ToString();
                m.MusteriTipi = dr["musteri_tipi"].ToString();

                musteriler.Add(m);
            }
            baglanti.Close();
            return musteriler;
        }

        public Musteri Getir(int id)
        {
            // Şimdilik boş, gerekirse doldururuz
            throw new System.NotImplementedException();
        }
    }
}