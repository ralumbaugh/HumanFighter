using System;

namespace Human
{
    class Samurai : Fighter
    {
        // Constructors
        public Samurai(string name) : base(name)
        {
            this.IsAlive = true;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.Health = 200;
            this.MaxHealth = 200;
        }
        public Samurai(string name, int strength, int intelligence, int dexterity, int health) : base(name, strength, intelligence, dexterity, health)
        {
            this.MaxHealth=health;
        }

        // Methods
        public override void Attack(Fighter target)
        {
            if(this.IsAlive == false)
                {
                    Console.WriteLine($"{this.Name} dramatically starts to get back onto their knee. Nope! {this.Name}'s foot slips out beneath themself. {this.Name} is dead!");
                }
                else if(this == target)
                {
                    Console.Write($"{this.Name} draws their sword out for a moment, then resheathes it. Perhaps attacking yourself isn't a good plan.");
                }
                else if(target.IsAlive == false)
                {
                    Console.WriteLine($"Show some mercy {this.Name}! You can only cut {target.Name} into so many pieces!");
                }
                else
                {
                    Console.WriteLine($"{this.Name} slashes into {target.Name}!");
                    target.HealthProp = target.HealthProp-(5*this.Strength);
                    if(target.Health < 50)
                    {
                        target.Health = 0;
                        target.IsAlive = false;
                    }
                    Console.WriteLine($"{target.Name} has {target.Health} left!");
                }
        }

        public void Meditate()
        {
            if(this.IsAlive == false)
            {
                Console.WriteLine($"Nice try, {this.Name} but you can't meditate out of death!");
            }
            else
            {
                this.Health = this.MaxHealth;
            }
        }
    }
}
