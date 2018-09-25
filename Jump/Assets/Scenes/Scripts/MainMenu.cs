using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public string playGamelevel;

	public void Load()
    {
        Application.LoadLevel(playGamelevel);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
