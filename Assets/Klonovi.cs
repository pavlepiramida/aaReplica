using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Klonovi : MonoBehaviour
{
	public GameObject cioda;
	public static bool krajbrt; //globalni bool koji odlucuje kad je kraj brt,
								//logicki jako glupa stvar,jer kada izgubis i dalje mozes da rokas ciode i nema smisla

	void Awake()
	{
		krajbrt=true;
	}
	public void Pucajga()
	{
		if(krajbrt)
		{
			Instantiate(cioda);
		}	
			
	}
}
