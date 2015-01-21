using UnityEngine;
using System.Collections;

public class HazardPad : MonoBehaviour {
	
	public float timer; // counts down
	public float delay; // sets interval time for submerge/raise
	public float speed; // multiplies rate of timer decay
	public bool submerged;

	void Start()
	{
		submerged = false;
	}

	void Update () 
	{
		timer -= speed * Time.deltaTime;
		
		if (timer <= 0 && !submerged) // submerges lilypads 
		{
			timer = delay;
			transform.Translate (0, -2, 0);
			submerged = true;
		} 
		if (timer <= 0 && submerged) // raises lilypads
		{
			timer = delay;
			transform.Translate (0, 2, 0);
			submerged = false;
		}
	}
}
