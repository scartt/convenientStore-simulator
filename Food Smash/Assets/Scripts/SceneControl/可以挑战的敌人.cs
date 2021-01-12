using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 可以挑战的敌人 : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Note Open");
            canvas.gameObject.SetActive(false);
        }
        */

        if (Input.GetKey(KeyCode.Tab))
        {
            if (canvas.gameObject.activeInHierarchy)
            {
                canvas.gameObject.SetActive(false);
            }
            else
            {
                canvas.gameObject.SetActive(true);
            }
        }
    }
}
