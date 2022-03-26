using EfCore.Context;
using EfCore.Entities;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
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
            //using (var context = new SQLİTECONTEXT())
            //{

            //}
        }


        static void ProductKaydet(string isim, int fiyat)
        {
            //using (var context = new SQLİTECONTEXT())
            //{
            //    var p = new Product { Name = isim , Price = fiyat };

            //    context.Products.Add(p);
            //    context.SaveChanges();
            //    Console.WriteLine("İşlem başarılı");

            //        ProductGetir();
            //}
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

            #region MyRegion


            //using (var context = new SQLİTECONTEXT())
            //{
            //    #region LİSTEYİ DB YE KAYDETTİRME 

            //    //List<Product> productlistesi = new List<Product>() {

            //    //    new Product { Name = "samsung s6", Price = 2500 },
            //    //    new Product { Name = "samsung s7", Price = 3500 },
            //    //    new Product { Name = "samsung s8", Price = 4500 },
            //    //};



            //    //context.Products.AddRange(produclistesi);
            //    //context.SaveChanges();
            //    //Console.WriteLine("İşlem başarılı");

            //    #endregion

            //    #region Tekli ÜRÜN KAYDI


            //    //var produclistesi = new Product { Name = "AKAR", Price = 1 };

            //    //context.Products.Add(produclistesi);
            //    //context.SaveChanges();
            //    //Console.WriteLine("İşlem başarılı");


            //    #endregion

            //    #region Veritananından Veri Çekme 

            //    //var tablo = context.Products.ToList();
            //    //Console.WriteLine("ÜRÜNLER TABLOSU :");

            //    //foreach (var item in tablo)
            //    //{
            //    //    Console.WriteLine("ID : "+item.ID + "  İSİM :"+item.Name+"  FİYAT : "+item.Price);
            //    //}


            //    #endregion



            //}


            #region İSTENİLEN KOLONLARI SEÇME 

            // select isim , soyisim from employeess gibi düşünebilirsin

            //using (var context = new SQLİTECONTEXT())
            //{
            //    var degerler = context.Products.
            //        Select( x=> new { x.ID , x.Name }).ToList();


            //    foreach (var item in degerler)
            //    {
            //        Console.WriteLine(item.ID +"   -  --- "+ item.Name );
            //    }
            //    Console.WriteLine();
            //}

            #region Tek kolon seçiminde Select in içerisinde anonymous tip açman gerekmez

            //using (var context = new SQLİTECONTEXT())
            //{
            //    var degerler = context.Products.
            //        Select(x => x.Price).ToList();


            //    foreach (var item in degerler)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region İD Bilgisi İLe ürün çekme


            // select * from employeess wehere id = @id gibi düşünebilirsin




            //using (var context = new SQLİTECONTEXT())
            //{
            //    var tablo = context.Products.
            //        Select(p => new { KİMLİK_NO = p.ID, URUN_ADİ = p.Name, FİYAT = p.Price })
            //        .Where(f => f.FİYAT > 500 && f.FİYAT<4000 );



            //    Console.WriteLine(" 500 ile 4000 arasında olan ürünler :");
            //    foreach (var item in tablo)
            //    {
            //        Console.WriteLine(item.URUN_ADİ  + "    " + item.KİMLİK_NO + "    " + item.FİYAT);
            //    }

            //}




            //using (var context = new SQLİTECONTEXT())
            //{
            //    var ürün = context.Products.Where(X => X.ID == 1 ).FirstOrDefault();
            //    Console.WriteLine(ürün.ID + "   " + ürün.Name + "   " + ürün.Price);

            //    var ürün2 = context.Products.FirstOrDefault(x=>x.ID==1);
            //    Console.WriteLine(ürün2.ID + "   " + ürün2.Name + "   " + ürün2.Price);
            //    Console.ReadLine();
            //    // tek bir ürün çektiğimizden ötürü buna gerek yok

            //}

            #endregion

            #endregion

            #region Dışarıdan girilen ürüne göre isim filtreleme sorgusu : 

            void getbylikename(string isim)
            {
                using (var context = new SQLİTECONTEXT())
                {
                    var tablo = context.Products.Where(x => x.Name.Contains(isim)).ToList();
                    Console.WriteLine();
                    Console.WriteLine(isim + " İsmine ait toplam :" + tablo.Count + " adet veri listelenmiştir ");

                    foreach (var item in tablo)
                    {
                        Console.WriteLine(item.ID + "   " + item.Name + "    " + item.Price);
                    }


                }

            }


            void GetAll()
            {
                using (var context = new SQLİTECONTEXT())
                {
                    foreach (var item in context.Products.ToList())
                    {
                        Console.WriteLine(item.ID + "    " + item.Name + "     " + item.Price);
                    }
                }
            }





            //GetAll();
            //Console.WriteLine();
            //Console.WriteLine("Lütfen bir ürün ismi giriniz ");
            //getbylikename(Console.ReadLine());


            #endregion

            /*     Veri Güncelleme :     */

            #region VERİLERİ GÜNCELLEME İŞLEMİ 

            //using (var context = new SQLİTECONTEXT())
            //{
            //    var table = context.Products.Where(x => x.ID == 5).FirstOrDefault();
            //    if (table!= null)
            //    {
            //        Console.WriteLine(" 5 numaralı ürününüz bulundu ");
            //        Console.WriteLine(table.ID + "   " + table.Name + "   " + table.Price);
            //        Console.WriteLine();
            //        Console.WriteLine("Değiştirmek istediğiniz bilgieri giriniz : ");
            //        Console.WriteLine("fiyat : ");
            //        table.Price = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("İsim : ");
            //        table.Name= Console.ReadLine();

            //        context.Products.Update(table);
            //        context.SaveChanges();
            //        Console.WriteLine("islem başarili ");
            //        var table2 = context.Products.Where(x => x.ID == 5).FirstOrDefault();
            //        Console.WriteLine(table2.ID + "   " + table2.Name + "   " + table2.Price);


            //    }


            //}


            //using (var context = new SQLİTECONTEXT())
            //{
            //    var table = context.Products.Where(x => x.ID == 5).FirstOrDefault();
            //    if (table != null)
            //    {
            //        Console.WriteLine(" 5 numaralı ürününüz bulundu ");
            //        Console.WriteLine(table.ID + "   " + table.Name + "   " + table.Price);
            //        Console.WriteLine();
            //        Console.WriteLine("Değiştirmek istediğiniz bilgieri giriniz : ");
            //        Product p = new Product();
            //        p.ID = 5;
            //        Console.WriteLine("fiyat : ");
            //        p.Price = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("İsim : ");
            //        p.Name = Console.ReadLine();

            //        context.Products.Update(p);
            //        context.SaveChanges();
            //        Console.WriteLine("islem başarili ");
            //        var table2 = context.Products.Where(x => x.ID == 5).FirstOrDefault();
            //        Console.WriteLine(table2.ID + "   " + table2.Name + "   " + table2.Price);


            //    }


            //}


            #endregion
            //var table = context.Products.AsNoTracking().Where(x => x.ID == 5).FirstOrDefault();
            //Console.WriteLine(table.ID + "   " + table.Name + "    " + table.Price);
            //if (table!=null)
            //{
            //    table.Price = 90;
            //    table.Name = "90";
            //    context.SaveChanges();
            //    Console.WriteLine("Güncelleme Kaydedildi ... ");
            //}


            //var entity = new Product();
            //entity.ID = 5;

            //context.Products.Attach(entity);
            //entity.Price = 999;
            //entity.Name = "AKAR ";
            //context.SaveChanges();


            //var table = context.Products.AsNoTracking().Where(x => x.ID == 5).FirstOrDefault();
            //Console.WriteLine(table.ID + "   " + table.Name + "    " + table.Price);

            #region ÜRÜN SİLME :

            // Silme süreci için bir adet method yazalım

            //void deletebyid (int id )
            //{
            //    using (var context = new SQLİTECONTEXT())
            //    {
            //        var data = context.Products.Where(x => x.ID == id).FirstOrDefault();
            //        if (data!=null)
            //        {

            //            context.Products.Remove(data);
            //            context.SaveChanges();
            //        }
            //    }

            //}


            #region program

            //Console.WriteLine("Hoşgeldiniz");
            //Console.WriteLine();
            //GetAll();
            //Console.WriteLine();
            //Console.WriteLine("Lütfen silmek istediğiniz id yi giriniz");
            //deletebyid(Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("İşlem Başarılı");
            //Thread.Sleep(1000);
            //Console.Clear();
            //GetAll();


            #endregion

            //    GetAll();

            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();


            //    using (var context2 = new SQLİTECONTEXT())
            //    {
            //        var p = new Product() { ID = 2};
            //        //context2.Entry(p).State = EntityState.Deleted;

            //        context2.Products.Remove(p);
            //        context2.SaveChanges();


            //    }


            //    #endregion



            //    Console.ReadLine();
            //}

            #endregion

            #endregion

            #region İlişkili Tablolardan İş süreçleri 1-n ilişki 

        //    void GetAllUser()
        //    {
        //        using (var context = new SQLİTECONTEXT())
        //        {
        //            var userlist = context.Users.ToList();
        //            foreach (var item in userlist)
        //            {
        //                Console.WriteLine(item.ID + "    " + item.Username + "    " + item.Email + "   ");
        //            }
        //            Console.WriteLine("\n \n " + "Toplam " + userlist.Count + " Adet Kullanıcı Listelenmiştir");
        //            context.SaveChanges();
        //        }
        //    }

        //    void AddUser(User user)
        //    {
        //        using (var context = new SQLİTECONTEXT())
        //        {
        //            context.Users.Add(user);
        //            context.SaveChanges();
        //            Console.WriteLine("Kayıt Başarılı ");
        //            Thread.Sleep(1000);
        //            Console.Clear();
        //        }

        //        GetAllUser();
        //    }

        //    void getuserbyusername(string username)
        //    {
        //        using (var context = new SQLİTECONTEXT())
        //        {
        //            var insanlar = context.Users.Where(x => x.Username.Contains(username)).ToList();
        //            foreach (var item in insanlar)
        //            {
        //                Console.WriteLine(item.ID + " - " + item.Username + "   " + item.Email);
        //            }
        //            Console.WriteLine("\n\n");

        //        }
        //    }

        //    void user_detail_by_id(int id)
        //    {
        //        using (var context = new SQLİTECONTEXT())
        //        {




        //            var tablo = context.Users.Include(x => x.Adresses).FirstOrDefault(p => p.ID == id);
        //            var adresses = context.Adresses.Include(a => a.User).FirstOrDefault(a => a.UserId == id);

        //            List<Adress> adresler = new();
        //            //adresler.Add(new()
        //            //{
        //            //    Fullname = "Abc",
        //            //    Title = "Abc",
        //            //    Body = "Abc",
        //            //    User = tablo
        //            //});

        //            List<User> users = new();
        //            users.Add(new()
        //            {
        //                Adresses = new List<Adress>()
        //                {
        //                    new Adress{ UserId = 3, Title = "A",Fullname = "B", Body = "C"}
        //                }
        //            });

        //            // context.Adresses.AddRange(adresler);
        //            context.Users.AddRange(users);
        //            context.SaveChanges();
        //            /*                   
        //             EMPLOYEE - ORDERS - order details (PRODUCT)
        //            */

        //            if (tablo != null)
        //            {
        //                Console.WriteLine(" Kullanıcı Bilgileri : ");
        //                Console.WriteLine("  ");
        //                Console.WriteLine(tablo.ID + "  " + tablo.Username + "   " + tablo.Email);
        //                Console.WriteLine();
        //                Console.WriteLine("Adresler : ");
        //                Console.WriteLine();

        //                foreach (var item in tablo.Adresses)
        //                {
        //                    Console.WriteLine(String.Format(item.ID + "    " + item.Body + "    " + item.Fullname));
        //                }


        //                Console.ReadLine();


        //            }


        //        }
        //    }


        //    GetAllUser();

        //basa:
        //    Console.WriteLine("\n\n\n\n");
        //    Console.WriteLine("\n\n Bir İşlem seçiniz \n\n 1.) Kullanıcı Ekleme 2.) Kullanıcı Görüntüleme 3.) Boş Adres Ekleme 4.) Bir kullanıcıya adres ekleme");

        //    var A = Console.ReadLine();
        //    if (A == "1")
        //    {
        //        User user = new User();
        //        Console.WriteLine("Lütfen Kullanıcı Adı Giriniz");
        //        user.Username = Console.ReadLine().Trim().ToLower();
        //        Console.WriteLine("Lütfen Kullanıcı için E Posta Girişi yapınız");
        //        user.Email = Console.ReadLine().Trim().ToLower();



        //        if (user.Username != "" && user.Email != "")
        //        {
        //            AddUser(user);
        //            Console.WriteLine("Başka Bir işlem Yapmak İstermisiniz ? ");
        //            if (Console.ReadLine() == "EVET")
        //            {
        //                goto basa;
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }

        //    }
        //    else if (A == "2")
        //    {
        //        GetAllUser();
        //        Console.WriteLine("\n\n\n");
        //        Console.WriteLine("Lütfen Bir id giriniz ");
        //        user_detail_by_id(Convert.ToInt32(Console.ReadLine()));


        //    }




            #endregion

            #region 1-1 İlişki

            var context = new SQLİTECONTEXT();
            
                User user = new User();
                user.Username= "1-1 2";
                user.Email = "AKARMUHAMMEDBERKAY@GMAİL.COM";

                context.Users.Add(user);
                context.SaveChanges();

                Console.WriteLine("Böyle bir kayıt oluşturuldu ");


            
                 Customers c = new Customers();
                 c.Identitynumber = "salim";
                 c.soyisim = user.Username;
                 c.isim = "salim";
                 c.user = user;
 

                  context.customers.Add(c);


           
                 context.SaveChanges();





            #endregion
        }
    }
}

