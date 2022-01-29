using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public Sprite Knight;
    public Sprite Frog;
    
    private SpriteRenderer spriteRenderer;
    private enum State {Frog, Knight};
    State pState;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SetFrog();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){ChangeState();}
        Debug.Log(pState);
    }

    private void ChangeState()
    {
        if (pState == State.Frog)
        {
            SetKnight();
        }
        else if(pState == State.Knight)
        {
            SetFrog();
        }
    }

    void SetFrog()
    {
        pState = State.Frog;
        spriteRenderer.sprite = Frog;
    }

    void SetKnight()
    {
        pState = State.Knight;
        spriteRenderer.sprite = Knight;
    }
}