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
   
    void Start()
    {
        dialogBox.SetActive(true);
        dialogText.gameObject.SetActive(true);
        player.gameObject.SetActive(true);
        dialogText.text = "搜索货架上有什么可以增加战斗力的食物吧！按下Enter继续";

    }

    // Update is called once per frame
    void Update()
    {

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
                dialogText.text =  "得到了薯片！";
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
                dialogText.text = "得到了汽水！";
            }
        }

        if (Input.GetKey(KeyCode.P)) // && dialogActive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        }

        if (Input.GetKey(KeyCode.O)) // && dialogActive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        }

        if (Input.GetKey(KeyCode.I)) // && dialogActive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
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
}
