using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.DIP.BAD
{
   public  class BadRestaurant // bu sınıftan instance alınca bu sınıfın bir tarif uretmesını ıstıyoruz.
        //hangi yemegı yapacagını bilmiyoruz....
       
    {
        //Restaurant sınıfı high level bir modüldür.(Restaurant modulu içerisinde başka modullerı kullanabılecektır.)Yanlız low-level modullerden başka sınıflara bagımlılıgı vardır.
        BadFish tuna = new BadFish();
        BadPoultry ordek = new BadPoultry();
        //Restaurant'ı  yukarıdakı 2 tipe bagımlı hale getirdik.
        //baska bir tip geldigi anda Open closed pressibimi de bozuyoruz...

        public string GenareteInstructions()
        {
            return tuna.GetFishCookingInstructions() + "" + ordek.GetPoultryCookingInstructions();
        }
    }
}
