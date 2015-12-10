using UnityEngine;
using System.Collections;

public class MovingWall : MonoBehaviour 
{
	public float speed;
	public float x;
	public float y;
	public float z;
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (x, y, z) * speed);
	}
}
