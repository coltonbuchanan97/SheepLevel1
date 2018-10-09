using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour {

    public string mainMenu;

    public void RestartGame()
    {
        FindObjectOfType<GameManager>().Restart();
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
