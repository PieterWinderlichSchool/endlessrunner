using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public int curHealth;
    public int maxHealth = 100;
    private World world;

    Text health;

	// Use this for initialization
	void Start ()
    {
        health = GetComponent<Text>();
        curHealth = maxHealth;
        world = FindObjectOfType<World>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        health.text = "HEALTH: " + curHealth + "%";

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        if (curHealth <= 0)
        {
            world.KillPlayer();
        }
    }
}
