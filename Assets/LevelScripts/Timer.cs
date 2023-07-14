using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();
        if (timeStart<=0)
        {
            SceneManager.LoadScene(2);
            if (ScoreCounte.Instance.Score > ScoreCounte.Instance.HighScore)
            {
                PlayerPrefs.SetInt("Highscore", ScoreCounte.Instance.Score);
            }
            
        }
    }
}
