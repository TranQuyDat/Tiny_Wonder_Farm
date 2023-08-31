using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    InteractiveObj interactiveObj;

    void Start()
    {
        interactiveObj = FindObjectOfType<InteractiveObj>();
    }
    private void Update()
    {

    }
    public InteractiveObj getInteractiveObj()
    {
        return interactiveObj;
       
    }


}
