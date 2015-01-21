using UnityEngine;
using System.Collections;

public class deathzone : MonoBehaviour {

	public GameObject splash;
	public GameObject player;


	// Use this for initialization
	void OnCollisionEnter(Collision coll)
	{
		if (coll.transform.tag == "death") 
		{
			Destroy (player);
			GameObject obj = Instantiate (splash, transform.position, transform.rotation) as GameObject;
			Destroy (obj, 1f);
		}
	}
}