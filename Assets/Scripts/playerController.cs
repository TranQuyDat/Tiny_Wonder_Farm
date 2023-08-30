using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerController : MonoBehaviour
{
    public GameObject player;
    public  Rigidbody2D rb;
    public float speed;
    public Animator animator;
    public GameObject icon;
    Vector2 movement;
    GameManager gameManager;
    [SerializeField] public SceneInfo sceneInfo; 


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetBool("isrun", (movement.x != 0 || movement.y != 0) ? true : false);

        changeScene();


    }
    private void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        Flip();
    }

    public void changeScene()
    {
        if (sceneInfo.isactive)
        {
            this.transform.position = sceneInfo.pos_spawn;
            sceneInfo.isactive = false;
        }
    }
    public void Flip()
    {
        player.transform.localScale = new Vector3(
            (movement.x ==0)? player.transform.localScale.x: 
            (movement.x <0)?-1:1
            , 1, 1);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "interactiveObj")
        {
            icon.SetActive(true);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        icon.SetActive(false);
    }

}
