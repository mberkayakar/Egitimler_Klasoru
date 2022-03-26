using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entities
{
    public class Customers
    {
        public int ID { get; set; }
        public string Identitynumber { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public User user { get; set; }
        public int UserId { get; set; }


    }
}
