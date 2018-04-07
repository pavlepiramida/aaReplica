using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZvukDugme : MonoBehaviour {

	private int zvuk=1;//poenta je bila da u awake proverim dal jeste ili nije i na osnovu toga postavljam ikonicu
	//al il sam glup il jako pa ni start() ni awake() nisu bili pogodni za to
	//zato krecemo odmah sa zvukom i ikonom za njega
	public Sprite ZvukDA;
	public Sprite ZvukeNE;
	public Button DugmeZvuk;
	

	
	public void Awake() //posto awake puca null reference na zvuk=... prvi put,a sa start metoda vraca pogresnu vrednost 
	//morao sam da upakujem u try i catch
	{
		
		try 
		{
			zvuk=PlayerPrefs.GetInt("Zvuk");
		}
		catch
		{
			Debug.Log("Prvi put startovanje igre");
		}
		if (zvuk==0)
		DugmeZvuk.image.sprite=ZvukeNE; //posto je AudioMenager DontDestroy,pre postavke dugmeta moramo da vidimo koji sprajt ide
		else
		DugmeZvuk.image.sprite=ZvukDA;

	}

	public void Iskljuci_zvuk()
	{
		if (zvuk==1)
		{
			FindObjectOfType<AudioManager>().Play("Tema",0);
			DugmeZvuk.image.sprite=ZvukeNE;
			PlayerPrefs.SetInt("Zvuk",0);
			zvuk=0;

		}
		else
		{
			FindObjectOfType<AudioManager>().Play("Tema",1);
			DugmeZvuk.image.sprite=ZvukDA;
			PlayerPrefs.SetInt("Zvuk",1);
			zvuk=1;
		}
	}
}
