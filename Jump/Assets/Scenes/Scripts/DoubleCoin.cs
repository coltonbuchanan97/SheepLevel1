using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleCoin : MonoBehaviour {

    public AudioSource coinSound;

    private ScoreManager theScoreManager;

    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            theScoreManager.AddScore();
            coinSound.Play();
            gameObject.SetActive(false);
        }
    }
}
