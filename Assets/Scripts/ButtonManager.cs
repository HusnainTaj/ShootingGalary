using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManager : MonoBehaviour 
{
	public void Play()
	{
		GameManager.currentTime = 60;
		GameManager.currentScore = 0;
		SceneManager.LoadScene (3);
	}
	public void Instruction()
	{
		SceneManager.LoadScene (2);
	}
	public void Return()
	{
		SceneManager.LoadScene (1);
	}
	public void Credits()
	{
		SceneManager.LoadScene (5);
	}
}
