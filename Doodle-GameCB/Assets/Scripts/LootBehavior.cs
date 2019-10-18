using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBehavior : MonoBehaviour
{
    public int[] moveDirections;
    private int _randomDirection;
    public float moveForce;
    public float upForce;

    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        _randomDirection = Random.Range(0, moveDirections.Length);
        rb.AddForce(transform.up * upForce);


        if(_randomDirection == 0)
        {
            rb.AddForce(transform.right * moveForce);
        }else if(_randomDirection == 1)
        {
            rb.AddForce(transform.right * -1 * moveForce);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
