using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public bool standing;
	public bool jumping;
	public float upforce;
	public float forwardforce;
	public float mspeed; 
	public float tspeed; 
	public bool IsWalking;

	void Start()
	{
		standing = true;
		jumping = false;
		upforce = 500;
		forwardforce = 500;
		mspeed = 10;
		tspeed = 150;
		IsWalking = false;
	}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.transform.tag == "Ground" || coll.transform.tag == "pad") 
		{
			jumping = false;
			standing = true;
		}
		if (coll.transform.tag == "NavPoint") 
		{
			jumping = false;
			standing = true;
			coll.transform.tag = "Ground";
			GameObject navPoint = GameObject.Find ("Scorer");
			ScorerScript navTotal = navPoint.GetComponent<ScorerScript> ();
			navTotal.SubNavPoints ();
		}
		if (coll.transform.tag == "Enemy") 
		{
			GameObject deadplayer = GameObject.FindGameObjectWithTag ("Player"); // kills the player
			Destroy (deadplayer);
		}
		if (coll.transform.tag == "Water") 
		{
			GameObject deadplayer = GameObject.FindGameObjectWithTag ("Player"); // kills the player
			Destroy (deadplayer);
		}
	}

	void OnCollisionExit(Collision coll)
	{
		if (coll.transform.tag == "Ground" || coll.transform.tag == "pad") 
		{
			standing = false;
		}
		if (coll.transform.tag == "NavPoint") 
		{
			standing = false;
		}
	}

	void Update ()
	{
		if (standing) 
		{
			float y = Input.GetAxis ("Horizontal") * tspeed * Time.deltaTime;
			transform.Rotate (0, y, 0);
			float x = Input.GetAxis ("Vertical") * mspeed * Time.deltaTime;
			transform.Translate (x, 0, 0);
		}

		if (Input.GetKeyDown ("space") && standing == true) 
		{
			rigidbody.velocity.Set (0, 0, 0);
			jumping = true;
		} 

		if (jumping) 
		{
			rigidbody.AddForce (transform.up * upforce);
			rigidbody.AddForce (transform.right * forwardforce);
			standing = false;
			jumping = false;
		}

	}
}
