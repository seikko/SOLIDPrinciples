using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.LSP.Validated
{
    public class Lamborghini : GoodAraba, IKlima
    {
        public string KlimaAc()
        {
            return "Havamı atar klimamı açarım :)";
        }
    }
}
