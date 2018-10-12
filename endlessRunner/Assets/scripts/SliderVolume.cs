using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SliderVolume : MonoBehaviour {
//Music


public Slider Volume;
public Slider Volume1;

public AudioSource myMusic;
public AudioSource myMusic1;

//Effects
	public List<AudioClip> clips = new List<AudioClip>();


	void Awake(){

		myMusic = GameObject.FindGameObjectWithTag("musicSource").GetComponent<AudioSource>();
		myMusic1 = GameObject.FindGameObjectWithTag("effectSource").GetComponent<AudioSource>();


	}
	// Update is called once per frame
	void Update () {
		//Music

		myMusic.volume = Volume.value;
		myMusic1.volume = Volume1.value;

		Debug.Log(Volume);
		//Effects



	}
}
