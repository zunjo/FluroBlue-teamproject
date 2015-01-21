using UnityEngine;
using System.Collections;

public class animator : MonoBehaviour {

	public Transform player;
	public AnimationClip run;
	public AnimationClip jump;
	public AnimationClip idle;

	void Update () {

		if (Input.GetKeyDown ("w") || Input.GetKeyDown ("d") || Input.GetKeyDown ("a") || Input.GetKeyDown ("a")) 
		{
			animation.Play ("run");
		} 

		if(Input.GetKeyUp ("w"))
		{

			animation.Play ("idle");
		}

		if(Input.GetKeyDown ("s"))
		{
			animation.Play ("run");
		}

		if(Input.GetKeyUp ("s"))
		{
			animation.Play ("idle");
		}

		if (Input.GetKeyDown ("space")) 
		{
			animation.Play ("jump");
		}
	}
	void OnTriggerEnter()
	{
		animation.Play ("idle");
	}
}
