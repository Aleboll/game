using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameOver : MonoBehaviour
{


    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Your final score is: " + ScoreCounte.Instance.Score;
    }
}
