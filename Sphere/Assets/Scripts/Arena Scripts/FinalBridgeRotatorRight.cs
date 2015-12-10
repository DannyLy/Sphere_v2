using UnityEngine;
using System.Collections;

public class FinalBridgeRotatorRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (-0.4F, 0, 0));
	}
}
