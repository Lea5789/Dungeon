using System;

namespace Dungeon
{
    public class LeererRaum : ARaum
    {
        
            public string Beschreibung { get; set; }

            public LeererRaum(string beschreibung)
            {
                Beschreibung = beschreibung;
            }

            public override void Betreten(Held held, Welt welt)
            {
                held.Standort = this;
                Console.WriteLine(Beschreibung);
            }
        }
    }