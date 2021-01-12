using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoteUI : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        //canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            Debug.Log("Note Open");
            canvas.gameObject.SetActive(false);
        }
        


    }

    public void OpenQuit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
        Application.Quit();
    }

    public void OpenQuitStreet()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        Application.Quit();
    }
}
