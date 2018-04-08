﻿using System;
using System.Collections;
using UnityEngine;


public class cioda : MonoBehaviour
{
	public Rigidbody2D cioda_rb;
	public bool udario = false;
	public float cioda_brzina = 40f;

	
	void FixedUpdate()
	{
		if (!udario)
		{
			cioda_rb.MovePosition(cioda_rb.position + Vector2.up * cioda_brzina * Time.deltaTime);
		}

	}
	private void OnTriggerEnter2D(Collider2D collider)
	{	
		switch(collider.tag)
		{			
			default:
			FindObjectOfType<TimeTicker>().PogodioCiodu();	
			FindObjectOfType<GameManager>().EndGame();
			break;

			case "Meta":
			udario = true;
			transform.SetParent(collider.transform);
			//FindObjectOfType<rotor>().PogodjenaMeta();
			Poeni.Pogodak();
			break;
		}
	}
}
