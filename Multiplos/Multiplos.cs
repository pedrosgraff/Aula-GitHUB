using System;
using System.Globalization;

namespace ExercicioIf
{
    class multiplos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 valores: ");
            string[] numeros = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);

            if(n1 % n2 == 0 || n2 % n1 == 0) {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }


        }
    }
}