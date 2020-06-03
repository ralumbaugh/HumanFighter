using System;

namespace Human
{
    class Wizard : Fighter
    {
        // Constructors
        public Wizard(string name) : base(name)
        {
            this.IsAlive = true;
            this.Strength = 3;
            this.Intelligence = 25;
            this.Dexterity = 3;
            this.Health = 50;
            this.MaxHealth = 50;
        }
        public Wizard(string name, int strength, int intelligence, int dexterity, int health) : base(name, strength, intelligence, dexterity, health)
        {
            this.MaxHealth = health;
        }

        // Methods
        public override void Attack(Fighter target)
        {
            if(this.IsAlive == false)
                {
                    Console.WriteLine($"{this.Name} lies on the ground. A sad, crumpeled up pile of wizard.");
                }
                else if(this == target)
                {
                    Console.Write($"{this.Name} draws the life out of themselves. They then immediately draw the life energy back into themselves. Good job {this.Name}.");
                }
                else if(target.IsAlive == false)
                {
                    Console.WriteLine($"Show some mercy {this.Name}! You can't get blood from a stone, and {target.Name} is hardly more than a rock at this point!");
                }
                else
                {
                    Console.WriteLine($"{this.Name} drains the life from {target.Name}!");
                    target.HealthProp = target.HealthProp-(5*this.Intelligence);
                    if(this.Health + (5*this.Intelligence) < this.MaxHealth)
                    {
                        this.HealthProp = this.HealthProp + (5*this.Intelligence);
                    }
                    else
                    {
                        this.Health = this.MaxHealth;
                    }
                    Console.WriteLine($"{target.Name} has {target.Health} left!");
                }
        }

        public void Heal(Fighter target)
        {
            if(this.IsAlive == false)
                {
                    Console.WriteLine("Physician, heal thyself. Oh wait, you can't.");
                }
            else
            {
                Console.WriteLine($"{this.Name} heals {target.Name} for {this.Intelligence*10} HP");
                if(target.Health+(this.Intelligence*10) < target.MaxHealth)
                {
                    target.Health += (this.Intelligence*10);
                }
                else
                {
                    target.Health = target.MaxHealth;
                }
            }
        }
    }
}
