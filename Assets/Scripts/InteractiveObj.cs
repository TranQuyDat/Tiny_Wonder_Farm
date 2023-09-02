using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
public class InteractiveObj : MonoBehaviour
{
    public string name;
    public Sprite sprite_new;
    public GameObject collider;
    public bool setActive_colider;


    bool active = true;
    Sprite cur_sprite;
    private bool isplayer =false;

    private void Update()
    {
        if (!isplayer) return;
        changeSprite();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isplayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isplayer = false;
    }

    public void changeSprite()
    {
        if (!Input.GetKeyDown(KeyCode.E)) return;

        cur_sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite_new;
        sprite_new = cur_sprite;

        if (!setActive_colider) return;
            active = !active;
        collider.SetActive(active);
    }

}

