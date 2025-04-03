namespace Dungeon
{
    public class Program
    {
        static void Main()
        {
            Held hoelenforscher = new Held("held");
            Welt dungeon = new Welt("Dungeon");
            dungeon.Erschaffen();
            dungeon.Enter(hoelenforscher);
        
            // Bewegen durch die Welt
            hoelenforscher.Standort.Norden.Betreten(hoelenforscher, dungeon);
            hoelenforscher.Standort.Norden.Betreten(hoelenforscher, dungeon);
            hoelenforscher.Standort.Norden.Betreten(hoelenforscher, dungeon);
        }
    }
}