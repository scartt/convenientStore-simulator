using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTrigger : MonoBehaviour
{
    public Canvas newCanvas;

    // Start is called before the first frame update
    void Start()
    {
        newCanvas.gameObject.SetActive(false);
    }

    public void openInventory()
    {
        newCanvas.gameObject.SetActive(true);
    }
}
