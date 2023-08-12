using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Duck : MonoBehaviour {

	bool scoreAdded = false;
	public AudioClip duckSound;
	public GameObject plus10;

	void Update () 
	{
		if (transform.position.x > 7) 
		{
			Destroy (gameObject);
		}
	}

	void OnMouseDown()
	{
		Destroy (gameObject);
		if (!scoreAdded) 
		{
			Instantiate (plus10, transform.position, Quaternion.identity);
			AudioSource.PlayClipAtPoint (duckSound, transform.position);
			GameManager.currentScore += 12;
			scoreAdded = true;
		}

	}
}
