using System.Collections.Generic;

namespace EfCore.Entities
{
    public class User
    {
        // bir kullanıcının birden fazla adresi olabilmektedir. 
        public int ID { get; set; }
        public string Username{ get; set; }
        public string Email { get; set; }

        public Customers customers { get; set; }
        public Supplier Supplier { get; set; }

        public  List<Adress> Adresses { get; set; }
    }
}
