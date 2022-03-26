using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entities
{
    public class ProductCategoryN_N
    {

        public CategoryN_N Category { get; set; }
        public CategoryN_N CategoryID { get; set; }

        public ProductN_N Product { get; set; }
        public ProductN_N ProductId { get; set; }


    }
}
