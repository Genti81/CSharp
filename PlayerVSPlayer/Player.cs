using System;

namespace PlayerVSPlayer
{
    internal class Player
    {
        private int Damage;
        //private int LastDmgDone;
        private int Health;
        private int Shield;
        private string Name;
        private int critChance;

        
        public Player()
        {
            PlayerDamage = 7;
            PlayerHealth = 100;
            PlayerShield = 35;
            this.PlayerName = "Default Name";
            this.critChance = 25;
        }

        public void ShowStatus()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Player: " + PlayerName);
            if (this.PlayerShield > 0)
                Console.WriteLine("Player shield is: " + this.PlayerShield);
            Console.WriteLine("Player health is:" + this.PlayerHealth);
            //if(this.PlayerDamage > 7)
            //Console.WriteLine(this.PlayerDamage);
            Console.WriteLine("------------------------");
            Console.ReadLine();
        }

        public void AttackPlayer(Player otherPlayer)
        {
            int damage; 
            if (isCrit()) // If crit
                damage = otherPlayer.PlayerShield - (this.PlayerDamage * 2);
            else // If not crit
                damage = otherPlayer.PlayerShield - this.PlayerDamage;


            if (damage < 0)// Player takes damage
            {
                otherPlayer.ChangeHealth(damage);
                otherPlayer.PlayerShield = 0;
            }
            else // Only shield damage
                otherPlayer.PlayerShield = damage;
        }
        public string PlayerName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        private int PlayerDamage
        {
            get
            {
                return this.Damage;
            }
            set
            {
                this.Damage = value;
            }
        }

        private int PlayerHealth
        {
            get
            {
                return this.Health;
            }
            set
            {
                this.Health = value;
            }
        }

        private int PlayerShield
        {
            get
            {
                return this.Shield;
            }
            set
            {
                this.Shield = value;
            }
        }


        private bool isCrit()
        {
            Random RandomNumber = new Random();
            return RandomNumber.Next(1, 100) <= this.critChance;
        }


        
        // Skapa en metod som ändrar Hp med angivet input
        // public ---- ChangeHealth(Int ----)
        private void ChangeHealth(int ChangeValueOfHP)
        {
            //Hämta det orginal hp variabeln och addera hp med Change...variabeln till det nya
            var newresult = this.PlayerHealth + ChangeValueOfHP;
            this.PlayerHealth = newresult;
        }

        public bool IsDead()
        {
            // Lever personen?
            // Returnera true eller false

            //Ett booliskt uttryck antar alltid värdet true eller false
            return this.PlayerHealth < 1;
        }
    }
}


//int damageResult = otherPlayer.GetShield() - this.GetDamage();
//this.isCrit();
//otherPlayer.ChangeHealth(damageResult);
//damage = isCrit() ? otherPlayer.PlayerShield - (this.PlayerDamage * 2) : otherPlayer.PlayerShield - this.PlayerDamage;