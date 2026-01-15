using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Admin : BaseEntity
    {
        public string Username { get; set; } // Veritabanındaki sütun adınla aynı olsun
        public string Password { get; set; }
        public string Role { get; set; }
    }
}