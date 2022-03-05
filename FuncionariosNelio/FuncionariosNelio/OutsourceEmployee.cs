using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosNelio
{
    class OutsourceEmployee : Employee  
    {

        public double AditionalCharge { get; set; }

        public OutsourceEmployee()
        {

        }

        public OutsourceEmployee(string name, int hours, double valuePerhour, double adidiontalCharge)
            : base( name,  hours,  valuePerhour)
        {
            AditionalCharge = adidiontalCharge;
        }


        public override double Payment()
        {
            double valorPagar = base.Payment() + (1.1 * AditionalCharge);
            return valorPagar;
        }







    }
}
