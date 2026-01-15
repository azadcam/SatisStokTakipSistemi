using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Urun : BaseEntity
    {
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public int MinStok { get; set; }    
        public int KategoriId { get; set; }

    }
}