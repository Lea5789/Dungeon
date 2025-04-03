using System;

namespace Dungeon
{
    public abstract class ARaum
    {
        
            public ARaum Norden { get; set; }
            public ARaum Osten { get; set; }
            public ARaum Sueden { get; set; }
            public ARaum Westen { get; set; }

        public virtual void Betreten(Held held,Welt welt)
        {
            Console.WriteLine($"{held}betritt die welt {welt}");
        }
        
    }
}