using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZvukDugme : MonoBehaviour {

	public bool zvuk=true;//poenta je bila da u awake proverim dal jeste ili nije i na osnovu toga postavljam ikonicu
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
			zvuk=FindObjectOfType<AudioManager>().DaLiPusta("Tema");
		}
		catch
		{
			Debug.Log("Prvi put startovanje igre");
		}
		if (!zvuk)
		DugmeZvuk.image.sprite=ZvukeNE; //posto je AudioMenager DontDestroy,pre postavke dugmeta moramo da vidimo koji sprajt ide
		else
		DugmeZvuk.image.sprite=ZvukDA;

	}

	public void Iskljuci_zvuk()
	{
		if (zvuk)
		{
			FindObjectOfType<AudioManager>().Play("Tema",false);
			DugmeZvuk.image.sprite=ZvukeNE;
			zvuk=false;

		}
		else
		{
			FindObjectOfType<AudioManager>().Play("Tema",true);
			DugmeZvuk.image.sprite=ZvukDA;
			zvuk=true;
		}
	}
}
