using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rb;
   
    public float checkRadius;
    public LayerMask whatIsGround;

    public Animator animator;

    [Header("Transforms")]
    public Transform groundCheck;

    [Header("Booleans")]
    private bool facingRight = true;
    private bool isGrounded;

    [Header ("Physics Forces")]
    public float horizontalMoveSpeed;
    public float jumpforce;
    private float moveInput;


    public GameObject launcher;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        //get the input of a/d or left and right arrow; assign to a float and multiply that float by speed and time
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * horizontalMoveSpeed , rb.velocity.y);

        if(facingRight == false && moveInput > 0)
        {
            Flip();
        } else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }

        if (moveInput != 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpforce;
            isGrounded = false;

        }
        else
        {
            isGrounded = true;
            
        }
    }

    private void Flip()
    {
        //set facing right to the opposite of what it is
        facingRight = !facingRight;
        //get the scale of the character model and flip it
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

        
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Death")
        {
            SceneManager.LoadScene("Grassland");
        }
    }


}
