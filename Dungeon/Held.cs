using System;
using System.Collections.Generic;

namespace Dungeon
{
    public class Held
    {
        public string Name { get; set; }
        public double Leben { get; set; }
        public ARaum Standort { get; set; }
        public Welt aktuelleWelt { get; set; }
        
        

        public Held(string name)
        {
            Name = name;
        }

        public List<Schatzraum.ESchatz>Rucksack { get; set; }

        
        
        public bool IsAlive()
        {
            if (Leben == 0)
            {
                Console.WriteLine($"Der Held ist tot!");
                return false;
            }else

            {
                Console.WriteLine($"Held hat noch Leben");
                return true;
            }
        }
        public interface IMoveable
        {
            public enum ERichtung
            {
                ENone,
                EForward,
                EBackward,
                ERight
            };

            void Move();
        }//hier: implementierung der Tasten zur bewegung fehlt noch=>mit IMoveable
    }
    }

    
