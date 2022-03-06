using System;


namespace Tax.Entities
{
    class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TaxIncome()
        {
            double imposto =0;
            double valorPagar = 0;

            if (NumberEmployees > 10)
            {
                imposto = 0.14;
            }
            else
            {
                imposto = 0.16;
            }

            valorPagar = AnualIncome * imposto;

            return valorPagar;
        }

        



    }
}
