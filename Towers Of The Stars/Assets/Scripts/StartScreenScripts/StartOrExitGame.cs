using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOrExitGame : MonoBehaviour
{
    string buttonName;
    void Update()
    {
        buttonName = gameObject.name;

        switch (buttonName)
        {
            case "StartButton":
                SceneManager.LoadScene(1);
                return;
            case "ExitGameButton":
                Application.Quit();
                return;
            case "replay":
                SceneManager.LoadScene(1);
                return;
        }
    }
}
