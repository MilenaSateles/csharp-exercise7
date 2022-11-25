using System;
using System.Globalization;

namespace DivisaoImpossivel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê um par de números e divide o primeiro pelo segundo

            Console.WriteLine("Quantos pares de números?");
            int quant = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < quant; i++)
            {
                Console.Write("Primeiro número: ");
                double num = double.Parse(Console.ReadLine()!);
                Console.Write("Segundo número: ");
                double deno = double.Parse(Console.ReadLine()!);

                if (deno == 0)
                    Console.WriteLine("Divisão impossível");

                else
                    Console.WriteLine("Resultado: " + (num / deno).ToString("F1"), CultureInfo.InvariantCulture);
               
            }

        }
    }
}
