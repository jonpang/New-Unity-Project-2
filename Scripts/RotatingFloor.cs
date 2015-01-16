using UnityEngine;
using System.Collections;

public class RotatingFloor : MonoBehaviour 
{
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (1, 0, 0) * Time.deltaTime);
	}
}
