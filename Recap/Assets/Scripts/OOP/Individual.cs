using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Individual : Humans
{
    //Variables
    public string name;

    public string hairColor;

    //Make individual a subclass of humans
    public Individual(string name, string hairColor, string carbon, string newBorns, bool milkProduction, bool extremeSweating, string speakingLanguage, bool criticalBrainStuff) :
        base(carbon, newBorns, milkProduction, extremeSweating, speakingLanguage, criticalBrainStuff)
    {
        this.name = name;
        this.hairColor = hairColor;
        this.type = "Individual";
    }

    //Update the info
    public override string showRecord()
    {
        return base.showRecord() + "Name: " + name + "\n" + "Hair Color: " + hairColor + "\n";
    }
}
