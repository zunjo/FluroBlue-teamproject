using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	public Material red;
	public Material green;
	public Material white;
	public Material down;

	void OnMouseEnter()       
	{      
		renderer.material = red;
			
	}
	void OnMouseExit()       
	{      
		renderer.material = white;
		
	}

	void OnMouseDown()
	{
		renderer.material = down;
	}

	void OnMouseUpAsButton()
	{
		renderer.material = green;
	}
}

