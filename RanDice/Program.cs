using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random(int.Parse(args[1]));
            int soma = 0;

            for(int dado = 0;dado < int.Parse(args[0]);dado++)
            {
                soma += generator.Next(1, 7);
            }

            Console.WriteLine(soma);

        }
    }
}
