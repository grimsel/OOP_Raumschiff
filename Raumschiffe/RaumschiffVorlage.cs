using System;

    class RaumschiffVorlage
    {
        int geschwindigkeit = 5;
        string name;

        public void gebeName(string neuerName)
        {
            this.name = neuerName;
        }
        public void zeigeStatus()
        {
            Console.WriteLine("{0} hat speed {1}", this.name, this.geschwindigkeit);
        }
    }

