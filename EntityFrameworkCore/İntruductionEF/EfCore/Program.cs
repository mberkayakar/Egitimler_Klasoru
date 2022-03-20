using EfCore.Context;
using EfCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EfCore
{
    public class Program
    {

        static void ProductGetir()
        {
            using (var context = new SQLİTECONTEXT())
            {
 
            }
        }


        static void ProductKaydet(string isim , int fiyat )
        {
            using (var context = new SQLİTECONTEXT())
            {
                var p = new Product { Name = isim , Price = fiyat };
            
                context.Products.Add(p);
                context.SaveChanges();
                Console.WriteLine("İşlem başarılı");

                    ProductGetir();
            }
        }


        static void Main(string[] args)
        {

            #region MyRegion


            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Clear();

            //basa:


            //Console.WriteLine("ENTİTY FRAMEWOK KÜTÜPHANE DENEMESİ : ");
            //Console.WriteLine("\n \n \n");

            //Console.WriteLine("Tablolar için seçim yapınız \n \n 1.) Product  \n \n 2.)Category");
            //Console.WriteLine("\n seçiminizi yapınız ");
            //string girdi = Console.ReadLine();
            //if (int.TryParse(girdi ,out int girdisayi ) )
            //{
            //    if (girdisayi == 1 )
            //    {
            //        Console.WriteLine("Lütfen ürün ismini giriniz");
            //        string isim = Console.ReadLine();


            //        Console.WriteLine("Lütfen ürün Fiyatını giriniz");
            //        int fiyat = int.Parse(Console.ReadLine());

            //        ProductKaydet(isim,fiyat);


            //    }
            //    else if (girdisayi == 2)
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı bir giriş yaptınız lütfen 1 veya 2 yi seçiniz ");
            //        Thread.Sleep(2000);
            //        Console.Clear();
            //        goto basa;

            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bir giriş yaptınız tekrar deneyiniz" );
            //    Thread.Sleep(2000);
            //    Console.Clear();

            //    goto basa;
            //}

            #endregion



            using (var context = new SQLİTECONTEXT())
            {
                #region LİSTEYİ DB YE KAYDETTİRME 

                //List<Product> productlistesi = new List<Product>() {

                //    new Product { Name = "samsung s6", Price = 2500 },
                //    new Product { Name = "samsung s7", Price = 3500 },
                //    new Product { Name = "samsung s8", Price = 4500 },
                //};



                //context.Products.AddRange(produclistesi);
                //context.SaveChanges();
                //Console.WriteLine("İşlem başarılı");

                #endregion

                #region Tekli ÜRÜN KAYDI


                //var produclistesi = new Product { Name = "AKAR", Price = 1 };

                //context.Products.Add(produclistesi);
                //context.SaveChanges();
                //Console.WriteLine("İşlem başarılı");


                #endregion

                #region Veritananından Veri Çekme 

                var tablo = context.Products.ToList();
                Console.WriteLine("ÜRÜNLER TABLOSU :");

                foreach (var item in tablo)
                {
                    Console.WriteLine("ID : "+item.ID + "  İSİM :"+item.Name+"  FİYAT : "+item.Price);
                }

                #endregion



            }


        }
    }
}
