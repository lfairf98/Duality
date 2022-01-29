using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public Sprite Knight;
    public Sprite Frog;
    public float frogSpeed;
    public float knightSpeed;
    public float frogJump;
    public float knightJump;
    public MoveComponent moveScript;

    private bool canAtk;
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
        if(Input.GetKeyDown(KeyCode.Space)){ChangeState();}
    }

    private void ChangeState()
    {
        if(pState == State.Frog){SetKnight();}
        else if(pState == State.Knight){SetFrog();}
    }

    void SetFrog()
    {
        pState = State.Frog;
        spriteRenderer.sprite = Frog;
        moveScript.speed = frogSpeed;
        moveScript.jumpStrength = frogJump;
        canAtk = false;
    }

    void SetKnight()
    {
        pState = State.Knight;
        spriteRenderer.sprite = Knight;
        moveScript.speed = knightSpeed;
        moveScript.jumpStrength = knightJump;
        canAtk = true;
    }
}