using UnityEngine;
using System.Collections;

public class SpawnDuckWater : MonoBehaviour {

	public GameObject waterDuck;

	// Use this for initialization
	IEnumerator Start () 
	{
		while(true) 
		{
			yield return new WaitForSeconds (Random.Range(2f,10f));
			Instantiate (waterDuck, transform.position, Quaternion.identity);
		}
	}
}
