using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    
    private void Update()
    {
        openInventory();
    }

    public void openInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventory.SetActive(true);
        }
    }public void closeInventory()
    {
        inventory.SetActive(false);
        
    }
}
