﻿using System;
using System.Globalization;

namespace ExercicioIf
{
    class intervalo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um valor");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0 || valor <= 25.0)
            {
                Console.WriteLine("Intervalo (0, 25)");
            }
            else if (valor > 25.0 || valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25, 50)");
            }
            else if (valor > 50.0 || valor <= 75.0)
            {
                Console.WriteLine("Intervalo (50, 75)");
            }
            else if (valor >= 75.0 || valor <= 100.0)
            {
                Console.WriteLine("Intervalo (75, 100)");
            }
            else if (valor > 100 || valor < 0)
            {
                Console.WriteLine("Fora do intervalo");
            }
        }
    }
}