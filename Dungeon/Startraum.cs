﻿using System;

namespace Dungeon
{
    class StartRaum : ARaum
    {
        public override void Betreten(Held held, Welt welt)
        {
            held.Standort = this;
            held.aktuelleWelt = welt;
            Console.WriteLine($"Hallo {held.Name} - Willkommen in der Welt {welt.Name}");
        }
    }
}