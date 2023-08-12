using UnityEngine;
using System.Collections;

public class SpawnTargetBoard : MonoBehaviour {

	public GameObject[] targetBorads;

	// Use this for initialization
	IEnumerator Start () 
	{
		while (true) 
		{
			yield return new WaitForSeconds (Random.Range(4f,12f));
			Instantiate (targetBorads[Random.Range(0,5)], transform.position, Quaternion.identity);
		}
	}
}
