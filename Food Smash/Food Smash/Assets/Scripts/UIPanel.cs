using UnityEngine;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{
    public RawImage charaAImg;
    public Text contentTxt;
    public UIPanel panel;

    public void ShowPanel(bool value)
    {
        panel.enabled = value;
    }

    public void ShowCharaA(bool value)
    {
        charaAImg.enabled = value;
    }

    public void ShowContentText(bool value)
    {
        contentTxt.enabled = value;
    }

    public void SetContentText(string value)
    {
        contentTxt.text = value;
    }
}