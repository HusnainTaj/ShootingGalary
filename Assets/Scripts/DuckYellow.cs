using UnityEngine;
using System.Collections;

public class DuckYellow : MonoBehaviour {

	bool scoreAdded = false;
	public AudioClip duckSound;
	public GameObject plus20;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.x < -7) 
		{
			Destroy (gameObject);
		}
	}

	void OnMouseDown()
	{
		Destroy (gameObject);
		if (!scoreAdded) 
		{
			Instantiate (plus20, transform.position, Quaternion.identity);
			AudioSource.PlayClipAtPoint (duckSound, transform.position);
			GameManager.currentScore += 22;
			scoreAdded = true;
		}

	}
}
