
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type RaumschiffVorlage.
        RaumschiffVorlage raumschiffEins = new RaumschiffVorlage();
        DrohneVorlage raumschiffZwei = new DrohneVorlage();

        raumschiffEins.setzeNamen("alba");
        raumschiffEins.zeigeStatus();
        raumschiffZwei.setzeNamen("duga");
        raumschiffZwei.zeigeStatus();

        int asteroidWucht;
        int runde = 1;
        Random Zufallszahlgenerator = new Random(); // initialisiert die Zufallsklasse

        // 10 Runden durchspielen. Hier aufpassen, dass nicht eine Runde zuviel oder zu wenig gespielt wird.
        while (runde <= 10)
        {
            Console.WriteLine("\n\r--- Runde {0} ---", runde);

            //--- RaumschiffEins ---
            if (raumschiffEins.exisitert())
            {
                // durchschnittlich jedes 3. Mal trifft ein Asteroid auf RaumschiffEins
                if (Zufallszahlgenerator.Next(1, 3) == 1)
                {
                    // erzeuge eine zufällige Wucht (Masse) des Asteroiden 
                    asteroidWucht = Zufallszahlgenerator.Next(1, 10);
                    // ..und simuliere die Kollision von Asteroid und Raumschiff 
                    Console.WriteLine("{0}: Kollision mit Wucht {1}", raumschiffEins.gibmirNamen(), asteroidWucht);
                    raumschiffEins.kollision(asteroidWucht);
                }
            }

            //--- RaumschiffZwei ---
            if (raumschiffZwei.exisitert())
            {
                // durchschnittlich jedes 3. Mal trifft ein Asteroid auf RaumschiffEins
                if (Zufallszahlgenerator.Next(1, 3) == 1)
                {
                    // erzeuge eine zufällige Wucht (Masse) des Asteroiden 
                    asteroidWucht = Zufallszahlgenerator.Next(1, 10);
                    // ..und simuliere die Kollision von Asteroid und Raumschiff 
                    Console.WriteLine("{0}: Kollision mit Wucht {1}", raumschiffZwei.gibmirNamen(), asteroidWucht);
                    raumschiffZwei.kollision(asteroidWucht);
                }
            }

            //--- Anzeige der Raumschiffe un ihren Stati ---
            raumschiffEins.zeigeStatus();
            raumschiffZwei.zeigeStatus();
            raumschiffZwei.zeigeKanal();

            runde++;
        }
    }
}
