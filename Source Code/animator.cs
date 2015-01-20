using UnityEngine;
using System.Collections;

public class animator : MonoBehaviour {

	public Transform player;
	public AnimationClip run;
	public AnimationClip jump;
	public AnimationClip idle;

	void Start (){

		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update () {

		if (Input.GetKeyDown ("w") && player.gameObject.GetComponent<Move> ().standing == true) 
		{
			animation.Play ("run");
		} 

		if(Input.GetKeyUp ("w") && player.gameObject.GetComponent<Move>().standing == true)
		{
			animation.Play ("idle");
		}

		if(Input.GetKeyDown ("s") && player.gameObject.GetComponent<Move>().standing == true)
		{
			animation.Play ("run");
		}

		if(Input.GetKeyUp ("s") && player.gameObject.GetComponent<Move>().standing == true)
		{
			animation.Play ("idle");
		}

		if (Input.GetKeyUp ("space")) 
		{
			animation.Play ("jump");
			
		}
	}
	void OnTriggerEnter()
	{
		animation.Play ("idle");
	}
}
