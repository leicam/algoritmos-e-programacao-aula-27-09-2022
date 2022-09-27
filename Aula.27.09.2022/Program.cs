using System;

namespace Aula._27._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();

            quadrado.Largura = 33;
            quadrado.Altura = 15;

            Console.WriteLine("A área do quadrado é: "
                + quadrado.CalcularArea());
        }
    }
}