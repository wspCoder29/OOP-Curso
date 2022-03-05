using System;
using System.Collections.Generic;

namespace FuncionariosNelio
{
    internal class Program
    {


        static string name;
        static int hours;
        static double valueHour;
        static double aditionalCharge;

        public static void InputEmployee()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Hours: ");
            hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour R$: ");
            valueHour = int.Parse(Console.ReadLine());
        }


        public static void InputOut()
        {
            InputEmployee();
            Console.WriteLine("Aditional Charge R$: ");
            aditionalCharge = int.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {

            List<Employee> li = new List<Employee>();

            int num = 0;
            string op = "";
            Employee emp;

            /* PARA TESTE
            Employee ep1 = new Employee("Alex", 50, 20);
            OutsourceEmployee out1 = new OutsourceEmployee("Bob", 100, 15, 200);
            Employee ep2 = new Employee("Maria", 60, 20);

            li.Add(ep1);
            li.Add(out1);
            li.Add(ep2);
            */

            Console.Write("Enter the number of employees: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Employee #{0} data:", i + 1);
                Console.Write("Outsourced (y/n)?");
                op = Console.ReadLine();

                if (op == "n")
                {
                    InputEmployee();
                    emp = new Employee(name, hours, valueHour);
                    li.Add(emp);

                }
                else if (op == "y")
                {
                    InputOut();                    
                    emp = new OutsourceEmployee(name, hours, valueHour, aditionalCharge);
                    li.Add(emp);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Payments");
            Console.WriteLine(String.Join(" ", li));
        }

  

    }
}
