using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotor : MonoBehaviour
{

	public float rotacija_b = 50f;
	
	
	// Update is called once per frame
	void FixedUpdate()
	{
		transform.Rotate(0f,0f,rotacija_b*Time.deltaTime);
	}
	
}