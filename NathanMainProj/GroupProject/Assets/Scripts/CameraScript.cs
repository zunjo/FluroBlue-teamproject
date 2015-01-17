using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	void Update () 
	{
		if (Input.GetKeyDown ("c"))
		{
			transform.Translate (0, -10, 0);
			transform.Rotate (-45, 0, 0);
		}
		if (Input.GetKeyUp("c"))
		{
			transform.Rotate (45, 0, 0);
			transform.Translate (0, 10, 0);
		}
	}
}
