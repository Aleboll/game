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
    [SerializeField] TextMeshProUGUI InputText;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    // Update is called once per frame PlayerPrefs.SetInt("Highscore", ScoreCounte.Instance.Score);
    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();
        if (timeStart<=0)
        {
            SceneManager.LoadScene(2);

            if (ScoreCounte.Instance.Score > PlayerPrefs.GetInt("Highscore5"))
            {
                if (ScoreCounte.Instance.Score > PlayerPrefs.GetInt("Highscore4"))
                {
                    if (ScoreCounte.Instance.Score > PlayerPrefs.GetInt("Highscore3"))
                    {
                        if (ScoreCounte.Instance.Score > PlayerPrefs.GetInt("Highscore2"))
                        {
                            if (ScoreCounte.Instance.Score > PlayerPrefs.GetInt("Highscore1"))
                            {
                                
                                PlayerPrefs.SetInt("Highscore5", PlayerPrefs.GetInt("Highscore4"));

                                //PlayerPrefs.SetString("Highscorename5", PlayerPrefs.GetString("Highscorename4"));

                                PlayerPrefs.SetInt("Highscore4", PlayerPrefs.GetInt("Highscore3"));

                                //PlayerPrefs.SetString("Highscorename4", PlayerPrefs.GetString("Highscorename3"));

                                PlayerPrefs.SetInt("Highscore3", PlayerPrefs.GetInt("Highscore2"));

                               //PlayerPrefs.SetString("Highscorename3", PlayerPrefs.GetString("Highscorename2"));

                                PlayerPrefs.SetInt("Highscore2", PlayerPrefs.GetInt("Highscore1"));

                                //PlayerPrefs.SetString("Highscorename2", PlayerPrefs.GetString("Highscorename1"));

                                PlayerPrefs.SetInt("Highscore1", ScoreCounte.Instance.Score);

                                //PlayerPrefs.SetString("Highscorename1", InputText.text);
                            }

                            else
                            {
                                PlayerPrefs.SetInt("Highscore5", PlayerPrefs.GetInt("Highscore4"));

                                //PlayerPrefs.SetString("Highscorename5", PlayerPrefs.GetString("Highscorename4"));

                                PlayerPrefs.SetInt("Highscore4", PlayerPrefs.GetInt("Highscore3"));

                                //PlayerPrefs.SetString("Highscorename4", PlayerPrefs.GetString("Highscorename3"));

                                PlayerPrefs.SetInt("Highscore3", PlayerPrefs.GetInt("Highscore2"));

                                //PlayerPrefs.SetString("Highscorename3", PlayerPrefs.GetString("Highscorename2"));

                                PlayerPrefs.SetInt("Highscore2", ScoreCounte.Instance.Score);

                                //PlayerPrefs.SetString("Highscorename2", InputText.text);
                            }
                        }

                        else
                        {
                            PlayerPrefs.SetInt("Highscore5", PlayerPrefs.GetInt("Highscore4"));

                            //PlayerPrefs.SetString("Highscorename5", PlayerPrefs.GetString("Highscorename4"));

                            PlayerPrefs.SetInt("Highscore4", PlayerPrefs.GetInt("Highscore3"));

                            //PlayerPrefs.SetString("Highscorename4", PlayerPrefs.GetString("Highscorename3"));

                            PlayerPrefs.SetInt("Highscore3", ScoreCounte.Instance.Score);

                            //PlayerPrefs.SetString("Highscorename3", InputText.text);
                        }
                    }

                    else
                    {
                        PlayerPrefs.SetInt("Highscore5", PlayerPrefs.GetInt("Highscore4"));

                        //PlayerPrefs.SetString("Highscorename5", PlayerPrefs.GetString("Highscorename4"));

                        PlayerPrefs.SetInt("Highscore4", ScoreCounte.Instance.Score);

                        //PlayerPrefs.SetString("Highscorename4", InputText.text);
                    }
                }

                else
                {
                    PlayerPrefs.SetInt("Highscore5", ScoreCounte.Instance.Score);

                    //PlayerPrefs.SetString("Highscorename5", InputText.text);
                }
            }
            
        }
    }
}
