using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public void LoadLevel (string level)
    {
        SceneManager.LoadScene(level);
    }

    public void GameExit()
    {
        Application.Quit();
    }


}
