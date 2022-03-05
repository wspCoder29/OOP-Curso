using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Entities
{
    class UsedProduct : Product
    {

        public DateTime Date { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime dt) : base(name, price)
        {
            // strDate = strDate.Trim().Replace("/", " ");
            // DateTime dt = DateTime.Parse(strDate);
            Date = dt;
        }




        public override string PriceTag()
        {
            string str = "";
            str += Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) +
                " Manufacture date: " + Date.Day + "/" + Date.Month + "/" + Date.Year;
            return str;
        }




        public override string ToString()
        {
            string str = "";
            str += "Name: " + Name + Environment.NewLine;
            str += "Price: " + Price.ToString("F2", CultureInfo.InvariantCulture) + Environment.NewLine;
            str += "Manufacture Date (DD/MM/YYYY): " + Date.Day + "/" + Date.Month + "/" + Date.Year + Environment.NewLine;
            return str;
        }











    }
}
