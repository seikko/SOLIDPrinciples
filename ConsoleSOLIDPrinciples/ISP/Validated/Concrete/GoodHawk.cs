using ConsoleSOLIDPrinciples.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.ISP.Validated.Concrete
{
    public class GoodHawk : IFlyingBird, IFlylessBird
    {
        public string Fly()
        {
            return "Uçar";
        }

        public string Walk()
        {
            return "Yürür";
        }
    }
}
