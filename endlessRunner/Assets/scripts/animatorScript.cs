using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorScript : MonoBehaviour {


	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D))
		{


			animator.SetFloat("speed", 3);
			if (Input.GetKey(KeyCode.Z))
			{
				animator.SetFloat("speed", 6);
			}
			else
			{
				animator.SetFloat("speed", 3);
			}

		}
		else
		{
			animator.SetFloat("speed", 0);

		}

	}
}
