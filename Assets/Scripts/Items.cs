using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Items : MonoBehaviour , IDragHandler,IBeginDragHandler,IEndDragHandler
{
    public GameObject prefapitems;
    public ItemsValue itemvalue;
    public Transform parentAfterDrag;
    public Image image;

    private void Start()
    {
        image.sprite = itemvalue.sprite;
    }

    public void useItem()
    {
        Debug.Log("use item " + name);
    }
    public void removeItem()
    {
        Destroy(this.gameObject);
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        image.raycastTarget = false;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }  
    
    public void OnEndDrag(PointerEventData eventData)
    {
        
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
