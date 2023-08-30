using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="sceneinfo",menuName = "sceneinfo")]
public class SceneInfo : ScriptableObject
{
    public bool isactive ;
    public string nameScene;
    public Vector3 pos_spawn;


}
