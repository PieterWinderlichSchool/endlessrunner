using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaloScript : MonoBehaviour
{
    private static int add = -2;
    //make reference
    private ScoreScript score;
    private HealthScript health;
    private FollowTarget camera;

    // Use this for initialization
    void Start()
    {
        //reference
        score = FindObjectOfType<ScoreScript>();
        health = FindObjectOfType<HealthScript>();
        camera = FindObjectOfType<FollowTarget>();
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
            health.curHealth = (health.curHealth - 5);
            camera.ShakeCamera(0.1f, 1);
            Object.Destroy(gameObject);
        }
    }
}
