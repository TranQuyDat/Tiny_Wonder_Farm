using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    public bool enableButton;
    public bool isEnter = false;
    public string loadScene;
    public float delayTime = 1f;
    public Vector2 posSpawnPlayer;
    public Animator animator_changeScene;

    private playerController player;
    [SerializeField] private SceneInfo sceneInfo;


    private void Update()
    {
        LoadScene();
    }

    void LoadScene()
    {
        if (!sceneInfo.isactive) return;
        if (enableButton && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(IE_waitScene());
            
        }
        else if(!enableButton )
        {
            StartCoroutine(IE_waitScene());
        }
        
    }
    IEnumerator IE_waitScene()
    {
        animator_changeScene.SetTrigger("start");
        yield return new WaitForSeconds(delayTime);
        sceneInfo.posSpawnPlayer = posSpawnPlayer;  
        SceneManager.LoadScene(loadScene);
        
    }
   private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag != "Player") return;
        sceneInfo.nameScene = loadScene;
        sceneInfo.isactive = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sceneInfo.isactive = false;
    }
}
