﻿using System;

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

            ListaInimigos[0].PickupPowerUp(PowerUp.Health, 10);
            ListaInimigos[0].PickupPowerUp(PowerUp.Shield, 30);
            ListaInimigos[1].PickupPowerUp(PowerUp.Shield, 30);
            ListaInimigos[0].TakeDamage(40);
            ListaInimigos[1].TakeDamage(10);
            ListaInimigos[0].PickupPowerUp(PowerUp.Health, 5);
            //Loop para mostrar os inimigos
            foreach(Enemy Inimigo in ListaInimigos)
            {
                Console.Write($"{Inimigo.GetName()} ");
                Console.Write($"{Inimigo.GetHealth()} ");
                Console.WriteLine($"{Inimigo.GetShield()}");
                Console.WriteLine(Enemy.GetHowManyPowerUps());
            }
        }
    }
}
