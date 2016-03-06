using System;

    class RaumschiffVorlage
    {
        //Das Attribut 'geschwindigkeit' erhält zu Beginn den Wert 5
        int geschwindigkeit = 5;
        int schild = 2;
        int leben = 10;
        string schiffName;

        // Diese Methode gibt dem Raumschiff einen Namen
        public void setzeNamen(string neuerName)
        {
            this.schiffName = neuerName;
        }
        // Diese Methode gibt den Namen des Raumschiffs zurück
        public string gibmirNamen()
        {
            return this.schiffName;
        }

    // Diese Methode simuliert eine Kollision mit einem Asteoriden. Dabei der Wert 'Leben' neu berechnet.
    public void kollision(int aufprall)
        {
            //prüfe ob der Asteroid unser Schutzschild durchschlagen hat
            if (aufprall > this.schild )
            {
                //berechne den verbleibenden Aufprall nach der Dämpfung mit dem Schild
                int rest_aufprall = aufprall - this.schild;
                //reduziere die Lebenspunkte
                this.leben -= rest_aufprall;
                if (this.leben <= 0)
                {
                    Console.WriteLine("Raumschiff {0} wurde zerstört.", this.schiffName);
                }
            }
        //Der Teil des Aufpralls, welcher nicht durch das Schild aufgefangen werden konnte.
        }

    // Diese Methode gibt auf der Konsole Informationen aus zum Raumschiff, z.B. Name und Geschwindigkeit.
    public void zeigeStatus()
    {
        if (this.leben > 0)
        {
            Console.WriteLine("{0} hat speed {1} und noch {2} Leben", this.schiffName, this.geschwindigkeit, this.leben);
        }
        else
        {
            //Raumschiff gibts nicht mehr
        }
    }
    public bool exisitert()
    {
        return (this.leben > 0);
    }

} // class

