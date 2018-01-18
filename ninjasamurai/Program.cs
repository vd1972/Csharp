using System;
using System.Collections.Generic;

namespace ninjasamurai
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Wizard> wizards;
            List<Ninja> ninjas;
            List<Samurai> samurais;
            Console.WriteLine("Hello World!");
            wizards = new List<Wizard>();
            ninjas = new List<Ninja>();
            samurais = new List<Samurai>();
            samurais.Add(CreateSamurai("Test1", 10, 20, 30));
            samurais.Add(CreateSamurai("Test2", 1, 2, 3));
            samurais.Add(CreateSamurai("Test3", 4, 5, 6));
            samurais.Add(CreateSamurai("Test4", 8, 12, 16));
            ninjas.Add(CreateNinja("Ninja1", 5, 6, 100));
            ninjas.Add(CreateNinja("Ninja2", 15, 9, 200));
            ninjas.Add(CreateNinja("Ninja3", 7, 12, 300));
            ninjas.Add(CreateNinja("Ninja4", 1, 14, 400));
            wizards.Add(CreateWizard("Wizard1", 2, 1));
            wizards.Add(CreateWizard("Wizard2", 4, 3));
            wizards.Add(CreateWizard("Wizard3", 6, 8));
            wizards.Add(CreateWizard("Wizard4", 8, 10));
        }

        private static Samurai CreateSamurai(string person, int str, int intel, int dex)
        {
            return new Samurai(person, str, intel, dex);
        }
        private static Wizard CreateWizard(string person, int str, int dex)
        {
            return new Wizard(person, str, dex);
        }
        private static  Ninja CreateNinja(string person, int str, int intel, int hp)
        {
            return new Ninja(person, str, intel, hp);
        }

    }
}
