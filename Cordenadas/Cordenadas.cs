using System;
using System.Globalization;

namespace ExercicioIf
{
    class plano
    {
        static void Main(string[] args)
        {
            string[] plano =Console.ReadLine().Split(' ');
            double x = double.Parse(plano[0]);
            double y = double.Parse(plano[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo x");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo y");
            } else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            }
        }
    }