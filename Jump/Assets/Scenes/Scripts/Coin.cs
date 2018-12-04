using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{

    public AudioSource coinSound;

    public int scoreToGive;

    private ScoreManager theScoreManager;

    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            theScoreManager.AddScore(scoreToGive);
            coinSound.Play();
            gameObject.SetActive(false);        
        }
    }
}
