using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private float yourDesiredSize = 32f;

    void Awake()
    {
        Camera.main.orthographicSize = yourDesiredSize;
    }
}
