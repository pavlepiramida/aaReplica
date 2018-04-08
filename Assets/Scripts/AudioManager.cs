using UnityEngine;
using System;

using UnityEngine.Audio;


public class AudioManager : MonoBehaviour {

	public Sound[] zvuci;
	public static AudioManager instancaAM;

	public void  Awake()
	{
		if (instancaAM==null)
		instancaAM=this;
		else
		{
			Destroy(gameObject);
			return;		
		}
		DontDestroyOnLoad(instancaAM);
		foreach (Sound z in zvuci)
		{
			z.source = gameObject.AddComponent<AudioSource>();
			z.source.clip=z.clip;
			z.source.name=z.name;
			z.source.volume=z.volume;
			z.source.loop=z.loop;
			z.source.pitch=z.pitch;
		}		
	}

	public void Play(string ime,int stanje)
	{
			FindSound(ime,stanje);
	}

	void Start()
	{
		//da li je zvuk prosli put bio iskljucen ili ne
		switch(PlayerPrefs.GetInt("Zvuk"))
		{
			case 1:
			FindSound("Tema",1);
			break;
		}
		

	}
	public void FindSound (string ime,int stanje)  //stanje,true ili false,false oznacava pauzu,true == play || 1
	{
		Sound zvuk = Array.Find(zvuci, zvuci => zvuci.name == ime);
		if (zvuk == null)
		{
			zvuk.source.Pause();
			Debug.Log("NE postoji zvuk: " + ime );
		}
		else if (stanje==1)
		{
			zvuk.source.pitch=1f;
			zvuk.source.Play();
		}
		else
		{
			zvuk.source.Pause();
		}
	}
}
