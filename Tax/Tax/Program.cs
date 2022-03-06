using System;
using Tax.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Tax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> li = new List<TaxPayer>();

            Console.Write("Enter the number of Tax payers: ");
            int numTaxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numTaxPayers; i++)
            {
                Console.WriteLine("TaxPayer {0} data: ", i);
                Console.Write("Individual or company (i/c): ");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (opcao == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    li.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (opcao == 'c')
                {
                    Console.WriteLine("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    li.Add(new Company(name, anualIncome, numberEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxas pagas: ");
            foreach (TaxPayer taxPayer in li)
            {
                Console.WriteLine(taxPayer.Name + " $ " + taxPayer.TaxIncome().ToString("F2"));
            }

            double total = li.Sum(x => x.TaxIncome());

            Console.WriteLine("Total Taxes $: " + total.ToString("F2"));

            /*
             * Para teste
            
            Individual id = new Individual("Alex", 50000, 2000);
            Company company = new Company("SoftTech", 400000, 25);
            Individual id2 = new Individual("Bob", 120000, 1000);

            List<TaxPayer> li = new List<TaxPayer>();
            li.Add(id);
            li.Add(company);
            li.Add(id2);
            */





        }
    }
}
