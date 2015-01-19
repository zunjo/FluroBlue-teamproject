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
	public GameObject title;
	public bool spawned = false;


	void OnCollisionEnter(Collision coll)
	{
		spawned = true;
		lily = true;
		Instantiate (no, no.transform.position, no.transform.rotation);
		Instantiate (yes, yes.transform.position, yes.transform.rotation);
		Instantiate (title, title.transform.position, title.transform.rotation);
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
			if(spawned)
			{
				GameObject[] mAsset = GameObject.FindGameObjectsWithTag("menu");
				
				foreach(GameObject obj in mAsset)
				{
					Destroy(obj);
				}
				spawned = false;
			}
			float speed2 = up2 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, pos2.position, speed2);
		}
	
}
}
