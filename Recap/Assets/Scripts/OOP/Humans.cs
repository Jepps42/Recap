using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humans : Mammal
{
    //Variables
    public bool extremeSweating;

    public string speakingLanguage;

    public bool criticalBrainStuff;


    public Humans(string carbon, string newBorns, bool milkProduction, bool criticalBrainStuff, string speakingLanguage, bool extremeSweating) : 
        base(carbon, newBorns, milkProduction)
    {
        this.criticalBrainStuff = criticalBrainStuff;
        this.speakingLanguage = speakingLanguage;
        this.extremeSweating = extremeSweating;
        this.type = "Humans";
    }

    public override string showRecord()
    {
        return base.showRecord() + "Critical Brain Stuff: " + criticalBrainStuff + "\n" + "Speaking Language: " + speakingLanguage + "\n" + "Extreme Sweating: " + extremeSweating;
    }

}
