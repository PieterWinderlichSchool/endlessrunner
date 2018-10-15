using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornScript : MonoBehaviour
{
    private static int add = 5;
    //make reference
    private ScoreScript score;
    private HealthScript health;

    // Use this for initialization
    void Start()
    {
        //reference
        score = FindObjectOfType<ScoreScript>();
        health = FindObjectOfType<HealthScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //use reference
            score.AddScore(add);
            health.curHealth = health.curHealth + 2;
            Object.Destroy(gameObject);
        }
    }
}
