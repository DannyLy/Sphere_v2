using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {

	public GameObject backgroundMusic;

	void Awake(){
		//check for music
		backgroundMusic = GameObject.Find ("MUSIC");
		if (backgroundMusic == null) {
			//set object if does not exist
			backgroundMusic = this.gameObject;
			//rename to music
			backgroundMusic.name = "MUSIC";
			//dont destroy when changing scenes
			DontDestroyOnLoad (backgroundMusic);
		} else {
			if(this.gameObject.name!="MUSIC"){
				//destroy if duplicate
				Destroy(this.gameObject);
			}
		}
	}

}
