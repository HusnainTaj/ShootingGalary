using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, 0.5f);
	}
}
