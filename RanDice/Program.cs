using System;

namespace RanDice
{
    class Program
    {
        /// <summary>
        /// Programa que receb na linha de comandos dois números, o primeiro que
        /// indica a quantidade de dados a serem lançados e o segundo indica a 
        /// 'seed' a que os dados serão lançados
        /// </summary>
        /// <param name="args">o 1º é os dados e o 2º é a 'seed'</param>
        static void Main(string[] args)
        {
            //inicialização do gerador que recebe a 'seed'
            Random generator = new Random(int.Parse(args[1]));
            
            //inicialização da variável com a soma dos dados
            int soma = 0;

            //lançamento de dados
            for(int dado = 0;dado < int.Parse(args[0]);dado++)
            {
                soma += generator.Next(1, 7);
            }

            Console.WriteLine(soma);

        }
    }
}
