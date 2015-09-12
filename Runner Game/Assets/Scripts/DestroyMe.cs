using UnityEngine;
using System.Collections;

public class DestroyMe : MonoBehaviour {

	// Bu scripti attığımız nesne, destroy aktifleştikten 4 saniye sonra yok olacak.

	public static bool destroy=false ;
	private bool yokEt=false;

	void Start () {
		destroy = false;
	}

	void Update () {
	if (destroy && !yokEt) 
	{
			Destroy(transform.gameObject,4f);
	}
	}
}
