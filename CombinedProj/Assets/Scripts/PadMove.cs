using UnityEngine;
using System.Collections;

public class PadMove : MonoBehaviour {

	public float speed = 2;
	public float timer = 2;
	public float delay = 4;
	public bool moveforward = true;

	void Update () 
	{
		timer -= speed * Time.deltaTime;
		
		if (timer <= 0) 
		{
			timer = delay;
			moveforward = !moveforward;
		}
		
		if (moveforward == false) 
		{
			transform.Translate (-speed * Time.deltaTime, 0, 0);
		} 
		else
		{
			transform.Translate (speed * Time.deltaTime, 0, 0);
		}
		}

	}
