using System;

namespace Dungeon;

class GameController
{
    private Welt welt;
    private Held held;

    public GameController(Welt welt, Held held)
    {
        this.welt = welt;
        this.held = held;
        welt.Erschaffen();
        welt.Enter(held);
    }

    public void Run()
    {
        bool spielLaeuft = true;
        while (spielLaeuft && held.IsAlive())
        {
            Console.WriteLine("Wohin möchtest du gehen? (W = nach vorne, S = rückwärts, A = links, D = rechts, Q = Held gibt auf)");
            var taste = Console.ReadKey(true);
            switch (taste.Key)
            {
                case ConsoleKey.W:
                    held.Move(IMoveable.Richtung.EForward);
                    break;
                case ConsoleKey.S:
                    held.Move(IMoveable.Richtung.EBackward);
                    break;
                case ConsoleKey.A:
                    held.Move(IMoveable.Richtung.ELeft);
                    break;
                case ConsoleKey.D:
                    held.Move(IMoveable.Richtung.ERight);
                    break;
                case ConsoleKey.Q:
                    spielLaeuft = false;
                    Console.WriteLine("Spiel wurde beendet.");
                    break;
            }

            if (!held.IsAlive())
            {
                Console.WriteLine("Der Held ist gestorben. Game Over.");
            }

            if (held.Standort is ZielRaum)
            {
                Console.WriteLine("Spiel erfolgreich beendet!");
                break;
            }
        }
    }
}


    
