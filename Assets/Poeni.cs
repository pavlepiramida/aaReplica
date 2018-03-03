using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poeni : MonoBehaviour {

	public Text BodoviUI;
	public static int bodovi;

	// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	public void Awake()
	{
		 bodovi=0;
	}
	public void Update()
	{
		Pogodak();
	}
	public void Pogodak()
	{
		BodoviUI.text=bodovi.ToString();	
	}


}
