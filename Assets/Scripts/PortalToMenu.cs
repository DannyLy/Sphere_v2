using UnityEngine;
using System.Collections;

public class PortalToMenu : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	//chances scene on collision
	void OnTriggerEnter() {
		Application.LoadLevel ("Level_3");
	}
}

