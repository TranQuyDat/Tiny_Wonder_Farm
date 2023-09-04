using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    [HideInInspector]
    public Items item  = null;
    private void Update()
    {
        if (GetComponentInChildren<Items>() == null || 
            item == GetComponentInChildren<Items>()) return;
        item = GetComponentInChildren<Items>();
        Debug.Log(item);

    }
    public void OnDrop(PointerEventData eventData)
    {
        GameObject droped = eventData.pointerDrag;
        Items item = droped.GetComponent<Items>();
        item.parentAfterDrag = transform.Find("icon");
        this.GetComponent<Button>().Select();
    }

    public void additem(ItemsValue itemsValue)
    {
        item.prefapitems.GetComponent<Items>().itemvalue = itemsValue;
        Instantiate(item.prefapitems, transform.Find("icon"));
    }
    public void useItem()
    {
        item.useItem();
    }

    public void removeItem()
    {
        item.removeItem();
    }

}
