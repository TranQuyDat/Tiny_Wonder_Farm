using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject player;
    public  Rigidbody2D rb;
    public float speed;
    public Animator animator;

    Vector2 movement;
    private void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetBool("isrun", (movement.x != 0 || movement.y != 0) ? true : false);
    }
    private void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        Flip();
    }

    public void Flip()
    {
        player.transform.localScale = new Vector3(
            (movement.x ==0)? player.transform.localScale.x: 
            (movement.x <0)?-1:1
            , 1, 1);

    }
    
}
