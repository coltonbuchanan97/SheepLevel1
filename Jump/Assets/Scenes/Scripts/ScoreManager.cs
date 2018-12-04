using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text score;

    public float scoreCount = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Score: " + scoreCount;
	}

    public void AddScore(int scoreToAdd)
    {
        scoreCount += scoreToAdd;
    }

    public void AddScore()
    {
        scoreCount *= 2;
    }
}
