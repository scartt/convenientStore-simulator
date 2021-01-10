using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public List<string> contents;
    // public UIPanel panel;
    [SerializeField]
    private int curLine;
    public Canvas canvas;

    void Start()
    {
        Init();
    }

    void Update()
    {
        // Open dialog
        if (Input.GetKeyDown("1"))
        {
            Init();
            LoadText(contents[curLine]);
            ShowUI();
        }

        if (Input.GetMouseButtonDown(0))
        {
            NextLine();
            if (curLine >= contents.Count)
            {
                curLine = contents.Count;
                Init(); // Close UI Panel when dialogue finished
            }
            LoadText(contents[curLine]);
            //LoadContent(data.contents[curLine].dialogText, data.contents[curLine].charaADisplay, data.contents[curLine].charaBDisplay);
        }

    }

    private void Init()
    {
        HideUI();
        canvas.gameObject.SetActive(false);
        curLine = 0;
        // panel.SetContentText("");
    }

    public void ShowEscape()
    {
        canvas.gameObject.SetActive(true);
    }

    void ShowUI()
    {
        // panel.ShowCharaA(true);
    }

    void HideUI()
    {
        // panel.ShowCharaA(false);
    }

    void NextLine()
    {
        curLine++;
    }

    void LoadText(string value)
    {
        // panel.SetContentText(value);
    }
}