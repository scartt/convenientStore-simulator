using UnityEngine;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{
    public UIPanel dialogpanel;
    public Text contentTxt;
    public RawImage EnemyImg;
    public RawImage PlayerImg;

    public void ShowPanel(bool value)
    {
        dialogpanel.enabled = value;
    }

    public void ShowEnemy(bool value)
    {
        EnemyImg.enabled = value;
    }

    public void ShowPlayer(bool value)
    {
        PlayerImg.enabled = value;
    }

    public void ShowContentText(bool value)
    {
        contentTxt.enabled = value;
    }
}
