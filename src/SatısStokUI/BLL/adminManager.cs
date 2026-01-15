    using SatisStokUI.DAL;
using SatisStokUI.Domain;

namespace SatisStokUI.BLL
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