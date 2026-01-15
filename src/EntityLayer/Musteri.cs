using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Musteri : BaseEntity 
    {
        public string AdSoyad { get; set; }    
        public string Telefon { get; set; }    
        public string Adres { get; set; }     
        public string MusteriTipi { get; set; } 
    }
}
