using ConsoleSOLIDPrinciples.OCP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.OCP.Validated.Concrete
{
    public class Macchiato : GoodCoffe
    {
        public Macchiato(double price):base(price)
        {

        }
        public override double GetTotalPrice(double amount)
        {
            return amount * Price;
        }
        public override string ToString()
        {
            return $"Macchiato nesnesi yaratıldı";
        }
    }
}
