using System;

namespace EntityLayer
{
    public class Satis : BaseEntity
    {
        public int UrunId { get; set; }
        public int MusteriId { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; } 
        public DateTime Tarih { get; set; }

        
        public string UrunAd { get; set; }
        public string MusteriAd { get; set; }
    }
}