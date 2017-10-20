//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PlayerVSPlayer
//{
//    {
//        private int Damage;
//    private int Health;
//    private int Defense;

//    public Player()
//    {
//        Damage = 10;
//        Health = 100;
//        Defense = 30;
//    }

//    internal int GetDamage()
//    {
//        return Damage;
//    }
//    internal void SetAttackPower(int attack)
//    {
//        this.Damage = attack;
//    }
//    internal int GetHealth()
//    {
//        return Health;
//    }
//    internal void SetHealth(int health)
//    {
//        this.Health = health;
//    }
//    internal int GetDefense()
//    {
//        return Defense;
//    }
//    internal void SetDefense(int defense)
//    {
//        this.Defense = defense;
//    }
//    public void AttackPlayer(Player otherPlayer)
//    {
//        int damage = this.GetDamage();
//        Console.WriteLine("1. Step: \n Ylli's Damage attack: \n" + GetDamage() + " Dmg");
//        Console.ReadLine();
//        // player 1 attacks player 2
//        //ylli.attack(gentrit)
//        int health2 = otherPlayer.GetHealth();
//        int defense = otherPlayer.GetDefense();
//        Console.WriteLine("Step 2: \n Gentrit's HP and Defense before attack: \n" + GetHealth() + " HP  \n " + GetDefense() + " Def");
//        Console.ReadLine();
//        int lostHealth = health2 - damage;
//        int newStance = defense - damage;

//        if (defense <= 0)
//        {
//            otherPlayer.SetDefense(health2);
//            Console.WriteLine(health2);
//            Console.ReadLine();
//        }
//        else
//            Console.WriteLine(lostHealth - newStance);
//        Console.ReadLine();

//        if (newStance >= 0)
//        {
//            otherPlayer.SetDefense(newStance);
//            otherPlayer.SetHealth(lostHealth);
//            Console.WriteLine($"Step 3: \n Ylli attack Gentrit. \n Gentrit has: \n" + lostHealth + " HP \n " + newStance + " Def");
//            Console.ReadLine();
//        }
//        else
//            Console.WriteLine($"Step 3: \n Ylli attack Gentrit. \n Gentrit has: \n" + lostHealth + " HP \n " + " Defense depleted!");
//        Console.ReadLine();
//    }
//}
//}
