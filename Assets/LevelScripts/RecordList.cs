using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordList : MonoBehaviour
{

    public TextMeshProUGUI pl1;
    public TextMeshProUGUI pl2;
    public TextMeshProUGUI pl3;
    public TextMeshProUGUI pl4;
    public TextMeshProUGUI pl5;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        pl1.text = "1. " + PlayerPrefs.GetInt("Highscore1");
        pl2.text = "2. " + PlayerPrefs.GetInt("Highscore2");
        pl3.text = "3. " + PlayerPrefs.GetInt("Highscore3");
        pl4.text = "4. " + PlayerPrefs.GetInt("Highscore4");
        pl5.text = "5. " + PlayerPrefs.GetInt("Highscore5");
    }
}
