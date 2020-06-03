using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter Ryan = new Fighter("Ryan");
            Fighter Batman = new Fighter("Batman", 10, 10, 10, 250);
            Wizard IceKing = new Wizard("Ice King");
            Ninja Brian = new Ninja("Ninja Brian");
            Brian.Attack(Brian);
            Brian.Attack(Batman);
        }
    }
}
