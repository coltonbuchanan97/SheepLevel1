using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public string playGamelevel;

	public void Load()
    {
        // Application.LoadLevel(playGamelevel);
        SceneManager.LoadScene(playGamelevel);
    }

    public void ExitGame()
    {
        SceneManager.UnloadSceneAsync(playGamelevel);
    }

}
