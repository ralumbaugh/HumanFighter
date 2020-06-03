using System;

namespace Human
{
    class Program
    {

        public class Fighter
        {
            public bool IsAlive;
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int Health;

            public Fighter(string Name)
            {
                this.IsAlive = true;
                this.Name = Name;
                this.Strength = 3;
                this.Intelligence = 3;
                this.Dexterity = 3;
                this.Health = 100;
            }

            public Fighter(string Name, int Strength, int Intelligence, int Dexterity, int Health)
            {
                this.IsAlive = true;
                this.Name = Name;
                this.Strength = Strength;
                this.Intelligence = Intelligence;
                this.Dexterity = Dexterity;
                this.Health = Health;
            }

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
            public void Attack(Fighter target)
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
        static void Main(string[] args)
        {
            Fighter Ryan = new Fighter("Ryan");
            Fighter Batman = new Fighter("Batman", 10, 10, 10, 250);
            Ryan.Attack(Batman);
            Batman.Attack(Ryan);
            Batman.Attack(Ryan);
            Batman.Attack(Ryan);
            Ryan.Attack(Batman);
        }
    }
}
