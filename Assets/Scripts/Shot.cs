using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	public GameObject bulletHole;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 obPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		if (Input.GetMouseButtonDown(0)) 
		{
			Instantiate (bulletHole, obPos, Quaternion.identity);
			GameManager.currentScore -= 2f;
		}
	}
}
