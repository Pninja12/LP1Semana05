using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        public Enemy (string name)
        {
            this.name = name ;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name ;
        }

        public void SetName(string nome)
        {
            string Filtername = "";
            if (nome.Length > 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Filtername += nome[i];
                }
            }
            else
                Filtername = nome;
            name = Filtername;

        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void TakeDamage (float damage)
        {
            shield -= damage ;
            if (shield < 0 )
            {
                float damageStillToInflict = -shield;
                shield = 0 ;
                health -= damageStillToInflict;
                if (health < 0) health = 0 ;
            }
        }


    }
}
