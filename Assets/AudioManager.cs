using UnityEngine;
using System;

using UnityEngine.Audio;


public class AudioManager : MonoBehaviour {

	public Sound[] zvuci;
	public static AudioManager instancaAM;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
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



	public void Play(string ime,bool stanje)
	{
			FindSound(ime,stanje);
	}
	 /// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		FindSound("Tema",true);

	}

	public bool DaLiPusta(string ime)
	{
		Sound zvuk = Array.Find(zvuci, zvuci => zvuci.name == ime);
		if (zvuk == null)
			{
				Debug.Log("NE postoji zvuk: " + ime );
			}
		
		return zvuk.source.isPlaying;
		   	
	}

	public void PromeniPitch(float tempo,string ime)
	{
		Sound zvuk = Array.Find(zvuci, zvuci => zvuci.name == ime);
		if (zvuk == null)
			{
				Debug.Log("NE postoji zvuk: " + ime );
			}
		else
			{
				zvuk.source.pitch=tempo;
		   	}
	}

	public void FindSound (string ime,bool stanje)  //stanje,true ili false,false oznacava pauzu,true == play
	{
		Sound zvuk = Array.Find(zvuci, zvuci => zvuci.name == ime);
		if (zvuk == null)
		{zvuk.source.Pause();
			Debug.Log("NE postoji zvuk: " + ime );
		}
		else if (stanje)
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
