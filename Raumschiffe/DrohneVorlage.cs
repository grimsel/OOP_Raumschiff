using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Drohnen gehen im Vergleich zum Standard-Raumschiff mehr Risiken ein und sind dfür schneller. Also weniger Panzerung (“leben”), 
// ein schwächeres Schutzschild (“schild”), aber eine erhöhte Geschwindigkeit.
 class DrohneVorlage : RaumschiffVorlage
    {
    //uebermittlungskanal für Fernsteuerung. Eine Störung der Übertragung könnte Schaden anrichten. 
    int kanal = 3;
    //Konstruktor der Klasse 'DrohneVorlage'. 
    //Diese Methode wird durchlaufen sobald eine Instanz von DrohneVorlage erzeugt wird.
    public DrohneVorlage()
    {
        //Die Geschwindigkeit, definert in der Basisklasse 'Raumschiffvorlage' wird hier verändert.
        //Die Geschwindigkeit ist hier nur sichtbar/änderbar, weil sie in der Basisklasse nicht mehr privat, sondern protected ist.
        //Dasselbe gilt für schild und leben
        geschwindigkeit = 8;
        schild = 1;
        leben = 8;
    }
    public void zeigeKanal()  { if (this.leben > 0) Console.WriteLine("..und Kanal:{0}", this.kanal); }
}
