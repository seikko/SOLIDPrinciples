using ConsoleSOLIDPrinciples.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.DIP.Validated.Concrete
{
    public class Restaurant
    {
        //bu versiyonda restaurant sınıfı alt seviye modullerden bagımsız bir hale gelecektir.Kendisine ne geliyorsa Ona gore bir işlem gerçekleştirecektir.
        List<IProduct> _products;
        public Restaurant(List<IProduct> product)
        {
            //Tightly coupled(sıkı sıkıya bagılmı olan bir yapıyı) coupled bir yapıya cevirmek (gevsek bagımlılıga) Dependency Injection tasarım paternini (constructor based injection) kullandık.
            _products = product;
        }
        public string GenerateInsturctions()
        {
            string instructions = null;
            foreach (IProduct item in _products)
            {
                instructions += item.GettCookingInstructions();
            }

            return instructions;
        }
    }
}
