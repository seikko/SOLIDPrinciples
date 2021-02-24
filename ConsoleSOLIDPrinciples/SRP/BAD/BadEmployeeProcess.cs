using ConsoleSOLIDPrinciples.SRP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleSOLIDPrinciples.SRP.BAD
{
    public class BadEmployeeProcess
    {
        //***Yanlış Olan Yol!!!!!

        //Alttaki işlemlere bakacak olursanız sınıf içerisinde calısan ekleme kodu olmasına rağmen birden fazla iş yapıldıgını göreceksiniz. Hem ekleme hemde log işlemleri bir anda yapılmaktadır. Dolayısıyla alttaki kod Single Responsibility prensibimize ters düşer..

        //Alttaki yöntemde çıkacak sorun Loglama ile ilgili bir sürec degiştiğinde (farklı bir dosya loglama yapılabilir , farklı bir loglama teknolojisi istenebilir) Ekleme kodlarını da barındıran sınıfın içeriniğine müdahale etmek gerekir..
        //bu durum projenin genişletebilirligini engeller. Adeptasyon yetenegini kısıtlar.
        //Bunun yanında tamamen SRP üzerinden gidersek, konsola yazma işlemide bu sınıfta yer almamalıdır. Platform değişiklikleri veya kullanıcı bilgilendirme işlemlerinde yaşanacak değişiklikler aynı şekilde sınıfın çalışmasını bozacaktır..

        public void InsertEmploye(Employee newEmployee)
        {
            //StringBuilder sınıfı metinsel cumlenizi belirli kurallarla kuran ve en son size string çıktı sunabilen bir metot saglayan bir tiptir. Normal string kullanımlarına gore biraz daha performanslıdır.
            StringBuilder sb = new StringBuilder();
            try
            {//Dosya olusturmak ve içine yazdırmak
                sb.Append(newEmployee.ID);
                sb.AppendLine(); //bir satır bosluk bırak
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);
                File.WriteAllText(@"E:\EmployeeDataSRPBad.txt", sb.ToString());

                //Log
                sb = new StringBuilder();
                sb.Append("Kayıt ekleme tarihi : ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append(newEmployee.FirstName).Append(" ");
                sb.Append(newEmployee.LastName);
                File.WriteAllText(@"E:\EmployeeLog.txt", sb.ToString());
                Console.WriteLine("Çalışan başarı ile eklendi");
            }
            catch (Exception ex)
            {

                sb = new StringBuilder();
                sb.Append("Hata tarihi : ");
                sb.AppendLine();

                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata mesajı");
                sb.AppendLine();
                sb.Append(ex.Message);
                File.WriteAllText(@"E\EmployeeHataLog.txt", sb.ToString());
                Console.WriteLine("Hata ile karşılaşıldı");
            }

        }

    }
}
