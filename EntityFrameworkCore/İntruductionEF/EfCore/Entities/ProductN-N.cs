using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entities
{
    public class ProductN_N
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public decimal Price  { get; set; }
        public List<ProductCategoryN_N> CategoryN_Ns { get; set; }

    }
}
