using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.OCP.BAD
{
    //burada türk kahvesi eklenmek istenirse enum'a eklemek gerekecek ve gidip hesaplamaya (swicht case) e de eklemek gerekicek burası kötü Yazım Kod'dur.
    public enum CoffeeType
    {
        Latte,
        Expresso,
        Macchiato
    }
    public class BadCoffee
    {
        public double GetTotalPrice(double amount,CoffeeType coffeeType)
        {
            double totalPrice = 0;
            switch (coffeeType)
            {
                case CoffeeType.Latte:
                    totalPrice = amount * 4.30;
                    break;
                case CoffeeType.Expresso:
                    totalPrice = amount * 5.50;
                    break;
                case CoffeeType.Macchiato:
                    totalPrice = amount * 6.30;
                    break;
                default:
                    break;
            }
            return totalPrice;
        }
    }
}
