﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public UIPanel panel;
    

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Application.Quit();

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                // NextLine();
                /* if (curLine >= data.contents.Count)
                {
                    curLine = data.contents.Count;
                    Init(); // Close UI Panel when dialogue finished
                }

                // LoadText(data.contents[curLine].dialogText);
                LoadContent(data.contents[curLine].dialogText, data.contents[curLine].charaADisplay, data.contents[curLine].charaBDisplay);
            }
                */
                panel.ShowCanvas(false);

            }

        }
    }
}


/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // public List<string> contents;
    public AVGdata data;
    public AVGAssetConfig asset;
    public UIPanel panel;
    [SerializeField]
    private int curLine;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        // Open dialog
        if (Input.GetKeyDown("1"))
        {
            Init();
            // LoadText(data.contents[curLine].dialogText);
            LoadCharaTexture(asset.charaATex, asset.charaBTex);
            ShowUI();
        }

        if (Input.GetMouseButtonDown(0))
        {
            NextLine();
            if (curLine >= data.contents.Count)
            {
                curLine = data.contents.Count;
                Init(); // Close UI Panel when dialogue finished
            }
            // LoadText(data.contents[curLine].dialogText);
            LoadContent(data.contents[curLine].dialogText, data.contents[curLine].charaADisplay, data.contents[curLine].charaBDisplay);
        }
    }

    private void Init()
    {
        HideUI();
        curLine = 0;
        panel.SetContentText("");
        LoadContent(data.contents[curLine].dialogText, data.contents[curLine].charaADisplay, data.contents[curLine].charaBDisplay);
    }

    void HideUI()
    {
        //panel.ShowCharaA(false);
        //panel.ShowCharaB(false);
        //panel.ShowContentBg(false);
        //panel.ShowContentText(false);
        panel.ShowCanvas(false);
    }

    void ShowUI()
    {
        //panel.ShowCharaA(true);
        //panel.ShowCharaB(true);
        //panel.ShowContentBg(true);
        //panel.ShowContentText(true);
        panel.ShowCanvas(true);
    }

    void NextLine()
    {
        // if not question
        curLine++;
    }

    void LoadText(string value)
    {
        panel.SetContentText(value);
    }

    void LoadContent(string value, bool charaADisplay, bool charaBDisplay)
    {
        panel.SetContentText(value);
        panel.ShowCharaA(charaADisplay);
        panel.ShowCharaB(charaBDisplay);
    }

    void LoadCharaTexture(Texture charaATex, Texture charaBTex)
    {
        panel.ChangeCharaATex(charaATex);
        panel.ChangeCharaATex(charaBTex);
    }
}

*/
