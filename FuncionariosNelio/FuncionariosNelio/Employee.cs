using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosNelio
{
    class Employee
    {

        public string Name { get; set; }

        public int hours { get; set; }

        public double valuePerhour { get; set; }


        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerhour)
        {
            Name = name;
            this.hours = hours;
            this.valuePerhour = valuePerhour;
        }


        public virtual double Payment()
        {
            double valorPagar = valuePerhour * hours;
            return valorPagar;
        }



        public override string ToString()
        {
            string str = "";
            str += "Nome: " + Name+Environment.NewLine;
            str += "Pagamento R$: " + Payment()+Environment.NewLine;
            str += "\n";
            return str;
        }







    }
}
