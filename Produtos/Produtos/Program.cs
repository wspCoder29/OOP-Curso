using System;
using System.Collections.Generic;
using System.Globalization;
using Produtos.Entities;


namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> li = new List<Product>();
            string Name = null;
            double Price = 0;
            double CustomsFee = 0;
            DateTime dateTime;

            char inputChar = '1';
            int totalProducts = 1;

            Console.Write("Enter the number of products: ");
            totalProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalProducts; i++)
            {
                Console.WriteLine("Product #{0} data:", i);
                Console.Write("Common, used or imported (c/u/i)? ");
                inputChar = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                Name = Console.ReadLine();
                Console.Write("Price $: ");
                Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (inputChar == 'c')
                {
                    li.Add(new Product(Name, Price));
                }

                else if (inputChar == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY) ");
                    dateTime = DateTime.Parse(Console.ReadLine());
                    li.Add(new UsedProduct(Name, Price, dateTime));
                }
                else if (inputChar == 'i')
                {
                    Console.Write("Customs fee: ");
                    CustomsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    li.Add(new ImportedProduct(Name, Price, CustomsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine(String.Join(" ", li));

            Console.WriteLine();
            Console.WriteLine("Price TAGS:");
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i].PriceTag());
            }


            /* PARA TESTES
          ImportedProduct ip = new ImportedProduct("Tablet", 260, 20);
          Console.WriteLine(ip);

          Product product = new Product("Notebook", 1100);
          Console.WriteLine(product);

          UsedProduct used = new UsedProduct("Iphone", 400, "15/03/2015");
          Console.WriteLine(used);
          */


            /*
            Console.WriteLine("Price TAGS:");
            Console.WriteLine(ip.PriceTag());
            Console.WriteLine(product.PriceTag());
            Console.WriteLine(used.PriceTag());
            */









        }
    }
}
