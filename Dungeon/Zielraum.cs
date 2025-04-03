using System;

namespace Dungeon
{
    
    public class ZielRaum : ARaum
    {
        public override void Betreten(Held held, Welt welt)
        {
            held.Standort = this;
            Console.WriteLine("Ausgang erreicht!");
            Console.WriteLine($"Glückwunsch {held.Name}");
            Console.WriteLine($"Gratulation: {welt.Name} - Ziel erreicht!");
        }
    }
}