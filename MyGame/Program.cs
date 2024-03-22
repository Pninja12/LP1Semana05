using System;

namespace MyGame
{
    class Program
    {
        /// <summary>
        /// Programa que recebe o número de inimigos e pergunta o nome de cada 
        /// um para no fim imprimir o nome de cada e os seus atributos
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ///Cria a lista de inimigos com o tamanho recebido
            Enemy[] ListaInimigos = new Enemy[int.Parse(args[0])];

            //Loop para perguntar e atribuir o nome aos inimigos
            for(int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                //Inicializa cada inimigo dentro da lista
                ListaInimigos[i] = new Enemy();
                ListaInimigos[i].SetName(Console.ReadLine());
            }

            //Loop para mostrar os inimigos
            foreach(Enemy Inimigo in ListaInimigos)
            {
                Console.Write($"{Inimigo.GetName()} ");
                Console.Write($"{Inimigo.GetHealth()} ");
                Console.WriteLine($"{Inimigo.GetShield()}");
            }
            Console.WriteLine("\nPowerUps used:" + Enemy.GetHowManyPowerUps());
        }
    }
}
