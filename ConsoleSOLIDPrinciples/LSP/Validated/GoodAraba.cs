using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.LSP.Validated
{
  public abstract  class GoodAraba
    {//gene bir base class'ımız olacak ama Klima ozelligimiz interface olarak acılacak ve klima ozellıgıne sahıp olan arabalara miras verecek
        public string Calistir()
        {
            return "Araba çalıştırıldı";
        }
    }
}
