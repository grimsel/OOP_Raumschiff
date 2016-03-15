using System;

class Program
{
    static void Main(string[] args)
    {
        KlavierVorlage mySteinway = new KlavierVorlage();
        KlavierVorlage mySabel =    new KlavierVorlage();
        mySteinway.musiziere();
        mySteinway.nameGeben("Steinway");
        mySteinway.deckelOeffnen();
        mySteinway.musiziere();
        mySabel.musiziere();
        Console.ReadKey(); //Tastendruck abwarten
    }
}


class KlavierVorlage
{
    //Attribute setzen
    string  AttrKlavierName = "Unbekannt"; //Die Vorlage kennt den Namen noch nicht
    string  AttrLied1 = "Oh when the saint's..."; //Dieses Lied soll musiziert werden
    bool    AttrDeckelOffen = false; //Zustand des Klavierdeckels:
                                     //true = offen; false=zu                 
    public void deckelOeffnen()
    {
        Console.WriteLine("Klavier " + AttrKlavierName + " öffnet den Deckel");
        AttrDeckelOffen = true;
    }

    public void deckelSchliessen()
    {
        AttrDeckelOffen = false;
    }

    public void musiziere() 
    {
        Console.WriteLine("Klavier "+AttrKlavierName+ " erhält die Anweisung zu musizieren");
        //Wenn der Klavierdeckel offen ist, soll das Lied ausgegeben werden, sonst eine Fehlermeldung.
        if (AttrDeckelOffen) { Console.WriteLine(AttrLied1); } else { Console.WriteLine("Kann nicht musizieren, da Deckel zu\n\r"); }
    }

    //Methode mit Eingabe-Parameter 'tempName'. Im Unterschied zu einem Attribut existiert 'tempName' nur kurze Zeit, 
    //naemlich waehrend dem Durchlauf dieser Methode.
    public void nameGeben(string tempName)
    {
        AttrKlavierName = tempName;
        Console.WriteLine("Klavier erhält den Namen "+ AttrKlavierName);
    }
} // Ende von class KlavierVorlage
