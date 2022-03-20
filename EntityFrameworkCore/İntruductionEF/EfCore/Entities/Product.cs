using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entities
{
    public class Product
    {

        // Primary Key 
        // ID Otomatik olarak Primary key olarak tanımlanır.
        // ProductID yi de primary key olarak tanımlamaktadır.
        // fakat ürün id gibi bir isimlendirmede Entity framework bunu Primary key olarak algılamaz
        // bu sebepten ötürü Data Annodation kullanılır .

        // [Key]

        public int ID { get; set; }
         
        // [MaxLength(100)]  // maksimum 100 karakter alabileceğini belirler 
        public string Name { get; set; } // NVARCHAR MAX OLARAK DEFAULTTA ALIR. eger data annodation konmaz ise 

        // bir alanın null geçilemez olmasını istiyorsan [Required] koyman gerekir.

        public decimal Price { get; set; }


    }
}
