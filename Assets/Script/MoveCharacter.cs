using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField]private float speed;
    private float move;
    private Rigidbody2D rb;
    private Vector2 lastDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastDirection = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (move < 0)
        {
            transform.localScale = new Vector2(-1, 1);
            lastDirection = transform.localScale;
        }
        else if (move > 0)
        {
            transform.localScale = new Vector2(1, 1);
            lastDirection = transform.localScale;

        }
        else
        {
            lastDirection = transform.localScale;

        }

    }
}
