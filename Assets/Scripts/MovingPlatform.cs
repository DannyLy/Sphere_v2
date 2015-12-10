using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	Vector3 direction;
	Transform destination;
	
	public GameObject movingPlatform;
	public Transform startTransform;
	public Transform endTransform;
	public float speed;
	
	void Start()
	{
		SetDestination(endTransform);
	}
	void FixedUpdate () 
	{
		movingPlatform.GetComponent<Rigidbody> ().MovePosition (movingPlatform.transform.position + direction * speed * Time.fixedDeltaTime);
		if(Vector3.Distance (movingPlatform.transform.position, destination.position) < speed * Time.fixedDeltaTime)
		{
			SetDestination (destination == startTransform ? endTransform : startTransform);
		}
	}
	
	void SetDestination(Transform dest)
	{
		destination = dest;
		direction = (destination.position - movingPlatform.transform.position).normalized;
	}
	
}
