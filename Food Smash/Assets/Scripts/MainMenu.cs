using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // called when StartButton pressed
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    // called when ExitButton pressed
    public void QuitGame()
    {
        // Debug.Log("QUIT!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void NotQuit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);

    }

    public void OpenQuit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);

    }

    public void OpenEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void OpenEscape2nd()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);

    }

    public void YesEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Application.Quit();
    }

    public void NoEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        // Application.Quit();
    }

    // called when CreditButton pressed
    public void Credit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
