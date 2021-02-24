using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.ISP.BAD
{
    public class BadHawk : IBird
    {
        public string Fly()
        {
            return "Bu şahin uçabilir";
        }

        public string Walk()
        {
            return "Bu şahin yürüyebilir";
        }
    }
}
