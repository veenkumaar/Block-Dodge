using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreToText : MonoBehaviour
{
    private TMP_Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        highscoreText = GetComponent<TMP_Text>();

        if(PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("score"))
        {
            GlobalScoreManager.SaveHighScore(PlayerPrefs.GetInt("score"));
        }

        int highscore = PlayerPrefs.GetInt("HighScore");

        highscoreText.text = "HighScore: " + highscore.ToString();
    }

}
