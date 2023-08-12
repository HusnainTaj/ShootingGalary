using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public Text scoreText;
	public Text timeText;
	public static float currentScore;
	public static int currentTime = 60;
	public GameObject readyText;
	public GameObject goText;

	IEnumerator Start () 
	{
		yield return new WaitForSeconds (1f);
		Instantiate (readyText, transform.position, Quaternion.identity);
		yield return new WaitForSeconds (2f);
		Instantiate (goText, transform.position, Quaternion.identity);
		yield return new WaitForSeconds (2f);
		while (currentTime >= 1) 
		{
			currentTime--;
			yield return new WaitForSeconds (1f);
		}
	}
	
	void Update () 
	{
		if (currentScore <= 0) 
		{
			currentScore = 0;
		}
		scoreText.text = "Score:" + currentScore;
		timeText.text = "TimeLeft:" + currentTime;
	}
}
