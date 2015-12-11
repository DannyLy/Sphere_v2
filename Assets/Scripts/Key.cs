using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
	
	void Start () {
		
	}
	
	void Update () {
		transform.Rotate (new Vector3 (0, 0, 0.5F));
	}
	
	void OnTriggerEnter() {
		Destroy (this.gameObject);
		Destroy (GameObject.FindGameObjectWithTag ("Door"));
	}
}