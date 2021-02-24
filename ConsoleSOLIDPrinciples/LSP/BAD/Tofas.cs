using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.LSP.BAD
{
    public class Tofas : Araba
    {
        //Burada tofaş arabasında  klima yok ama arabadan miras almam gerekiyor.
        public override string KlimaCalistir()
        {
            throw new NotImplementedException();
        }
    }
}
