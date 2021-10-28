using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public int scoreValue;
    public static int score;
    public static int highscore;
    private TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        highScoreText = GameObject.Find("highScoreText").GetComponent<TextMeshProUGUI>();

        highscore = 0;

        highscore = PlayerPrefs.GetInt("highscore", highscore);
        highScoreText.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue > highscore)
        {
            highscore = scoreValue;
            highScoreText.text = "High Score:" + highscore.ToString();

        }
    }

    public void UpdateScore()
    {
        //scoreValue += 5;
        scoreText.text = "Score:  " + scoreValue.ToString();
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void Reset()
    {
        score = 0;
    }
}
