using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool dialogActive;
    public Image player;
    public Canvas newCanvas;
    public RawImage one;
    public RawImage two;

    void Start()
    {
        two.gameObject.SetActive(false);
        one.gameObject.SetActive(false);
        newCanvas.gameObject.SetActive(false);
        dialogBox.SetActive(true);
        dialogText.gameObject.SetActive(true);
        player.gameObject.SetActive(true);
        dialogText.text = "搜索货架上有什么可以增加战斗力的食物吧！按下Enter继续";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            if (newCanvas.gameObject.activeInHierarchy)
            {
                newCanvas.gameObject.SetActive(false);
            }
            else
            {
                newCanvas.gameObject.SetActive(true);
            }
        }

        if (Input.GetKey(KeyCode.Return))
        {
            Init();
        }

        if (Input.GetKey(KeyCode.Q)) // && dialogActive)
        {
            if (dialogBox.activeInHierarchy)
            {
                //Debug.Log("Enter!");
                Init();
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.gameObject.SetActive(true);
                player.gameObject.SetActive(true);
                dialogText.text =  "得到了红烧牛肉面！";
                one.gameObject.SetActive(true);
            }
        }

        if (Input.GetKey(KeyCode.E)) // && dialogActive)
        {
            if (dialogBox.activeInHierarchy)
            {
                Init();
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.gameObject.SetActive(true);
                player.gameObject.SetActive(true);

                dialogText.text = "得到了可乐！";
                two.gameObject.SetActive(true);
            }
        }

        if (Input.GetKey(KeyCode.P)) // && dialogActive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        }
    }

    private void Init()
    {
        dialogBox.SetActive(false);
        dialogText.gameObject.SetActive(false);
        player.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in range");
            dialogActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player left range");
            dialogActive = false;
        }
    }

    //public void ChangeInventory()
    //{
    //    newCanvas.gameObject.SetActive(false);
    //}
}
