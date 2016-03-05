using System;

    class RaumschiffVorlage
    {
        int geschwindigkeit = 5;
        string name;

    // Diese Methode gibt dem Raumschiff einen Namen.
    public void setzeNamen(string neuerName)
        {
            this.name = neuerName;
        }

        // Diese Methode gibt Informationen aus zum Raumschiff, z.B. Name und Geschwindigkeit.
        public void zeigeStatus()
        {
            Console.WriteLine("{0} hat speed {1}", this.name, this.geschwindigkeit);
        }
    }

