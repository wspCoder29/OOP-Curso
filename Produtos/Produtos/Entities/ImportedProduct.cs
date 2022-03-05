using System;
using System.Globalization;

namespace Produtos.Entities
{
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }


        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            string str = "";
            str += Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ "+CustomsFee+")";
            return str;
        }



        public double TotalPrice()
        {
            double totalPrice = Price+CustomsFee;
            return totalPrice;
        }


        public override string ToString()
        {
            string str = "";
            str += "Name: " + Name + Environment.NewLine;
            str += "Price: " + Price + Environment.NewLine;
            str += "Customs Fee: " + CustomsFee;
            return str;
        }







    }
}
