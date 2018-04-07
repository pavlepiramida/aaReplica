using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	public static Camera cam;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		if(cam==null){
			cam=this;
		}
		else{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(cam);
	}
}
