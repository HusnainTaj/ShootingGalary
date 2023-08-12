using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Timer : MonoBehaviour 
{
	void Update ()
	{
		if (GameManager.currentTime <= 0) 
		{
			SceneManager.LoadScene (4);
		}
	}
}
