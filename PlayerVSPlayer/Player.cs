using System;

namespace PlayerVSPlayer
{
    internal class Player
    {
        private int Damage;
        private int Health;

        public Player()
        {
            Damage = 5;
            Health = 100;
        }

        internal int GetDamage()
        {
            return Damage;
        }
        internal void SetAttackPower(int attack)
        {
            this.Damage = attack;
        }
        internal int GetHealth()
        {
            return Health;
        }
        internal void SetHealth(int health)
        {
            this.Health = health;
        }
        public void AttackPlayer(Player otherPlayer)
        {
            int damage = this.GetDamage();
            Console.WriteLine("1. Step: \n Ylli's Damage attack: \n" + GetDamage() + "Dmg");
            Console.ReadLine();
            // player 1 attacks player 2
            //ylli.attack(gentrit)
            int health2 = otherPlayer.GetHealth();
            Console.WriteLine("Step 2: \n Gentrit's HP before attack: \n" + GetHealth() + "HP");
            Console.ReadLine();
            int newHealth = health2 - damage;
            Console.WriteLine($"Step 3: \n Ylli attack Gentrit. \n Gentrit has: " + newHealth + "HP");
            Console.ReadLine();
            //hämta det nya health av player 2 efter attack
            otherPlayer.SetHealth(newHealth);
            Console.WriteLine("Step 4: \n Gentrit's HP after attack: \n" + newHealth + "HP");
            Console.ReadLine();
        }
    }
}