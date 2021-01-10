using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StreetTrigger : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O)) // && dialogActive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }

        if (Input.GetKey(KeyCode.I)) // && dialogActive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }
}
