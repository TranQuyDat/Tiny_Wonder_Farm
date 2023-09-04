using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolbarUI : MonoBehaviour
{
    public GameObject prefapslot;
    public int countslot = 10;
    public List<toolbarSlot> slots;
    
    private bool isfullToolbar;
    [HideInInspector]
    public bool isaddeditem;
    private void Start()
    {
        slots = new List<toolbarSlot>();
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
        else if (countslot < slots.Count)
        {
            deleteslots(slots.Count - countslot);
        }
    }
    public void createSlots()
    {
        for (int i = slots.Count; i < countslot; i++)
        {
            GameObject slot = Instantiate(prefapslot, this.transform);
            slots.Add(slot.GetComponent<toolbarSlot>());
        }
    }

    public void deleteslots(int count)
    {
        for (int i = countslot; i < countslot + count; i++)
        {
            GameObject slot = slots[i].gameObject;
            slots.RemoveAt(i);
            Destroy(slot);

        }
    }

    public void addItems(ItemsValue itemsValue)
    {
        foreach(toolbarSlot slot in slots)
        {
            isfullToolbar = true;
            if (slot.item != null) return;
            isfullToolbar = false;
            slot.additem(itemsValue);
            break;
        }
        if (isfullToolbar) isaddeditem = false;
        else isaddeditem = true;
    }
}
