using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    public float speed;
    private Vector2 moveDirection;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();


        moveDirection = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        bool touchingFloor;
        touchingFloor = GetComponent<BoxCollider2D>().IsTouchingLayers();

        if (touchingFloor)
        {
            rb.AddForceAtPosition(new Vector2(0, moveDirection.y * 200), transform.position + new Vector3(0, -1.5f, 0));
        }
        {
            moveDirection = Vector2.zero;

            if (Input.GetKey(KeyCode.W))
            {
                moveDirection.y += 1;
            }

            if (Input.GetKey(KeyCode.S))
            {
                moveDirection.y += -1;
            }

            if (Input.GetKey(KeyCode.A))
            {
                moveDirection.x += -1;
            }

            if (Input.GetKey(KeyCode.D))
            {
                moveDirection.x += 1;
            }

            rb.transform.position += new Vector3(moveDirection.x * speed, 0, 0) * speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coins"))
        {
            Destroy(other.gameObject);
        }
    }
    public void MovementInputs()
    {
        moveDirection = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W is pressed");
            moveDirection.y += 1;
        }
    }

    public bool IsMoving()
    {
    return moveDirection != Vector2.zero;
    }
}