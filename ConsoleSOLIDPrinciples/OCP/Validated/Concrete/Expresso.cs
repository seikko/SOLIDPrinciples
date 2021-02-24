using ConsoleSOLIDPrinciples.OCP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.OCP.Validated.Concrete
{
    public class Expresso : GoodCoffe
    {
        public Expresso(double price) : base(price)
        {

        }
        public override double GetTotalPrice(double amount)
        {
            return amount * Price;
        }
        public override string ToString()
        {
            return $"Expresso nesnesi yaratıldı";
        }
    }
}
