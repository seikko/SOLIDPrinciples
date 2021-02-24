using ConsoleSOLIDPrinciples.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.DIP.Validated.Concrete
{
    public class Chicken : IProduct
    {
        public string GettCookingInstructions()
        {
            return "Tavuk pişir.";
        }
    }
}
