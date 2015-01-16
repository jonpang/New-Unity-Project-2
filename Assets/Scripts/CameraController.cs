using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	//public reference to the player
	public GameObject player;
	//private vector3 to hold offset value
	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position;
	}
	
	// LateUpdate used to update last
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
