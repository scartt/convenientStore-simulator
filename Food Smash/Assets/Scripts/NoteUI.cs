using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteUI : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        // canvas.gameObject.SetActive();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Note Open");
            canvas.gameObject.SetActive(false);
        }
    }
}
