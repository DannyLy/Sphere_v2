using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileScript : MonoBehaviour {

	private float fallDelay = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			TileGenerator.Instance.spawnTile();
			StartCoroutine(fallDown());
		}
	}

	//co routine to fall down after 2sec of crossing
	IEnumerator fallDown() {
		yield return new WaitForSeconds (fallDelay);
		GetComponent<Rigidbody> ().isKinematic = false;
		yield return new WaitForSeconds(3);
		switch (gameObject.name) {

		case "LeftTile":
			TileGenerator.Instance.LeftTiles.Push(gameObject);
			gameObject.GetComponent<Rigidbody>().isKinematic = true;
			gameObject.SetActive(false);
				break;

		case "TopTile":
			TileGenerator.Instance.TopTiles.Push(gameObject);
			gameObject.GetComponent<Rigidbody>().isKinematic = true;
			gameObject.SetActive(false);
			break;

		}
	}
}
