using ConsoleSOLIDPrinciples.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.DIP.Validated.Concrete
{
    public class Fish : IProduct
    {
        public string GettCookingInstructions()
        {
            return "Balık pişir";
        }
    }
}
