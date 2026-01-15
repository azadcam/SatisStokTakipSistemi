using System;
using System.Collections.Generic;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class SatisManager
    {
        SatisDal satisDal = new SatisDal();
        UrunDal urunDal = new UrunDal(); // Ürün stoğuna erişmek için

        public List<Satis> Listele()
        {
            return satisDal.Listele();
        }

        public void SatisYap(Satis s)
        {
            // 1. Önce satılmak istenen ürünü bul
            Urun satilanUrun = urunDal.Getir(s.UrunId);

            // 2. Stok Kontrolü: Yeterli ürün var mı?
            if (satilanUrun.Stok < s.Adet)
            {
                throw new Exception("Yetersiz Stok! Depoda sadece " + satilanUrun.Stok + " adet var.");
            }

            // 3. Stoktan Düşme İşlemi
            satilanUrun.Stok = satilanUrun.Stok - s.Adet;
            urunDal.Guncelle(satilanUrun); // Yeni stoğu kaydet

            // 4. Satışı Kaydet
            s.Tarih = DateTime.Now; // Şu anki zaman
            satisDal.Ekle(s);
        }
    }
}