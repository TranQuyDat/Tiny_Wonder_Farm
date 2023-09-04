using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject prefapslot;
    public int countslot = 30;
    public List<InventorySlot> slots;

    private bool isfullInventory;
    private void Start()
    {
        slots = new List<InventorySlot>();
    }
    private void Update()
    {
        updateSlot();

    }

    public void updateSlot()
    {
        if (countslot == slots.Count) return;
        if (countslot > slots.Count)
        {
            createSlots();
        }
        else if(countslot < slots.Count)
        {
            deleteslots(slots.Count - countslot);
        }
    }
    public void createSlots()
    {
        for (int i = slots.Count; i < countslot; i++)
        {
           GameObject slot =  Instantiate(prefapslot, this.transform);
           slots.Add(slot.GetComponent<InventorySlot>());
        }
    }

    public void deleteslots(int count)
    {
        for (int i = countslot; i < countslot+count; i++)
        {
            Destroy(slots[i].gameObject);
            slots.RemoveAt(i);
        }
    }
    public void addItems(ItemsValue itemsValue)
    {
        foreach (InventorySlot slot in slots)
        {
            isfullInventory = true;
            if (slot.item != null) return;
            isfullInventory = false;
            slot.additem(itemsValue);
            break;
        }

        if (isfullInventory) Debug.Log("Inventory full");

    }

    


}
