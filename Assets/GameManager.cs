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
	public void EndGame()
    {
		HighScoreSystem.KrajIgre(Poeni.bodovi);
		FindObjectOfType<rotor>().enabled=false;
		FindObjectOfType<Poeni>().enabled=false;
		Klonovi.krajbrt=false;//Postavljamo krajbrt i nema vise instanciranja
    	Animator.SetTrigger("GejmOverio");
    }

}
