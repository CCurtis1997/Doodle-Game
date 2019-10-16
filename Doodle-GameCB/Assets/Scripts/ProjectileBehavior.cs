using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float upForce;
    // Start is called before the first frame update
    private void Start()
    {
        rb.velocity = Vector2.right * moveSpeed;
        rb.AddForce(transform.up * upForce);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
