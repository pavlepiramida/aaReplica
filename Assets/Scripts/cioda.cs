using System;
using System.Collections;
using UnityEngine;


public class cioda : MonoBehaviour
{
	public Rigidbody2D cioda_rb;
	private bool udario = false;
	private float cioda_brzina = 40f;
	public float Cioda_brzina
	{
		get{return this.cioda_brzina;}
		set{this.cioda_brzina=value;}
	}
	
	void FixedUpdate()
	{
		switch(udario)
		{
			case false:
			cioda_rb.MovePosition(cioda_rb.position + Vector2.up * cioda_brzina * Time.deltaTime);
			break;
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
			Poeni.Pogodak();
			break;
		}
	}
}
