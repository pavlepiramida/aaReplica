using UnityEngine;

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
		switch(krajbrt)
		{	
			case true:
			Instantiate(cioda);
			break;
		}	
			
	}
}
