using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poeni : MonoBehaviour {

	public static Text BodoviUI;
	public static int bodovi;

	// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	public void Awake()
	{
		bodovi=0;
	    BodoviUI=GameObject.Find("TextBodovi").GetComponent<Text>();
		BodoviUI.text="0";
	}

	static public void Pogodak()
	{
		if(Klonovi.krajbrt)//podizi bodove dok se igra,kada je false,roknuo je ciodu o ciodu i nema vise bodovanja
		{
			bodovi++;
			BodoviUI.text=bodovi.ToString();
		}
	}


}
