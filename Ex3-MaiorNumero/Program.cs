using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_MaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("\nDigite o Primeiro Número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Segundo Número: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("\nO Maior número é: " + numero1);
            }

                else if(numero2 > numero1)
                {
                    Console.WriteLine("\nO Maior número é: " + numero2);
                }

                    else 
                    {
                        Console.WriteLine("\nOs Números São Iguais");
                    }
            Console.ReadKey();
        }
    }
}
