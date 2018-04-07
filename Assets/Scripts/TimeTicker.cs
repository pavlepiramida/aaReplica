using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTicker : MonoBehaviour {

	private double tajmer;
	public Text vreme;
	void Awake()
	{
		tajmer=10;
		vreme.text="Time\n" + tajmer.ToString();
		StartCoroutine(Odbrojavanje());
	}	

	public void PogodioCiodu()
	{
		StopAllCoroutines();
	}

	IEnumerator Odbrojavanje()
	{
		
        while(true)
		{
			yield return new WaitForSeconds(0.5f);
			switch((int)tajmer)
			{
			case 0:
			StopAllCoroutines();
			vreme.text="Time\n" + ((int)tajmer).ToString();
			FindObjectOfType<GameManager>().TimesUp();
			break;	

			default:
			vreme.text="Time\n" + ((int)tajmer).ToString();
			tajmer-=0.5;
			break;
			}				
		}
	}
}
