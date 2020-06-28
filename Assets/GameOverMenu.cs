using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public void Retry()
    {
        SceneManager.LoadScene("Level01");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT GAME");
    }

}
