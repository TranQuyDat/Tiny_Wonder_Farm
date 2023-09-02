using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{

    public float speedfollow = 3f;
    public GameObject taget;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( taget.transform.position.x,taget.transform.position.y,-10f);
    }
}
