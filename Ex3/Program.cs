using System;
using System.Globalization;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor Inteiro: ");
            int valor = int.Parse(Console.ReadLine());
            double media = 0;
            

            for (double i = 1; i<=valor; i++)
            {
                string [] medi = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(medi[0], CultureInfo.InvariantCulture);
                double nota2 = double.Parse(medi[1], CultureInfo.InvariantCulture);
                double nota3 = double.Parse(medi[2], CultureInfo.InvariantCulture);

                media = (nota1 *2.0 + nota2*3.0 + nota3*4.0) / 10.0;

                
                

            }
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
