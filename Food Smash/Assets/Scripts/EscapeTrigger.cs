using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeTrigger : MonoBehaviour
{
    public void OpenEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        // Application.Quit();
    }

    public void YesEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Application.Quit();
    }

    public void NoEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        // Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        }
    }
}
