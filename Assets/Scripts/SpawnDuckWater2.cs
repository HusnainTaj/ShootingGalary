using UnityEngine;
using System.Collections;

public class SpawnDuckWater2 : MonoBehaviour {

	public GameObject water2Duck;

	// Use this for initialization
	IEnumerator Start () 
	{
		while(true) 
		{
			yield return new WaitForSeconds (Random.Range(2f,4f));
			Instantiate (water2Duck, transform.position, Quaternion.identity);
		}
	}
}
