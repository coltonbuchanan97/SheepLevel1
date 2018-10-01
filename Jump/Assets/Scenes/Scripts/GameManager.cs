using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject player;
    private Vector3 startPoint;
    public static GameManager singleton;

	// Use this for initialization
	void Start () {
        startPoint = player.transform.position;
	}

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(0.1f);
        player.transform.position = startPoint;
    }
}
