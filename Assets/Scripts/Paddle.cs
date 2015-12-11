using UnityEngine;
using System.Collections;

[RequireComponent (typeof (GunController))]
public class Paddle : MonoBehaviour {

	private Vector3 pos = new Vector3 (5,-1,2);
	public float speed = 1000F;
	public float jumpSpeed = 10.0F;
	public float gravity = 10.0F;
	public Rigidbody rb;
	public Camera camera;
	public bool isGrounded;
	private float timer = 0;
	public float airSpeed = 1000f;
	public int checkpoint = 0;
	public int checkpoint2 = 0;
	public int checkpoint3 = 0;
	public AudioClip jumpingsound;
	private AudioSource source;
	public AudioClip checkpointsound;
	public AudioClip metalbang;
	public AudioClip lootsound;

	//Arena Shooter
	GunController gunShooter;

	void Start(){
		rb = GetComponent <Rigidbody> ();
		source = GetComponent<AudioSource>();
		gunShooter = GetComponent<GunController> ();
		//Screen.lockCursor = true;
	}

	void Update ()
	{
		if(Input.GetMouseButton(0)){
			gunShooter.Shoot();
		}
	}


	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);
		movement = Camera.main.transform.TransformDirection (movement);
		movement.y = 0;
		//movement *= (Mathf.Abs (movement.x) == 1 && Mathf.Abs (movement.z) == 1) ? .7f : 1;

		if (isGrounded == true) {
			rb.AddForce (movement * speed * Time.deltaTime);
		} else if (isGrounded == false) {
			rb.AddForce (movement * airSpeed * Time.deltaTime);
		}
		if (Input.GetButton ("Jump") && isGrounded == true) {
			source.PlayOneShot(jumpingsound,1F);
			Vector3 jumping = new Vector3 (0, jumpSpeed, 0);
			rb.AddForce (jumping);

		}

		if (transform.position.y < -10 && Application.loadedLevelName == "Level_Endless") {
			Application.LoadLevel("DeadScreen");
		}
		 if(transform.position.y <-10 && checkpoint == 1)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3(1.694f,4.6f,-4f);
		}
		else if(transform.position.y <-10 && checkpoint == 2)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3(3.45f,-2.7f,38f);
		}
		else if (transform.position.y < -10 && checkpoint == 3)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (13f, 2f, 58f);
		}
		else if (transform.position.y < -10 && checkpoint == 4)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (25f, 2f, 75f);
		}
		else if (transform.position.y < -10 && checkpoint == 5)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (35f, -7.63f, 104f);
		}
		else if (transform.position.y < -10 && checkpoint2 == 1)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (28.4F, 15f, .5f);
		} 
		else if (transform.position.y < -10 && checkpoint2 == 2)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (-12.85F, 15f, -28.82f);
		} 
		else if(transform.position.y < -10 && checkpoint2 == 3)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (28.4F, 15f, -39.1f);
		} 
		else if(transform.position.y < -10 && checkpoint3 == 1)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (60.7F, 5.52f, 90f);
		} 
		else if(transform.position.y < -10 && checkpoint3 == 2)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (90F, 5.52f, 120f);
		} 
		else if(transform.position.y < -10 && checkpoint3 == 3)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (120F, 5.52f, 90f);
		} 
		else if(transform.position.y < -10 && checkpoint3 == 4)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (141F, 5.52f, 60f);
		} 
		if (transform.position.y < -10) {
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (0, 2, 0);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "bigboss" || (other.gameObject.tag == "Enemy" && checkpoint3 == 4))
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (266F, 9f, 60f);
			rb.velocity = Vector3.zero;
		}
		if (other.gameObject.tag == "Checkpoint") {
			other.gameObject.SetActive (false);
			checkpoint++;
			source.PlayOneShot(checkpointsound,1F);
		}
		if (other.gameObject.tag == "Checkpoint2")
		{
			other.gameObject.SetActive(false);
			checkpoint2++;
			source.PlayOneShot(checkpointsound,1F);
		}
		if (other.gameObject.tag == "Checkpoint3")
		{
			other.gameObject.SetActive(false);
			checkpoint3++;
			source.PlayOneShot(checkpointsound,1F);
		}
		if (other.gameObject.tag == "Cheatwall1")
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (0F, 5.52f, 30.3f);
		}
		if (other.gameObject.tag == "Boost") 
		{
			rb.AddForce ( Camera.main.transform.TransformDirection (new Vector3(0,0,1000))); //adding force with the direction of camera
		}
		if (other.gameObject.tag == "Enemy") 
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (60F, 7f, 60f);
			rb.velocity = Vector3.zero;
		}
		if (other.gameObject.tag == "bigboss" || (other.gameObject.tag == "Enemy" && checkpoint3 == 4))
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (266F, 7f, 60f);
			rb.velocity = Vector3.zero;
		}

		///*** KEY AND DOOR TRIGGERS ***\\\

		if (other.gameObject.tag == "Dungeon2Key") {
			Destroy (GameObject.FindGameObjectWithTag("Dungeon2Key"));
			Destroy (GameObject.FindGameObjectWithTag("Dungeon2Gate"));
		}

		if (other.gameObject.tag == "Dungeon4Key") {
			Destroy (GameObject.FindGameObjectWithTag("Dungeon4Key"));
			Destroy (GameObject.FindGameObjectWithTag("Dungeon4Gate"));
		}

		if (other.gameObject.tag == "Dungeon5Key") {
			Destroy (GameObject.FindGameObjectWithTag("Dungeon5Key"));
			Destroy (GameObject.FindGameObjectWithTag("Dungeon5Gate"));
		}

		if (other.gameObject.tag == "Dungeon6Key") {
			Destroy (GameObject.FindGameObjectWithTag("Dungeon6Key"));
			Destroy (GameObject.FindGameObjectWithTag("Dungeon6Gate"));
		}

		if (other.gameObject.tag == "Dungeon7Key") {
			Destroy (GameObject.FindGameObjectWithTag("Dungeon7Key"));
			Destroy (GameObject.FindGameObjectWithTag("Dungeon7Gate"));
		}

		if (other.gameObject.tag == "Dungeon8Key") {
			Destroy (GameObject.FindGameObjectWithTag("Dungeon8Key"));
			Destroy (GameObject.FindGameObjectWithTag("Dungeon8Gate"));
		}
	}
	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Trap") {
			source.PlayOneShot (metalbang, 1F);
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (13.05f, 2.27f, 58f);
		} else if (collisionInfo.gameObject.tag == "Trap2") {
			source.PlayOneShot (metalbang, 1F);
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (-12.85F, 15f, -28.82f);
		} else if (collisionInfo.gameObject.tag == "Trap3") {
			source.PlayOneShot (metalbang, 1F);
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (28.4F, 15f, -39.1f);
		}
		 else if (collisionInfo.other.gameObject.tag == "Cheatwall1")
		{
			source.PlayOneShot (metalbang, 1F);
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (0F, 5.52f, 30.3f);
		}
		else if (collisionInfo.other.gameObject.tag == "redthing")
		{
			source.PlayOneShot (metalbang, 1F);
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (90F, 5.52f, 120f);
		}
		if (collisionInfo.gameObject.tag == "Key"  || collisionInfo.gameObject.tag == "Dungeon2Key" || 
		    collisionInfo.gameObject.tag == "Dungeon5Key" || collisionInfo.gameObject.tag == "Dungeon6Key" ||
		    collisionInfo.gameObject.tag == "Dungeon7Key" || collisionInfo.gameObject.tag == "Dungeon8Key" || 
		    collisionInfo.gameObject.tag == "Shotgun" || collisionInfo.gameObject.tag == "Target") {
			source.PlayOneShot(lootsound, 1F);
		}

		if (collisionInfo.other.gameObject.tag == "redthing")
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (90F, 5.52f, 120f);
		}
	

		if (collisionInfo.gameObject.tag == "Ground") {
			isGrounded = true;
		}
	}
	void OnCollisionStay (Collision collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Ground") {

			isGrounded = true;
		}
	}
	void OnCollisionExit (Collision collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Ground") {
			
			isGrounded = false;
		}
	}
}

