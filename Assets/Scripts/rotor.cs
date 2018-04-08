using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class rotor : MonoBehaviour
{
	private float rotacija_b = 50f;
	public float Rotacija_b
	{
		get{return this.rotacija_b;}
		set{this.rotacija_b=value;}
	}
	
	void FixedUpdate()
	{
		transform.Rotate(0f,0f,rotacija_b*Time.deltaTime);
	}
}