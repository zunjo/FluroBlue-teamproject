using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public bool standing = true;
	private bool jumping = false;
	public float force = 380;
	public float mspeed = 15;
	public float tspeed = 150;


	void OnCollisionEnter(Collision coll)
	{
		if (coll.transform.tag == "ground") 
		{
			standing = true;
		}
	}

	void Update ()
	{
		if (standing) 
		{
			float x = Input.GetAxis ("Horizontal") * tspeed * Time.deltaTime;
			transform.Rotate (0, x, 0);
			float y = Input.GetAxis ("Vertical") * mspeed * Time.deltaTime;
			transform.Translate (0, 0, y);
		}

		if (Input.GetKeyDown ("space") && standing == true) 
		{
			rigidbody.velocity.Set (0, 0, 0);
			jumping = true;

		} 

		if (jumping) 
		{
			rigidbody.AddForce (transform.up * force);
			rigidbody.AddForce (transform.forward * force);
			standing = false;
			jumping = false;
		}

	}
}
