using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("quantos numero voce quer digitar: ");

            int numero = int.Parse(Console.ReadLine());

            int soma = 0;

            for(int i = 1; i<=numero; i++)
            {

                Console.Write($"Digite o numero {i}: ");
                int valor = int.Parse(Console.ReadLine());

                soma += valor;

            }

            Console.WriteLine($"o REsultado da soma e:{soma}");
        }
    }
}
