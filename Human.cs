using System;

namespace Human
{
        public class Fighter
        {
            // Attributes
            public bool IsAlive;
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            public int Health;
            public int MaxHealth;
            // Constructors
            public Fighter(string name)
            {
                this.IsAlive = true;
                this.Name = name;
                this.Strength = 3;
                this.Intelligence = 3;
                this.Dexterity = 3;
                this.Health = 100;
                this.MaxHealth = 100;
            }
            public Fighter(string name, int strength, int intelligence, int dexterity, int health)
            {
                this.IsAlive = true;
                this.Name = name;
                this.Strength = strength;
                this.Intelligence = intelligence;
                this.Dexterity = dexterity;
                this.Health = health;
                this.MaxHealth = health;
            }
            // Methods
            public int HealthProp
            {
                get
                {
                    return Health;
                }
                set
                {
                    Health = value;
                    if(Health<=0)
                    {
                        Console.WriteLine($"{this.Name} has been defeated!");
                        this.AliveProp = false;
                    }
                }
            }
            public bool AliveProp
            {
                get
                {
                    if(this.IsAlive == true)
                    {
                        Console.WriteLine($"{this.Name} is still ready to fight!");
                        return(true);
                    }
                    else
                    {
                        Console.WriteLine($"{this.Name} is down for the count!");
                        return(false);
                    }
                }
                set
                {
                    this.IsAlive = value;
                }
            }
            public virtual void Attack(Fighter target)
            {
                if(this.IsAlive == false)
                {
                    Console.WriteLine($"Try as they might, {this.Name} doesn't have the strength left to fight!");
                }
                else if(target.IsAlive == false)
                {
                    Console.WriteLine($"Show some mercy {this.Name}! {target.Name} is already down for the count!");
                }
                else
                {
                    Console.WriteLine($"{this.Name} is attacking {target.Name}!");
                    target.HealthProp = target.HealthProp-(5*this.Strength);
                    Console.WriteLine($"{target.Name} has {target.Health} left!");
                }
            }
        }
}