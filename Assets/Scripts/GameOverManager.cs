using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverManager : MonoBehaviour {

	public Text finalScore;

	// Use this for initialization
	void Start () 
	{
		finalScore.text = "" + GameManager.currentScore;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
