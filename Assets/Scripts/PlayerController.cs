using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float movementforce;





    private Rigidbody2D rb;

    public SpriteRenderer Mugger;







    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        Movement();

    }



    //private void AnimationControl()
    //{
    //    float xDir = Input.GetAxisRaw("Horizontal");

    //    if (xDir == 0)
    //    {
    //        anim.SetBool("isWalking", false);
    //    }
    //    else
    //    {
    //        anim.SetBool("isWalking", true);
    //    }

    //}

    private void Movement()
    {
        float xDir = Input.GetAxisRaw("Horizontal");
        float yDir = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(yDir * (movementforce * Time.deltaTime), rb.velocity.y);

        rb.velocity = new Vector2(xDir * (movementforce * Time.deltaTime), rb.velocity.x);

        if (xDir == -1)
        {
            Mugger.flipX = true;
        }
        else if (xDir == 1)
        {
            Mugger.flipX = false;
        }

    }
}