using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    //Variables
    public TextMeshProUGUI timer;

    private float timerNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        //timerNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Make a timer
        timerNum += Time.deltaTime;

        //Make the timer show up in the UI
        timer.text = " " + (int)(10 - timerNum);

        //Make it so that after 10 seconds the timer "stops"
        if (timerNum < 10)
        {

        }
        else
        {
            timer.text = "Slow ahh mf";
        }
    }
}
