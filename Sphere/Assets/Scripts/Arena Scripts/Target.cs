using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		Destroy (GameObject.FindGameObjectWithTag ("Dungeon3Gate"));
		Destroy (GameObject.FindGameObjectWithTag ("Target"));
	}
}
