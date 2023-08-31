using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    public bool enableButton;
    public bool isEnter = true;
    public string loadScene;
    public float delayTime;
    public Vector2 posSpawnPlayer;
    
    [SerializeField] private SceneInfo sceneInfo;
    private void Awake()
    {
        sceneInfo.posSpawnPlayer = this.transform.position;
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        LoadScene();
    }

    void LoadScene()
    {
        if (!sceneInfo.isactive) return;
        if (enableButton && Input.GetKeyDown(KeyCode.E))
        {
            sceneInfo.isactive = true;
            StartCoroutine(IE_waitScene());
        }
        else if(!enableButton )
        {
            sceneInfo.isactive = true;
            StartCoroutine(IE_waitScene());
        }
        
    }
    IEnumerator IE_waitScene()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(loadScene);
        sceneInfo.isactive = false;
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
