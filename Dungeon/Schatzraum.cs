using System;

namespace Dungeon
{
    class Schatzraum : ARaum
    {
        public Schaetze.ESchatz Schatz { get; set; }
        private bool wurdeGesammelt = false;

        public Schatzraum(Schaetze.ESchatz schatz)
        {
            Schatz = schatz;
        }

        public override void Betreten(Held held, Welt welt)
        {
            held.Standort = this;
            if (!wurdeGesammelt)
            {
                held.Rucksack.Add(Schatz);
                Console.WriteLine($"{held.Name} findet Schatz: {Schatz}!");
                wurdeGesammelt = true;
            }
            else
            {
                Console.WriteLine("Hier ist kein Schatz mehr!!");
            }
        }
    }

}