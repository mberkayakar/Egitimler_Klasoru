using AKAR.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AKAR.WebUI.Controllers
{
    public class ProductController:Controller
    {

        //public string Index()
        //{
        //    return "AKAR YAZILIM";
        //}

        public IActionResult Index()
        {
            List<Employee>list = new List<Employee>() {
            new Employee { ID = 1 , ISIM = "Berkay" , SOYISIM = "Akar"},
            new Employee { ID = 2 , ISIM = "Ahmet" , SOYISIM = "Dertli"},
            new Employee { ID = 3 , ISIM = "Mehmet" , SOYISIM = "Akar"},
            new Employee { ID = 4 , ISIM = "Hasan" , SOYISIM = "Çapa"},

            };
            return View("index_product",list);
        }

        
        //public string Detail(string id)
        //{
        //    return "Product/detail/"+id;
        //}
        
    }
}
