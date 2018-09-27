using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
		if (Input.GetKey(KeyCode.LeftControl))
		{

			animator.SetBool("isCrouching", true);


		}
		else
		{
			animator.SetBool("isCrouching", false);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{

			animator.SetTrigger("jumps");




		}
		if (Input.GetKeyDown(KeyCode.X))
		{
			animator.SetTrigger("rolls");
		}
	}
}
