using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class GameManager : MonoBehaviour
{
	public Animator Animator;

	public void Opet()
	{ 
	   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	IEnumerator TimesUpRestart()
	{
		yield return new WaitForSeconds(1.8f);
		Opet();

	}
	public void EndGame()
    {
		HighScoreSystem.KrajIgre(Poeni.bodovi);
		FindObjectOfType<rotor>().rotacija_b=10f;
		FindObjectOfType<Poeni>().enabled=false;
		Klonovi.krajbrt=false;//Postavljamo krajbrt i nema vise instanciranja
    	Animator.SetTrigger("GejmOverio");
    }
	public void TimesUp()//kad istekne vreme
	{
		HighScoreSystem.KrajIgre(Poeni.bodovi);
		FindObjectOfType<rotor>().rotacija_b=10f;
		FindObjectOfType<Poeni>().enabled=false;
		FindObjectOfType<cioda>().cioda_brzina=10f;
		Klonovi.krajbrt=false;
    	//Animator.SetTrigger("Opet");
		StartCoroutine(TimesUpRestart());
	}

}
