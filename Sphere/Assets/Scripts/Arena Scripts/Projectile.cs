using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	public LayerMask collisionMask;
	float speed = 10;
	float damage = 1;
	
	public void SetSpeed(float newSpeed) {
		speed = newSpeed;
	}
	
	void Update () {
		float moveDistance = speed * Time.deltaTime;
		CheckCollisions (moveDistance);
		transform.Translate (Vector3.forward * moveDistance);
		Destroy (this.gameObject, 3.0F);
	}
	
	
	void CheckCollisions(float moveDistance) {
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		
		if (Physics.Raycast(ray, out hit, moveDistance, collisionMask)) {
			OnHitObject(hit);
			//Debug.Log("hit");
		}
	}

	void OnHitObject(RaycastHit hit) {
		IDamagable damageableObject = hit.collider.GetComponent<IDamagable> ();
		if (damageableObject != null) {
			damageableObject.TakeHit(damage, hit);
		}
		GameObject.Destroy (gameObject);
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Wall" || col.gameObject.tag == "Dungeon2Gate") 
			Destroy (this.gameObject);

	} 



}