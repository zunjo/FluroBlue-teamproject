using UnityEngine;
using System.Collections;

public class button2 : MonoBehaviour {
	
	public Material hover;
	public Material up;
	public Material neutral;
	public Material down;

	
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
		Application.LoadLevel ("h"); 
	}
}