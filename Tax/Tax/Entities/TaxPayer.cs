using System;


namespace Tax.Entities
{
     abstract class TaxPayer
    {



        public string Name { get; set; }

        public double AnualIncome { get; set; }


        protected TaxPayer() { }

        public abstract double TaxIncome();

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }












    }
}
