using ConsoleSOLIDPrinciples.DIP.Validated.Abstract;
using ConsoleSOLIDPrinciples.DIP.Validated.Concrete;
using ConsoleSOLIDPrinciples.LSP.BAD;
using ConsoleSOLIDPrinciples.LSP.Validated;
using ConsoleSOLIDPrinciples.OCP.Validated.Abstract;
using ConsoleSOLIDPrinciples.OCP.Validated.Concrete;
using ConsoleSOLIDPrinciples.SRP.Models;
using ConsoleSOLIDPrinciples.SRP.Validated;
using System;
using System.Collections.Generic;

namespace ConsoleSOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID Pensipleri => SOLID, beş önemli OOP gelişmiş prensiplerinin kısaltmasıdır.
            //Temiz modüler ve genişletebilir kod yazımında önemli kurallar vardır.
            //Aynı zamanda Agile/Adaptive yazılım geliştirme icin gereklidir.
            //Klasörlerin içine bakarsanız ilk önce kötü olan kodu yazıp sonra Prensiblere uyan kodları yazdık...

            #region Single Responsibility
            //(SRP)=> Singel Responsibility Principle bir sınıf sadece bir sorumluluga sahip olmalıdır.

            //Employee emp = new Employee();
            //emp.ID = 1;
            //emp.FirstName = "Serkan";
            //emp.LastName = "Akçay";
            //emp.HireDate = new DateTime(1996, 1,1);
            //GoodEmployeeProcess proc = new GoodEmployeeProcess();
            //Console.WriteLine(proc.InsertEmployee(emp) ? "Ekleme başarılı" : "Ekleme sırasında bir hata meydana geldi");


            #endregion
            //-----------------------------------------------------------------------
            #region Open Closed Principle
            //Sınıflar ve metodlar genişletilmeye açık, değişiklige kapalı olmalıdır.(Kaynak kod değişimine kapalı olmalıdır.)
            //Her ihtiyaç değiştiğinde yazdıgınız kodu kökten değiştirmek zorunda kalmamalıyız.
            //GoodCoffe kahve1 = new Americano(5.45);
            //GoodCoffe kahve2 = new Expresso(7.45);
            //GoodCoffe kahve3 = new Macchiato(3.5);

            //Console.WriteLine($"Expresso fiyatı {kahve2.GetTotalPrice(2)}");

            ////Bu sayede artık swichtcase ile işimiz olmuyor if ile de işimiz kalmıyor..
            #endregion

            //-----------------------------------------------------------------------
            #region Liskov Substitution LSP ihlali


            //Klima ozelligi burada toplanmamalı. her arabada klima yok.
            //o yuzden if if if yazıyoruz  bu yüzden program cs hata fırlatıcaktır. cunku tofaş un klima gorevi boş NotImplementException oldugu icin 
            //List<Araba> arabalar = new List<Araba>() { new Tofas(), new Ferrari() };
            //foreach (Araba item in arabalar)
            //{
            //    //Tofaş bir araba yerine geçemiyor LSP ye uymuyor cunku gorevi implement etmemiş etmiyecek te.
            //    if (item is Tofas) //boyle calısır ama bu efektif degil. sadece Anı kurtartır. Her arabada klima var diyemez..
            //    {
            //        continue;//bu sekılde calısır burayı yorum satırına alırsak NotImplementException fırlatıcaktır...
            //    }
            //    item.KlimaCalistir();
            //}
            #endregion
            //----------------------------------------------------------------------
            #region Liskov Substitution Good Code

            //List<IKlima> klimalıArabalar = new List<IKlima>
            //{//burada artık klimalı arabalara tofaş ı ekleyemem.. Yerine geçme prensibinde kurulan hiyerarşi düzgün kurulmalıdır.
            //    new GoodFerrari(),new Lamborghini()
            //};
            //foreach (IKlima item in klimalıArabalar)
            //{
            //   Console.WriteLine(item.KlimaAc());
            //}
            //List<GoodAraba> arabalar = new List<GoodAraba>() { new Lamborghini(), new GoodTofas(), new GoodFerrari() };

            //foreach (GoodAraba item in arabalar)
            //{//Burada item'in Klima aç metodu olmadığı için gelmeyecektir.
            //    Console.WriteLine(item.Calistir());

            //}


            #endregion
            //----------------------------------------------------------------------
            #region Interface Segregation Principle
            //Butun ayrı metodları tek bir interface'e toplamamalısınız.
            /*
              Haliyle bir sınıfın implement ettiği bir Interface zorunlu şekilde ilgili sınıfa uygulanmaktadır. Hal böyleyken söz konusu Interface yetersiz ya da fazla geliyorsa, o sınıfı dağıtmak yerine yeni bir Interface oluşturmak daha makbuldür. İşte, ISP’nin de ortaya koyduğu mantık budur.
             */


            #endregion

//---------------------------------------------------------------------------------

            #region Dependency Injection
            //Tightly coupled(sıkı sıkıya bagılmı olan bir yapıyı) coupled bir yapıya cevirmek (gevsek bagımlılıga) Dependency Injection tasarım paternini (constructor based injection) kullanacagız.
            List<IProduct> urunler = new List<IProduct>() { 
            
                new Poultry(),new Chicken(),new Fish(),new Meat()
            
                //bu sayede buraya gelen yeni bir sınıf oldugunda Sadece IProduct'dan mıras alıp implement edip gorevini vermemiz yeterlidir
            };
            Restaurant r = new Restaurant(urunler);
            Console.WriteLine(r.GenerateInsturctions());
            #endregion


            Console.ReadLine();
        }
    }
}
