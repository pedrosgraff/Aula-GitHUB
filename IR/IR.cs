using System;
using System.Globalization;

namespace IR
{
    class imposto
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double taxa1 = 8;
            double taxa2 = 18;
            double taxa3 = 28;


            if (salario < 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario >= 2000 && salario < 3000)
            {
                double calc1 = (taxa1 / 100) * (salario - 2000);
                Console.WriteLine(calc1);
            }
            else if (salario >= 3000 || salario < 4500)
            {
                double calc1 = (taxa1 / 100) * 1000;
                double calc2 = (taxa2 / 100) * (salario -3000 );
                Console.WriteLine( calc1 + calc2);
            }
            else
            {
                double calc1 = (taxa1 / 100) * 1000;
                double calc2 = (taxa2 / 100) * 1500;
                double calc3 = (taxa3 / 100) * (salario - 4500);
                Console.WriteLine( calc1 + calc2 + calc3 );
            }
        }
    }
}