using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Transform spawnerLocation;
	public GameObject enemy;
	public GameObject wall;
	public GameObject key;
	GameObject enemyClone;
	GameObject wallClone;
	GameObject keyClone;

	void Start () {
	
	}

	void Update () {


	}

	void OnTriggerEnter() {
		for (int i = 0; i < 9; i++) {
			enemyClone = (GameObject)Instantiate (enemy, new Vector3 (spawnerLocation.position.x - 20F + (i * 5), spawnerLocation.position.y, spawnerLocation.position.z + 20.0F), enemy.transform.rotation);
			if (i == 8)
				keyClone = (GameObject)Instantiate (key, new Vector3 (spawnerLocation.position.x - 20F + (i * 5), spawnerLocation.position.y + 1.5F, spawnerLocation.position.z + 20.0F), key.transform.rotation);
		}
		wallClone = (GameObject) Instantiate (wall, new Vector3 (spawnerLocation.position.x, spawnerLocation.position.y + 1.5F, spawnerLocation.position.z - 25.33F), wall.transform.rotation);
		wallClone = (GameObject) Instantiate (wall, new Vector3 (spawnerLocation.position.x - 25.45F, spawnerLocation.position.y + 1.5F, spawnerLocation.position.z), Quaternion.Euler (0, 90, 0));

		Destroy (this.gameObject);
		Destroy (GameObject.FindGameObjectWithTag ("Spawner2"));
	}
}
