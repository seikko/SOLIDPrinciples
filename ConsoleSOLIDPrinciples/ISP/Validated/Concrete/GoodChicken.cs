using ConsoleSOLIDPrinciples.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.ISP.Validated.Concrete
{
    public class GoodChicken : IFlylessBird
    {
        public string Walk()
        {
            return "Yürür";
        }
    }
}
