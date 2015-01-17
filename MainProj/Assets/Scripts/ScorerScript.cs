using UnityEngine;
using System.Collections;

public class ScorerScript : MonoBehaviour {

	public int NavPointsLeft = 0;

	public void AddNavPoints ()
	{
		NavPointsLeft = 1 + NavPointsLeft;
	}

	public void SubNavPoints ()
	{
		NavPointsLeft = NavPointsLeft - 1;
	}

	void OnGUI()
	{
		Rect position = new Rect(0,0, 100, 100);
		GUI.color = Color.red;
		GUI.Label(position, "Points Left: " + NavPointsLeft.ToString());
	}
}
