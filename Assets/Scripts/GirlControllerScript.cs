using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlControllerScript : MonoBehaviour {

    public float maxSpeed = 10f;
    bool facingRight = true;

    Animator anim;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 0.001f;

    bool doubleJump = false;

    // Use this for initialization
    void Start() {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        //Constant check whether character is on ground or not
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        if (grounded == false) {

        }

        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        anim.SetFloat("vSpeed", rigidbody2D.velocity.y);

        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move));

        //        rigidbody2D.velocity = new Vector2(move * maxSpeed, 0.5f);
        rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }
    
    void Update() {
        if ((grounded || !doubleJump) && grounded && Input.GetKeyDown(KeyCode.Space)) {
            anim.SetBool("Ground", false);
                
            Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
            rigidbody2D.AddForce(new Vector2(0, jumpForce));

            if (!doubleJump && !grounded) {
                doubleJump = true;
            }
        }

    }

    void Flip() {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= 1;
        transform.localScale = theScale;
    }
}
