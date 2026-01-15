using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class AdminDal
    {
        DbBaglanti db = new DbBaglanti();

        public Admin GirisYap(string kadi, string sifre)
        {
            MySqlConnection baglanti = db.BaglantiGetir();
            // Tablo adın 'Users' ise aynen kalıyor
            MySqlCommand komut = new MySqlCommand("SELECT * FROM Users WHERE username=@p1 AND password=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", kadi);
            komut.Parameters.AddWithValue("@p2", sifre);

            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Admin admin = new Admin();
                admin.Id = int.Parse(dr["id"].ToString());
                admin.Username = dr["username"].ToString();
                admin.Role = dr["role"].ToString(); // Rol sütunun varsa

                baglanti.Close();
                return admin;
            }
            baglanti.Close();
            return null;
        }
    }
}