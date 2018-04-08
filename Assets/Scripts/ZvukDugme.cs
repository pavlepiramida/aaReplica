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
		zvuk=PlayerPrefs.GetInt("Zvuk");
		switch(zvuk)
		{
			case 0:
			DugmeZvuk.image.sprite=ZvukeNE; //posto je AudioMenager DontDestroy,pre postavke dugmeta moramo da vidimo koji sprajt ide
			break;
		
			case 1:
			DugmeZvuk.image.sprite=ZvukDA;
			break;
		}
	}

	public void Iskljuci_zvuk()
	{
		switch(zvuk)
		{
			case 1:
			FindObjectOfType<AudioManager>().Play("Tema",0);
			DugmeZvuk.image.sprite=ZvukeNE;
			PlayerPrefs.SetInt("Zvuk",0);
			zvuk=0;
			break;
			
			case 0:
			FindObjectOfType<AudioManager>().Play("Tema",1);
			DugmeZvuk.image.sprite=ZvukDA;
			PlayerPrefs.SetInt("Zvuk",1);
			zvuk=1;
			break;
		}
	}
}
