namespace Dungeon
{
    public class Schaetze
    



{
    public enum ESchatz
    {
        Krone,
        Trank
    }
}


public interface IMoveable
{
    public enum Richtung { ENone, EForward, EBackward, ERight, ELeft }
    void Move(Richtung richtung);
}

}