using UnityEngine;
using System.Collections;

public class lilly : MonoBehaviour {

	public GameObject waterspout;
	public Transform pos;
	public Transform pos2;
	public bool lily = false; 
	public float up;
	public float up2;
	public GameObject no;
	public GameObject yes;


	void OnCollisionEnter(Collision coll)
	{
		lily = true;
		Instantiate (no, no.transform.position, no.transform.rotation);
		Instantiate (yes, yes.transform.position, yes.transform.rotation);

	}

	void OnCollisionExit(Collision coll)
	{
		lily = false;

	}

	void Update()
	{

		if(lily)
		{
			float speed = up * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, pos.position, speed);
			GameObject obj = Instantiate (waterspout, transform.position, waterspout.transform.rotation) as GameObject;
			Destroy (obj, 0.4f);
		}
		else
		{

			float speed2 = up2 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, pos2.position, speed2);
		}
}
}
