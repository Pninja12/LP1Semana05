using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy[] ListaInimigos = new Enemy[int.Parse(args[0])];


            for(int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.Write($"Nome do inimigo {i + 1} : ");
                ListaInimigos[i] = new Enemy("");
                ListaInimigos[i].SetName(Console.ReadLine());
            }

            foreach(Enemy Inimigo in ListaInimigos)
            {
                Console.Write($"{Inimigo.GetName()} ");
                Console.Write($"{Inimigo.GetHealth()} ");
                Console.WriteLine($"{Inimigo.GetShield()}");
            }
        }
    }
}
