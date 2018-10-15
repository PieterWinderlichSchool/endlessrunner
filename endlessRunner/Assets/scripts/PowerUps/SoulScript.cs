using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulScript : MonoBehaviour
{
    private static int add = 1;
    //make reference
    private ScoreScript score;
    private HealthScript health;

    // Use this for initialization
    void Start()
    {
        //reference
        health = FindObjectOfType<HealthScript>();
        score = FindObjectOfType<ScoreScript>();
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
            health.curHealth = health.curHealth + 1;
            Object.Destroy(gameObject);
        }
    }
}
