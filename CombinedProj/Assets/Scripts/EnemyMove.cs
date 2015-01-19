using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public float tspeed;
	public float mspeed;

	void Update () 
	{
		float x = tspeed * Time.deltaTime;
		transform.Rotate (0, x, 0);
		float y = mspeed * Time.deltaTime;
		transform.Translate (0, 0, y);
	}
}
