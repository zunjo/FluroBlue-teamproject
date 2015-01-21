using UnityEngine;
using System.Collections;

public class buttonReload : MonoBehaviour {

	public Material hover;
	public Material up;
	public Material neutral;
	public Material down;
	public string ReloadStage;

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
		Application.LoadLevel (ReloadStage); 
	}
}