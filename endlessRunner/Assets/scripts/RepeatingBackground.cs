using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D bgCollider;
    private float bgHorizontalLength;

	// Use this for initialization
	void Start ()
    {
        bgCollider = GetComponent<BoxCollider2D>();
        bgHorizontalLength = bgCollider.size.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (transform.position.x < -bgHorizontalLength)
        {
            RepositionBG();
        }
	}

    private void RepositionBG()
    {
        Vector2 bgOffset = new Vector2(bgHorizontalLength * 2f, 0);
        transform.position = (Vector2) transform.position + bgOffset;
    }
}
