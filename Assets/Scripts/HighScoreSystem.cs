using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreSystem : MonoBehaviour {

	private Text hajskorTekst;
	private string highscore;
	

	public void Awake()
	{
		hajskorTekst=GameObject.Find("Hajskor").GetComponent<Text>();
	
		if(PlayerPrefs.GetInt("highscore")>0)
		{
			hajskorTekst.text="High Score: " + PlayerPrefs.GetInt("highscore");
		}
		else
			hajskorTekst.enabled=false;
	}

	static public void KrajIgre(int osvojenoBodova)
	{
		if(osvojenoBodova>=PlayerPrefs.GetInt("highscore"))
		{
			PlayerPrefs.SetInt("highscore",osvojenoBodova);
		}
	}
}
