using System;

    class RaumschiffVorlage
    {
        //Das Attribut 'geschwindigkeit' erhält zu Beginn den Wert 5.
        int geschwindigkeit = 5;

        //Das Attribut 'schiffName' ist zu Beginn leer. Es ist absichtich so definiert, dass es von überall 
        //direkt angesprochen und verändert werden kann. Und zwar mit dem modifier 'public'
        public string schiffName;

        // Diese Methode gibt auf der Konsole Informationen aus zum Raumschiff, z.B. Name und Geschwindigkeit.
        public void zeigeStatus()
        {
            Console.WriteLine("{0} hat speed {1}", this.schiffName, this.geschwindigkeit);
        }
    }

