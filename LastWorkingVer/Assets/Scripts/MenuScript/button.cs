using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	public Material hover;
	public Material up;
	public Material neutral;
	public Material down;
	public Transform lilypad;
	public Transform player;
	public float force;
	
	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		lilypad = GameObject.FindGameObjectWithTag ("pad").transform;
	
	}

	void OnMouseEnter()       
	{      
		renderer.material = hover;
			
	}
	void OnMouseExit()       
	{      
		renderer.material = neutral;
		
	}

	void OnMouseDown()
	{
		renderer.material = down;
	}

	void OnMouseUpAsButton()
	{
		renderer.material = up;
		lilypad.GetComponent<lilly>().lily = false;
		Destroy(this.gameObject);
	}
}

