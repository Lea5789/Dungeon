using System;

namespace Dungeon
{
    class FallenRaum : ARaum
    {
        public int Schaden { get; set; }

        public FallenRaum(int schaden)
        {
            Schaden = schaden;
        }

        public override void Betreten(Held held, Welt welt)
        {
            held.Leben -= Schaden;
            held.Standort = this;
            Console.WriteLine($"FALLE! {held.Name} nimmt {Schaden} Schaden.");
        }
    }
}