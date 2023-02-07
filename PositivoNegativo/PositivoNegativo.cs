using System;
using System.Globalization;

namespace ExercicioIf
{
    class inteiro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());

            if(numero >= 0)
            {
                Console.WriteLine("Inteiro");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}