using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int scoreValue = 0;
    public int add;
    private int curHealth;
    Text score;
    private FollowTarget camera;
    private HealthScript health;
    Text hp;

    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();
        hp = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "SCORE: " + scoreValue; 
    }


    public void AddScore(int add)
    {
        if (add == 1)
        {
            //soul
            scoreValue = scoreValue + 1;
        }
        else if (add == 5)
        {
            //devil horn
            scoreValue = scoreValue + 5;

        }
        else if (add == 12)
        {
            //pick of destiny
            scoreValue = scoreValue + 12;
        }
        else if (add == -2)
        {
            //halo
            scoreValue = scoreValue - 2;
        }
        else if (add == -7)
        {
            //cross
            scoreValue = scoreValue - 7;
        }
        else if (add == -15)
        {
            //bible
            scoreValue = scoreValue - 15;
                      
        }
    }

    /*void SetScoreText ()
    {
        scoreText.text = "Score: " + score.ToString();
    } */

    public void resetScore()
    {
        scoreValue = 0;
    }
}
