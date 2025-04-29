using System;
using System.Collections.Generic;

namespace Dungeon
{
    public class Held : IMoveable
    {
        public Welt aktuelleWelt;
        public string Name { get; private set; }
        public int Leben { get; set; } = 110;
        public ARaum Standort { get; set; }
        public Welt AktuelleWelt { get; set; }
        public List<Schaetze.ESchatz> Rucksack { get; set; } = new();

        public Held(string name)
        {
            Name = name;
        }

        public void Move(IMoveable.Richtung richtung)
        {
            ARaum ziel = null;
            switch (richtung)
            {
                case IMoveable.Richtung.EForward:
                    ziel = Standort.Norden;
                    break;
                case IMoveable.Richtung.EBackward:
                    ziel = Standort.Sueden;
                    break;
                case IMoveable.Richtung.ERight:
                    ziel = Standort.Osten;
                    break;
                case IMoveable.Richtung.ELeft:
                    ziel = Standort.Westen;
                    break;
            }

            if (ziel != null)
            {
                ziel.Betreten(this, AktuelleWelt);
            }
            else
            {
                Console.WriteLine("Kein Raum in dieser Richtung!");
            }
        }

        public bool IsAlive()
        {
            return Leben > 0;
        }
    }

    }

    
