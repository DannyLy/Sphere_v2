using UnityEngine;
using System.Collections;


public class CameraFollow : MonoBehaviour {
	
	public float turnSpeed;
	public Transform player;
	
	public float height;
	public float distance;
	
	private Vector3 offX;
	private Vector3 offY;
	
	private Vector3 eulerAngles;
	
	void Start () {
		
		offX = new Vector3 (0, height, distance);
		offY = new Vector3 (0, 0, distance);
		
		eulerAngles.x = 30;
	}
	
	void LateUpdate()
	{
		//offX = Quaternion.AngleAxis (Input.GetAxis("Horizontal") * turnSpeed, Vector3.up) * offX;
		//offY = Quaternion.AngleAxis (Input.GetAxis("Vertical") * turnSpeed, Vector3.right) * offY;
		//transform.position = player.position + offX;
		eulerAngles.y += Input.GetAxis ("HorizontalM") * turnSpeed * Time.deltaTime;
		transform.position = player.position - Quaternion.Euler (eulerAngles) * (10 * Vector3.forward);
		transform.LookAt(player.position);
	}
}