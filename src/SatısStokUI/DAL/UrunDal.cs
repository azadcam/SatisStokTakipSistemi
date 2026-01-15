using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SatisStokUI.Domain;

namespace SatisStokUI.DAL
{
    public class UrunDal : IRepository<Urun>
    {
        DbBaglanti db = new DbBaglanti();

        public void Ekle(Urun p)
        {
            MySqlConnection baglanti = db.BaglantiGetir();

            string sql = "INSERT INTO Urunler (urun_adi, fiyat, stok, min_stok, kategori_id) VALUES (@p1, @p2, @p3, @p4, @p5)";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);

          
            komut.Parameters.AddWithValue("@p1", p.UrunAd);
            komut.Parameters.AddWithValue("@p2", p.Fiyat);
            komut.Parameters.AddWithValue("@p3", p.Stok);
            komut.Parameters.AddWithValue("@p4", p.MinStok);

            
            komut.Parameters.AddWithValue("@p5", p.KategoriId == 0 ? 1 : p.KategoriId);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Guncelle(Urun p)
        {
            MySqlConnection baglanti = db.BaglantiGetir();

         
            string sql = "UPDATE Urunler SET urun_adi=@p1, fiyat=@p2, stok=@p3, min_stok=@p4, kategori_id=@p5 WHERE id=@id";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);

            komut.Parameters.AddWithValue("@p1", p.UrunAd);
            komut.Parameters.AddWithValue("@p2", p.Fiyat);
            komut.Parameters.AddWithValue("@p3", p.Stok);
            komut.Parameters.AddWithValue("@p4", p.MinStok);
            komut.Parameters.AddWithValue("@p5", p.KategoriId);
            komut.Parameters.AddWithValue("@id", p.Id);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil(int id)
        {
            MySqlConnection baglanti = db.BaglantiGetir();
            MySqlCommand komut = new MySqlCommand("DELETE FROM Urunler WHERE id=@id", baglanti);

            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public List<Urun> Listele()
        {
            MySqlConnection baglanti = db.BaglantiGetir();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM Urunler", baglanti);

            MySqlDataReader dr = komut.ExecuteReader();
            List<Urun> urunler = new List<Urun>();

            while (dr.Read())
            {
                Urun u = new Urun();
                u.Id = int.Parse(dr["id"].ToString());
                u.UrunAd = dr["urun_adi"].ToString();
                u.Fiyat = decimal.Parse(dr["fiyat"].ToString());
                u.Stok = int.Parse(dr["stok"].ToString());
                u.MinStok = int.Parse(dr["min_stok"].ToString());
                u.KategoriId = int.Parse(dr["kategori_id"].ToString());

                urunler.Add(u);
            }

            baglanti.Close();
            return urunler;
        }

        public Urun Getir(int id)
        {
            MySqlConnection baglanti = db.BaglantiGetir();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM Urunler WHERE id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = komut.ExecuteReader();
            Urun u = new Urun();

            if (dr.Read())
            {
                u.Id = int.Parse(dr["id"].ToString());
                u.UrunAd = dr["urun_adi"].ToString();
                u.Fiyat = decimal.Parse(dr["fiyat"].ToString());
                u.Stok = int.Parse(dr["stok"].ToString());
                u.MinStok = int.Parse(dr["min_stok"].ToString());
                u.KategoriId = int.Parse(dr["kategori_id"].ToString());
            }
            baglanti.Close();
            return u;
        }
    }
}