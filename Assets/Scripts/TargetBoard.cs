using UnityEngine;
using System.Collections;

public class TargetBoard : MonoBehaviour {

	bool scoreAdded = false;
	public AudioClip boardSound;
	public GameObject plus40;

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject,2.5f);
	}

	void OnMouseDown()
	{
		Destroy (gameObject);
		if (!scoreAdded) 
		{
			Instantiate (plus40, transform.position, Quaternion.identity);
			AudioSource.PlayClipAtPoint (boardSound, transform.position);
			GameManager.currentScore += 42;
			scoreAdded = true;
		}

	}
}
