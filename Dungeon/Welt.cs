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
            ZielRaum zielRaum = new ZielRaum();
            FallenRaum fallenRaum = new FallenRaum(20);

            StartRaum.Norden = leererRaum;
            leererRaum.Norden = fallenRaum;
            fallenRaum.Norden = zielRaum;
        }

        public void Enter(Held held)
        {
            StartRaum.Betreten(held, this);
        }
    }
}