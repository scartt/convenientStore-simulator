using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroText : MonoBehaviour
{
    public Text dialogueText;
    private int curLine;
    public List<string> contents;
    public Canvas canvas;

    void Start()
    {
        curLine = 0;
        LoadText(contents[curLine]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (curLine >= 5)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            NextLine();
            if (curLine >= contents.Count)
            {
                curLine = contents.Count;
            }
            LoadText(contents[curLine]);
        }
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }

    void NextLine()
    {
        curLine++;
    }

    void SetContentText(string value)
    {
        dialogueText.text = value;
    }

    void LoadText(string value)
    {
        SetContentText(value);
    }

    public void OpenQuit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
        Application.Quit();
    }



}

