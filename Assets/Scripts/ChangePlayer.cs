using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite Knight;
    public Sprite Frog;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){ChangeSprite();}
    }

    void ChangeSprite()
    {
        if (spriteRenderer.sprite = Frog)
        {
            spriteRenderer.sprite = Knight;
        }

        if (spriteRenderer.sprite = Knight)
        {
            spriteRenderer.sprite = Frog;
        }
    }

}