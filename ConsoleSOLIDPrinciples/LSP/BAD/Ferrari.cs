using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.LSP.BAD
{
    public class Ferrari : Araba
    {
        public override string KlimaCalistir()
        {
            return "Klima açıldı";
        }
    }
}
