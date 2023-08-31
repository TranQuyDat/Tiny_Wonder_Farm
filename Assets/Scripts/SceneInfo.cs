using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="sceneinfo",menuName = "sceneinfo")]
public class SceneInfo : ScriptableObject
{
    public bool isactive = false ;
    public string nameScene;
    public Vector2 posSpawnPlayer;
}
