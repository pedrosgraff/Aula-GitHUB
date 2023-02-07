using System;
using System.Globalization;

namespace ExercicioIf
{
    class calcHoras
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial e hora fim");
            string[] horas = Console.ReadLine().Split(' ');
            int hora1 = int.Parse(horas[0]);
            int hora2 = int.Parse(horas[1]);
            int dia = 24;

            if( hora1 == hora2)
            {
                Console.WriteLine("O jogo durou 24 horas");

            }
            else if( hora1 > hora2)
            {
                int calc = dia - hora1 + (hora2);
                Console.WriteLine("O jogo durou " + calc);
            }
            else
            {
                int calc1 = hora2 - hora1;
                Console.WriteLine("O jogo durou " + calc1);
            }

        }
    }
}