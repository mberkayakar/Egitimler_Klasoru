using EfCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Context
{
    public class SQLİTECONTEXT : DbContext
    {

        // ahngi provider ile çalışılacağını belirlememiz lazım

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // sqlite bir server olmayıp database dosyası olduğundan dolayı Data Soruce kısmını tanımlamamız yeterlidir 
        //    optionsBuilder.UseSqlite("Data Source= BerkayAKAR");
        //}

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // sqlite bir server olmayıp database dosyası olduğundan dolayı Data Soruce kısmını tanımlamamız yeterlidir 
            optionsBuilder.UseLoggerFactory(loggerFactory).
                UseSqlServer("Integrated Security=true;Initial Catalog=Northwind;server=.;");
        }





        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Adress> Adresses { get; set; }



        public DbSet<User> Users { get; set; }
        public DbSet<Customers> customers{ get; set; }
        public DbSet<Supplier> Suppliers { get; set; }








        public DbSet<deneme> deneme { get; set; }
    







    }
}
