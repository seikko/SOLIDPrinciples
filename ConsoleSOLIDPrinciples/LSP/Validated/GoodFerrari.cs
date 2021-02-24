using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.LSP.Validated
{
    public class GoodFerrari : GoodAraba, IKlima
    {
        //Artık ferrari arabamız hem GoodArabadan miras alıcak hemde IKlimada miras alıcak ve gorevını yapacak.
        public string KlimaAc()
        {
            return "Klima açıldı";
        }
    }
}
