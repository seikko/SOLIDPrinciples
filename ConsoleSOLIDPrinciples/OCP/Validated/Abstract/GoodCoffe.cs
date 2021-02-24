using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.OCP.Validated.Abstract
{
   public abstract class GoodCoffe
    {
        //Abstract öge bir abstract sınıf ıcerısınde olabılır.
        
        public string Name { get; set; }
        public double Price { get; set; }
        public abstract double GetTotalPrice(double amount);
        public GoodCoffe(double price)
        {
            Price = price;
        }
    }
}
