using UnityEngine;
using System.Collections;

public class NavPointScript : MonoBehaviour {
		
	void Start () 
	{
		GameObject navPoint = GameObject.Find ("Scorer");
		ScorerScript navTotal = navPoint.GetComponent<ScorerScript> ();
		navTotal.AddNavPoints ();
	}
}
