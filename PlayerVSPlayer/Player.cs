using System;

namespace PlayerVSPlayer
{
    internal class Player
    {
        private int Damage;
        private int Health;
        private int Defense;

        public Player()
        {
            Damage = 20;
            Health = 100;
            Defense = 30;
        }

        internal int GetDamage()
        {
            return Damage;
        }
        internal void SetAttackPower(int attack)
        {
            this.Damage += attack;
        }
        internal int GetHealth()
        {
            return Health;
        }
        internal void SetHealth(int health)
        {
            this.Health = health;
        }
        internal int GetDefense()
        {
            return Defense;
        }
        internal void SetDefense(int defense)
        {
            this.Defense = defense;
        }
        public void AttackPlayer(Player otherPlayer)
        {
            int damage = this.GetDamage();
            Console.WriteLine("Step 1: \n Ylli's Damage attack: \n " + GetDamage() + " Dmg");
            Console.ReadLine();
            // player 1 attacks player 2
            //ylli.attack(gentrit)
            int health2 = otherPlayer.GetHealth();
            int defense = otherPlayer.GetDefense();
            Console.WriteLine("Step 2: \n Gentrit's HP and Defense before attack: \n " + GetHealth() + " HP  \n " + GetDefense() + " Def");
            Console.ReadLine();

            int lostHealth = health2 - damage;
            int newStance = defense - damage;
            int newHealth = newStance + health2;

            if (newStance < 0)
            { 
                otherPlayer.SetHealth(Health);
                Console.WriteLine("Step 3: \n You have still: \n " + Health + " HP");
                Console.ReadLine(); 
            }
            if(defense < newStance)
                otherPlayer.SetHealth(newHealth);
                Console.WriteLine("Step 3: \n You lost to: \n " + newHealth + " HP");
                Console.ReadLine();

            if (otherPlayer.Health >= newHealth)
            {
                otherPlayer.SetDefense(newStance);
                otherPlayer.SetHealth(Health);
                Console.WriteLine($"Step 4: \n Ylli attack Gentrit. \n Gentrit has: \n " + otherPlayer.Health + " HP \n " + newStance + " Def");
                Console.ReadLine();
            } else if (otherPlayer.Health < newHealth)
                Console.WriteLine($"Step 4: \n Ylli attack Gentrit. \n Gentrit lost to: \n " + otherPlayer.GetHealth() + " HP \n" + " Defense depleted!");
                Console.ReadLine();


        }
    }
}