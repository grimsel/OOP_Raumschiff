using System;

    class RaumschiffVorlage
    {
        //Das Attribut 'geschwindigkeit' erhält zu Beginn den Wert 5.
        int geschwindigkeit = 5;
        string schiffName;

        // Diese Methode gibt dem Raumschiff einen Namen.
        public void setzeNamen(string neuerName)
        {
            this.schiffName = neuerName;
        }

        // Diese Methode gibt auf der Konsole Informationen aus zum Raumschiff, z.B. Name und Geschwindigkeit.
        public void zeigeStatus()
        {
            Console.WriteLine("{0} hat speed {1}", this.schiffName, this.geschwindigkeit);
        }
    }

