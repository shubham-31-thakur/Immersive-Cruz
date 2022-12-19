using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC32 : MonoBehaviour
{
#pragma warning disable IDE1006 // Naming Styles
    public void playGame()
#pragma warning restore IDE1006 // Naming Styles
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

