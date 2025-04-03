using System;

namespace Dungeon
{
     public class Schatzraum:ARaum
    {
        public override void Betreten(Held held, Welt welt)
        {
            held.Standort = this;
        }

        public enum ESchatz
        {
            Gold,
            Truhe,
            None
        };
        public ESchatz schatz { get; set; }
        if(Held.Betreten())
        {
            Console.WriteLine($"{Held} findet einen schatz");
            break;
            
        }else
    {
        Console.WriteLine($"{Held} hat keinen Schatz gefunden");
        
    }//hier:es fehlt das der neue schatz in den rucksack des helden hinzugefügt wird=>mit der Methode ADD()
    }
}