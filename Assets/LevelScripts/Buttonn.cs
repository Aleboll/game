using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonn : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        PlayerPrefs.SetInt("Highscore1", 0);
        PlayerPrefs.SetInt("Highscore2", 0);
        PlayerPrefs.SetInt("Highscore3", 0);
        PlayerPrefs.SetInt("Highscore4", 0);
        PlayerPrefs.SetInt("Highscore5", 0);
        //PlayerPrefs.SetString("Highscorename1", " ");
        //PlayerPrefs.SetString("Highscorename2", " ");
        //PlayerPrefs.SetString("Highscorename3", " ");
        //PlayerPrefs.SetString("Highscorename4", " ");
        //PlayerPrefs.SetString("Highscorename5", " ");

    }
}
