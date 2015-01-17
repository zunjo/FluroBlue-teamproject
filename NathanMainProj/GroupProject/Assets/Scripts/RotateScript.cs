using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

	public float RotationSpeed;

	void Update () 
	{
		float x = RotationSpeed * Time.deltaTime;
		transform.Rotate (0, x, 0);
	}
}
