namespace Dungeon
{
    public class Welt
    {
        public string Name { get; set; }
        public ARaum StartRaum { get; set; }

        public Welt(string name)
        {
            Name = name;
        }

        public void Erschaffen()
        {
            StartRaum = new StartRaum();
            LeererRaum leererRaum = new LeererRaum("Ein leerer Raum");
            LeererRaum leererRaum1 = new LeererRaum("Ein leerer Raum");
            LeererRaum leererRaum2 = new LeererRaum("Ein leerer Raum");

            FallenRaum fallenRaum = new FallenRaum(50);
            FallenRaum fallenRaum1 = new FallenRaum(50);
           

            ZielRaum zielRaum = new ZielRaum();
            Schatzraum schatzRaum = new Schatzraum(Schaetze.ESchatz.Krone);
            Schatzraum schatzRaum1 = new Schatzraum(Schaetze.ESchatz.Trank);

            StartRaum.Norden = leererRaum;
            leererRaum.Sueden = StartRaum;

            leererRaum.Osten = leererRaum1;
            leererRaum1.Westen = leererRaum;
            leererRaum.Norden = fallenRaum;
            fallenRaum.Sueden = leererRaum;

            leererRaum1.Sueden = schatzRaum1;
            schatzRaum1.Norden = leererRaum1;

            leererRaum1.Osten = schatzRaum;
            schatzRaum.Westen = leererRaum1;
            leererRaum1.Norden = leererRaum2;
            leererRaum2.Sueden = leererRaum1;
            leererRaum2.Norden = fallenRaum1;
            fallenRaum1.Sueden = leererRaum2;
            leererRaum2.Westen = fallenRaum;
            fallenRaum.Osten = leererRaum2;
            leererRaum2.Osten = zielRaum;
            
            
            
        }

        public void Enter(Held held)
        {
            StartRaum.Betreten(held, this);
        }
    }
}