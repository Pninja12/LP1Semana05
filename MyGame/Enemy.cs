namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        // C o n s t r u t o r
        public Enemy ( string name )
        {
            this.name = name ; // Po rque r a z a o usamos " t h i s " ?
            health = 100;
            shield = 0;
        }

        public string GetName ( )
        {
            return name ;
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
