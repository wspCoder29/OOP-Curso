using System;

namespace Tax.Entities
{
     class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }


        public override double TaxIncome()
        {
            double imposto = 0;
            double vlrHealth = 0;

            if (AnualIncome < 20000.00)
            {
                imposto = 0.15;
            }
            else if (AnualIncome >= 20000.00)
            {
                imposto = 0.25;
            }

            double valorPagar = AnualIncome * imposto;

            if (HealthExpenditures > 0)
            {
                vlrHealth = HealthExpenditures * 0.5;
            }

            valorPagar -=  vlrHealth;

            return valorPagar;
            //Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
            //fica: (50000 * 25%) - (2000 * 50%) = 11500.00
        }











    }
}
