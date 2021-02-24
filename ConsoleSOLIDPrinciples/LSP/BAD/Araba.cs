using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.LSP.BAD
{
   public abstract class Araba
    {
        //miras verdigim dıger sınıfların hepsınde klima ozelligi olan arac yoktur.
        public string Calistir()
        {
            return "Araba çalışıyor";
        }
        public abstract string KlimaCalistir();
       
    }
}
