using System;
using System.Globalization;

namespace ExercicioIF
{
    class produtos
    {
        static void Main(string[] args)
        {

            double hotDog = 4;
            double xSalada = 4.5;
            double xBacon = 5;
            double torrada = 2;
            double refri = 1.5;




            Console.WriteLine("Digite o lanche e quantidade: ");
            string[] pedido =Console.ReadLine().Split(' ');
            int codigo = int.Parse(pedido[0]);
            int quantidade = int.Parse(pedido[1]);


            if (codigo == 1)
            {
                Console.WriteLine("Total: R$ " + quantidade * hotDog);
            }
            else if (codigo == 2)
            {
                Console.WriteLine("Total: R$ " + quantidade * xSalada);
            }
            else if (codigo == 3)
            { Console.WriteLine("Total: R$ " + quantidade * xBacon); 
            }
            else if(codigo == 4){
                Console.WriteLine("Total: R$ " + quantidade * torrada);
            }else
            {
                Console.WriteLine("Total: R$ " + quantidade * refri);
            }
        }
    }
}