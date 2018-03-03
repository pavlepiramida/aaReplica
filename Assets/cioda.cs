using System;
using System.Collections;
using UnityEngine;


public class cioda : MonoBehaviour
{
	
	public GameManager gg;
	// Use this for initialization
	public Rigidbody2D cioda_rb;
	public bool udario = false;

	public float cioda_brzina = 40f;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	
	// Update is called once per frame
	void FixedUpdate()
	{
		if (!udario)
		{
			cioda_rb.MovePosition(cioda_rb.position + Vector2.up * cioda_brzina * Time.deltaTime);
		}

	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("cioda")|| collider.CompareTag("koplje"))
		{
			FindObjectOfType<Poeni>().enabled=false;
			FindObjectOfType<GameManager>().EndGame();

		}else if (collider.CompareTag("Meta"))
		{
			udario = true;
			transform.SetParent(collider.transform);
			Poeni.bodovi++;
			
			
		}
		

	}
}
