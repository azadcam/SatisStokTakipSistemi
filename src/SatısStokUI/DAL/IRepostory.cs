using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisStokUI.DAL
{
    
    public interface IRepository<T>
    {
        List<T> Listele();    
        void Ekle(T p);       
        void Sil(int id);     
        void Guncelle(T p);   
        T Getir(int id);      
    }
}