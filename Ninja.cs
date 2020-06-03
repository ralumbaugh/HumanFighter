using System;

namespace Human
{
    class Ninja : Fighter
    {
        // Constructors
        public Ninja(string name) : base(name)
        {
            this.IsAlive = true;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 175;
            this.Health = 100;
            this.MaxHealth = 100;
        }
        public Ninja(string name, int strength, int intelligence, int dexterity, int health) : base(name, strength, intelligence, dexterity, health)
        {
            this.MaxHealth = health;
        }
        // Methods
        public override void Attack(Fighter target)
        {
            Random rand = new Random();
            if(this.IsAlive == false)
            {
                Console.WriteLine($"{this.Name} has disintigrated into a puff of smoke.");
            }
            else if(this == target)
            {
                this.Health = this.Health - (5*this.Dexterity);
                if(this.Health>0)
                {
                    Console.WriteLine($"{this.Name} sneaks up behind {this.Name} and stabs them in the back! Wait... What?");
                }
                else
                {
                    Console.WriteLine($"{this.Name} takes a drink of Sake. Wait a second, which jug of Sake did they poison again? Oh no!");
                    this.IsAlive = false;
                }
            }
            else if(target.IsAlive == false)
            {
                Console.WriteLine($"Show some mercy {this.Name}! You've already assassinated {target.Name}!");
            }
            else
            {
                Console.WriteLine($"{this.Name} throws a shuriken at {target.Name}!");
                target.HealthProp = target.HealthProp-(5*this.Dexterity);
                int ProcChance = rand.Next(1,101);
                if(ProcChance>=80)
                {
                    Console.WriteLine($"{this.Name}'s shuriken had poison on it! It does an extra 10 damage!");
                    target.HealthProp = target.HealthProp-10;
                }
                Console.WriteLine($"{target.Name} has {target.Health} left!");
            }
        }
        public void Steal (Fighter target)
        {
            if(this == target)
            {
                Console.WriteLine($"You stole your own health. Good job {this.Name}");
            }
            else
            {
                target.Health -= 5;
                target.MaxHealth -= 5;
                this.Health += 5;
                this.MaxHealth += 5;
            }
        }
    }
}
