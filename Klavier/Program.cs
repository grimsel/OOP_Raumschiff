using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        KlavierVorlage mySteinway = new KlavierVorlage();
        mySteinway.musiziere();
        mySteinway.deckelOeffnen();
        mySteinway.musiziere();
    }
}


class KlavierVorlage
{
    string[] tasten = { "c", "d" };
    string lied1 = "Oh when the saint's...";
    bool deckelOffen = false;


    public void deckelOeffnen()
    {
        Console.WriteLine("öffne Deckel...");
        deckelOffen = true;
    }

    public void deckelSchliessen()
    {
        deckelOffen = false;
    }

    public void musiziere() 
    {
        Console.WriteLine("Ich erhalte die Anweisung zu musizieren"); 
        if (deckelOffen) { Console.WriteLine(lied1); } else { Console.WriteLine("Kann nicht musizieren, da Deckel zu"); }
    }
    
}
