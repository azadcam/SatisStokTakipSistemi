using System;
using System.Collections.Generic;
using DataAccessLayer; // Mutfaktaki işçiyi tanıması için
using EntityLayer;     // Müşteri kartını tanıması için

namespace BusinessLayer
{
    public class MusteriManager
    {
        // Mutfaktaki Müşteri Sorumlusunu (MusteriDal) çağırıyoruz
        MusteriDal dal = new MusteriDal();

        public List<Musteri> Listele()
        {
            return dal.Listele();
        }

        public void MusteriEkle(Musteri m)
        {
            // Basit bir kural: İsim boş olamaz
            if (string.IsNullOrEmpty(m.AdSoyad) || m.AdSoyad.Length < 3)
            {
                throw new Exception("Müşteri adı en az 3 harf olmalıdır!");
            }
            dal.Ekle(m);
        }

        public void MusteriSil(int id)
        {
            if (id <= 0) throw new Exception("Geçersiz ID");
            dal.Sil(id);
        }

        public void MusteriGuncelle(Musteri m)
        {
            if (string.IsNullOrEmpty(m.AdSoyad)) throw new Exception("İsim boş olamaz!");
            dal.Guncelle(m);
        }
    }
}