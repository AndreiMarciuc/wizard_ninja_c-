using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wiz = new Wizard("Alex");
            Console.WriteLine(wiz.health);
            Console.WriteLine(wiz.intelligence);
            Ninja nin = new Ninja("Leonard");
            Console.WriteLine(nin.intelligence);
            Samurai sam = new Samurai("Jack");


        }
    }
}
