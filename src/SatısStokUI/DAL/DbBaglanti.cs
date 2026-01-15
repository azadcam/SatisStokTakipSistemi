using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace SatisStokUI.DAL
{
    public class DbBaglanti
    {
        public MySqlConnection BaglantiGetir()
        {
            

            string adres = "Server=172.21.54.253;Database=26_132430016;User ID=26_132430016;Password=İnif123.";

            MySqlConnection baglanti = new MySqlConnection(adres);

           
            baglanti.Open();
            return baglanti;
        }
    }
}
