using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public GameObject player;
    public GameObject floor;
    private Vector3 startPoint;
    public static GameManager singleton;

    public Death theDeathScreen;
    public WinMenu theWinScreen;

	// Use this for initialization
	void Start () {
        startPoint = player.transform.position;
        Time.timeScale = 1.0f;
    }

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
        theDeathScreen.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
        
    }

    public void Win()
    {
        theWinScreen.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
    }

    public void Restart()
    {
        theDeathScreen.gameObject.SetActive(false);
        theWinScreen.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        //player.transform.position = startPoint;

        //Instantiate(floor, new Vector3 (-1.88f, 0.78f, 0f), player.transform.rotation);
        SceneManager.LoadScene("EndlessRunner");
        Time.timeScale = 1.0f;
    }
  
    public IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(0.1f);
        Time.timeScale = 0;
        player.transform.position = startPoint;
      
    }
}
