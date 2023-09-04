using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupitem : MonoBehaviour
{
    public InventoryUI InventoryUI;
    public toolbarUI toolbarUI;

    void Start()
    {
        InventoryUI = InventoryUI.GetComponent<InventoryUI>();
        toolbarUI = toolbarUI.GetComponent<toolbarUI>();
    }

    void Update()
    {
        
    }

    public void pickItem(ItemsValue itemsValue)
    {
        toolbarUI.addItems(itemsValue);
        if (toolbarUI.isaddeditem) return;
        InventoryUI.addItems(itemsValue);
    }
}
