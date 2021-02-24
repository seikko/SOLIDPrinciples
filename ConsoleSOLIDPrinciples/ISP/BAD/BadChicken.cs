using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.ISP.BAD
{
    public class BadChicken : IBird
    {
        public string Fly()
        {
            return "Uçamaz";
            //bunu uçamaz demek için metod implement ettim burada. Bu mantıklı Metod uygulanmıyor dıye bır yazı donduremeyiz.
        }

        public string Walk()
        {
            return "Yürür";
        }
    }
}
