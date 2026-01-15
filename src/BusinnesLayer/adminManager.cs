using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class AdminManager
    {
        AdminDal dal = new AdminDal();

        public Admin GirisYap(string kadi, string sifre)
        {
            return dal.GirisYap(kadi, sifre);
        }
    }
}