using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songPicker : MonoBehaviour {



	public SliderVolume musicManager;

	public AudioSource source;


	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if (!source.isPlaying) {
			int randomIndex = randomNumber (0, musicManager.clips.Count);
			source.clip = musicManager.clips[randomIndex];
			source.Play ();




		}



	}
	public int randomNumber(int min, int max){
		return Random.Range (min, max);; 
	}
}
