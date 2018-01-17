using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human h1 = new Human("H1", 5,4,3, 100);
            Human h2 = new Human("H2");
            h1.Attack(h2);
            h1.Attack(h2);
            h1.Attack(h2);
            h2.Attack(h1);
            h1.Attack(h1);
            Console.WriteLine("Health of " + h1.name + " = " + h1.health);
            Console.WriteLine("Health of " + h2.name + " = " + h2.health);
        }
    }
}
