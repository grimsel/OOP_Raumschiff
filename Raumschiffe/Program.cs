﻿class Program
{
    static void Main(string[] args)
    {
        // Create an object of type RaumschiffVorlage.
        RaumschiffVorlage raumschiffEins = new RaumschiffVorlage();

        raumschiffEins.gebeName("alba");
        raumschiffEins.zeigeStatus();
    }
}