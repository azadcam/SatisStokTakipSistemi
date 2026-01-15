using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatisStokUI.DAL; 
using SatisStokUI.Domain;

namespace SatisStokUI.BLL
{
    public class UrunManager
    {
        UrunDal dal = new UrunDal();

        public List<Urun> TumunuListele()
        {
            return dal.Listele();
        }

        public void UrunEkle(Urun p)
        {
            if (p.UrunAd == "" || p.UrunAd.Length < 3)
            {
                throw new Exception("Ürün adı en az 3 harfli olmalıdır!");
            }

            if (p.Stok < 0)
            {
                throw new Exception("Stok sayısı 0'dan küçük olamaz!");
            }

            if (p.Fiyat <= 0)
            {
                throw new Exception("Fiyat 0 veya daha küçük olamaz!");
            }

            dal.Ekle(p);
        }

        public void UrunSil(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Geçersiz ID!");
            }
            dal.Sil(id);
        }

        public void UrunGuncelle(Urun p)
        {
            if (p.UrunAd == "" || p.Stok < 0 || p.Fiyat <= 0)
            {
                throw new Exception("Ürün bilgileri hatalı! Güncelleme yapılamadı.");
            }

            dal.Guncelle(p);
        }

        public Urun UrunGetir(int id)
        {
            return dal.Getir(id);
        }
    }
}