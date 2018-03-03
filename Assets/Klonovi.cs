using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klonovi : MonoBehaviour
{
	public GameObject cioda;

	public void Update()
	{
		if (Input.GetButtonDown("Fire1"))
			Instantiate(cioda);
	}
}
