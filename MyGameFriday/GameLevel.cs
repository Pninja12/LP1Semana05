using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameFriday
{
    public class GameLevel
    {
        int room;
        Difficulty difficulty;
        Enemy[] lista;
        public GameLevel (int quarto,Difficulty dificuldade)
        {
            room = quarto;
            difficulty = dificuldade;
            lista = new Enemy [room];
        }

        public void SetEnemyInRoom(int indice, Enemy inimigo)
        {
            lista[indice] = inimigo;
        }
        public Difficulty GetDifficulty()
        {
            return difficulty;
        }
        public int GetNumRooms()
        {
            return room;
        }
        public int GetNumEnemies()
        {
            return lista.Length;
        }
        public void PrintEnemies()
        {
            for(int i = 0; i < lista.Length; i++)
            {
                if (lista[i] != null)
                {
                    Console.WriteLine("Enemy name: " + lista[i].GetName());
                    Console.WriteLine("In room: " + i);
                    Console.WriteLine("");
                }
                
            }
        }

        
    }
}