using System;
using System.Globalization;

namespace Produtos.Entities
{
    class Product
    {


        public string Name { get; protected set; }

        public double Price { get; protected set; }


        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }



        public virtual string PriceTag()
        {
            string str = "";
            str += Name + " $ " + Price.ToString("F2",CultureInfo.InvariantCulture);
            return str;
        }




        public override string ToString()
        {
            string str = "";
            str += "Name: " + Name + Environment.NewLine;
            str += "Price: " + Price + Environment.NewLine;
            return str;
        }









    }
}
