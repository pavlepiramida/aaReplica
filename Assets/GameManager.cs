using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class GameManager : MonoBehaviour
{
	public static GameManager gm;
	public Animator Animator;

	 
	  
	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	
		
	public void Opet()
	{
		
       
	   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	public void EndGame()
    {

       
		 Animator.SetTrigger("GejmOverio");
        FindObjectOfType<rotor>().enabled = false;
        FindObjectOfType<Klonovi>().enabled = false;
		
		// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		//StartCoroutine(Opet());
    }

    private static void NewMethod()
    {
        FindObjectOfType<Canvas>().enabled = true;
    }
}
