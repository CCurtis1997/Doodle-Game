using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{
    public float oldPos;
    public float currentPos;

    public bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        currentPos = transform.position.x;
        oldPos = currentPos;

        facingRight = true;

    
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = transform.position.x;

        if(Difference() <= -0.1)
        {
            facingRight = true;
        }

        if (Difference() >= 0.1)
        {
            facingRight = false;
        }

        if(facingRight = true && Difference() >= 0.1)
        {
            Flip();
        }

        if (facingRight = false && Difference() <= -0.1)
        {
            Flip();
        }

        

    }

    public void FixedUpdate()
    {

        oldPos = currentPos;
    }


    float Difference()
    {
        return oldPos - currentPos;
    }

    public void Flip()
    {
        
        //get the scale of the character model and flip it
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
