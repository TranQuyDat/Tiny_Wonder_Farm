using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newitem",menuName ="inventory/items")]
public class ItemsValue : ScriptableObject 
{
    public string name;
    public Sprite sprite;
    public Transform parentAfterdrag;

}
