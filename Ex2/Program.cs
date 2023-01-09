using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de vx  valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int C_in = 0;
            int C_out = 0;

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Digite um numero{i}");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <=20)
                {
                    C_in += 1;

                }
                else
                {
                    C_out += 1;
                }
            }

            Console.WriteLine($"in{C_in}");
            Console.WriteLine($"out{C_out}");
        }
    }
}
