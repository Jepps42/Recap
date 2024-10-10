using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{

    //Variables 
    public TextMeshProUGUI SaveText;

    private string inputText = "Sparking Zero GOTY";

    public string sTxt;

    //Create the filepath to the text document we are saving in
    private const string DIR_RES = "/Resources";

    private const string FILE_SAVEINFO = DIR_RES + "/SaveInfo.txt";

    private string FILE_PATH_INFO;
    // Start is called before the first frame update
    void Start()
    {
        //Application.dataPath automatically sends us to the file this game is on !!!!!!!!
        //Declare the file Path
        FILE_PATH_INFO = Application.dataPath + FILE_SAVEINFO;
        SaveText.text = inputText;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TextSave("Black Myth exists");
        }

        if (Input.GetKeyDown(KeyCode.S)) 
        {
            LoadText();
        }
    }

    private void TextSave(string text)
    {
        sTxt = text;
        string fileContents = File.ReadAllText(FILE_PATH_INFO);
        fileContents += sTxt + "\n";
        File.WriteAllText(FILE_PATH_INFO, fileContents);
    }

    public void LoadText()
    {
        string fileContents = File.ReadAllText(FILE_PATH_INFO);
        SaveText.text = fileContents;
    }
}
