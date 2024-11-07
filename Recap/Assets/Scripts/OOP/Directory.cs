using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class Directory : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI displayText;

    public List<Organism> organisms;

    private int recordNum = 0;

    private void Start()
    {
        organisms = new List<Organism>();
        Organism first = new Organism("Carbon based being");
        Organism second = new Mammal("Carbon based being", "Newborns are not in eggs", true);
        Organism third = new Humans("Carbon based being", "Newborns are not in eggs", true, true, "This human speaks the required language", true);
        Organism fourth = new Individual("Justin", "This individual has black hair", "Carbon based being", "Newborns are not in eggs", true, true, "This human speaks the required language", true);

        organisms.Add(first);
        organisms.Add(second);
        organisms.Add(third);
        organisms.Add(fourth);

        UpdateRecord();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && recordNum < organisms.Count)
        {
            UpdateRecord();
        }
    }

    void UpdateRecord()
    {
        Organism currentThing = organisms[recordNum % organisms.Count];

        displayText.text = currentThing.showRecord();

        recordNum++;
    }
}
