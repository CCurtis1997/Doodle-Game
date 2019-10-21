using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyfollowTrigger : MonoBehaviour
{
    public float moveSpeed;
    public Transform[] moveSpots;
    private int _randomSpot;
    private float _waitTime;
    public float startWaitTime;

    private bool _characterNear;
    public Transform player;

    //attempted to flip the enemy character model based on current and previous location
    private bool _isFacingRight;
    private float _previousXPos;
    

    // Start is called before the first frame update
    void Start()
    {
        _randomSpot = Random.Range(0, moveSpots.Length);
        _waitTime = startWaitTime;
        _previousXPos = transform.position.x;
        _isFacingRight = true;
    }







    // Update is called once per frame
    void Update()
    {
     
        



        if(_characterNear == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            _characterNear = false;
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[_randomSpot].position, moveSpeed * Time.deltaTime);
        }
       


       if (Vector2.Distance(transform.position, moveSpots[_randomSpot].position) < 0.2f)
        {
            if (_waitTime <= 0)
            {
                _randomSpot = Random.Range(0, moveSpots.Length);
                _waitTime = startWaitTime;

            }
            else
            {
                _waitTime -= Time.deltaTime;
            }
        }
    }

    private void Flip()
    {
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _characterNear = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _characterNear = false;
    }

    
}
