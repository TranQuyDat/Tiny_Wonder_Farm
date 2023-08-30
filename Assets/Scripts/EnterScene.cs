using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    public bool enableButton;
    public bool isEnter;

    public string loadScene;

    [SerializeField]
    SceneInfo sceneInfo;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (enableButton == false)
        {
            sceneInfo.pos_spawn = this.transform.position;
            sceneInfo.nameScene = loadScene;
            sceneInfo.isactive = isEnter;
            SceneManager.LoadScene(loadScene);
        }
         else if(enableButton && Input.GetKeyDown(KeyCode.E) )
        {
            sceneInfo.pos_spawn = this.transform.position;
            sceneInfo.nameScene = loadScene;
            sceneInfo.isactive = isEnter;
            SceneManager.LoadScene(loadScene);
        }
    }
  
}
