using ConsoleSOLIDPrinciples.OCP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.OCP.Validated.Concrete
{
    public class Americano : GoodCoffe
    {
        //Mecburi olarak implement etmesı gereken bır metodu olacak.
        public Americano(double price):base(price)
        {

        }

        public override double GetTotalPrice(double amount)
        {
            return amount * Price;
        }
        public override string ToString()
        {
            return $"Americano nesnesi yaratıldı";
        }
    }
}
