using UnityEngine;
using System.Collections;

public class CrazySpinner : MonoBehaviour 
{
	public float speed;
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (10, 10, 10) * speed);
	}
}
