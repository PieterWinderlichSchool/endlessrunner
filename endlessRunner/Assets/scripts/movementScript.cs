using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {



	public float speed = 0; 
	public Rigidbody rb;
	public int jumpForce = 5;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	// Update is called once per frame
	void Update () {
		float xInput = Input.GetAxisRaw ("Horizontal");

		Vector3 moveDirection = new Vector3 (xInput, 0, 0);
		transform.Translate (moveDirection * speed * Time.deltaTime);

		if (Input.GetKey (KeyCode.D)) {
			speed = 3;
			if (Input.GetKey (KeyCode.Z)) {
				speed = 6;
			} else {
				speed = 3;
			}

	}
		else{
			speed = 0;
		}
		if(Input.GetKey (KeyCode.Space)){
			rb.AddForce(new Vector2(0, jumpForce));
		}
			
}
}
