using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humans : Mammal
{
    //Variables
    public bool extremeSweating;

    public string speakingLanguage;

    public bool criticalBrainStuff;

    //Make Humans a subclass of Mammals
    public Humans(string carbon, string newBorns, bool milkProduction, bool extremeSweating, string speakingLanguage, bool criticalBrainStuff) : 
        base(carbon, newBorns, milkProduction)
    {
        this.extremeSweating = extremeSweating;
        this.criticalBrainStuff = criticalBrainStuff;
        this.speakingLanguage = speakingLanguage;
        this.type = "Human";
    }

    public override string showRecord()
    {
        return base.showRecord() + "Sweat: " + extremeSweating + "\n" + "Speaking Language: " + speakingLanguage + "\n" + "Critical Thinking: " + criticalBrainStuff + "\n";
    }

}
