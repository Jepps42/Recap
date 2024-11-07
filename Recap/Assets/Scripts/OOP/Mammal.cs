using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Organism
{
    //Variables
    public bool milkProduction;

    public string newBorns;

    //Make Mammal a subclass
    public Mammal(string carbon, string newborns, bool milkProduction) : 
        base(carbon)
    {
        this.newBorns = newborns;
        this.milkProduction = milkProduction;
        this.type = "Mammal";
    }

    public override string showRecord()
    {
        return base.showRecord() + "Milk Production: " + milkProduction + "\n" + "Newborns: " + newBorns + "\n";
    }

   
}
