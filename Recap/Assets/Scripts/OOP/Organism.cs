using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organism 
{
    //Variables

    public string carbon;
    
    public string type;

    //Make the organism a class
    public Organism(string carbon)
    {
        //Add the carbon and the type
        this.carbon = carbon;
        type = "Organism";
    }

    //show the record of this class to be a carbon based organism
    public virtual string showRecord()
    {
        return
            "Type: " + type + "\n" + "Carbon: " + carbon + "\n";
    }
}
