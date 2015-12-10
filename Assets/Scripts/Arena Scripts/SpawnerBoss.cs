using UnityEngine;
using System.Collections;

public class SpawnerBoss : MonoBehaviour {

	public Transform spawnerLocation;
	public GameObject enemy;
	public GameObject boss;
	public GameObject wall;
	public GameObject key;
	GameObject enemyClone;
	GameObject bossClone;
	GameObject wallClone;
	GameObject keyClone;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() {

		//Front line mobs
		for (int i = 0; i < 2; i++) {
			enemyClone = (GameObject)Instantiate (enemy, new Vector3 (spawnerLocation.position.x +60.0F, spawnerLocation.position.y, spawnerLocation.position.z - 20F + (i * 40)), enemy.transform.rotation);
		}

		//Side mobs
		for (int i = 0; i < 4; i++) {
			enemyClone = (GameObject)Instantiate (enemy, new Vector3 (spawnerLocation.position.x -10.0F + (i*20), spawnerLocation.position.y, spawnerLocation.position.z + 30.0F), enemy.transform.rotation);
			enemyClone = (GameObject)Instantiate (enemy, new Vector3 (spawnerLocation.position.x -10.0F + (i*20), spawnerLocation.position.y, spawnerLocation.position.z - 30.0F), enemy.transform.rotation);
		}

		//Boss spawn
		bossClone = (GameObject)Instantiate (boss, new Vector3 (spawnerLocation.position.x +60.0F, spawnerLocation.position.y, spawnerLocation.position.z), boss.transform.rotation);


		wallClone = (GameObject) Instantiate (wall, new Vector3 (spawnerLocation.position.x - 25.12F, spawnerLocation.position.y + 1.5F, spawnerLocation.position.z), Quaternion.Euler (0, 90, 0));
		Destroy (this.gameObject);

	}
}
