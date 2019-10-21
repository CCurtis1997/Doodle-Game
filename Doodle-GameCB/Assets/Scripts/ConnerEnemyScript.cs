using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnerEnemyScript : MonoBehaviour
{
    public Transform target;//set target from inspector instead of looking in Update
    public float speed = 3f;
    private float _invincibilityTimer;

    public Text invincibilityTimer;

    public PlayerHealth2 other;


    void Start()
    {

    }

    void Update()
    {

        //rotate to look at the player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation


        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {//move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        _invincibilityTimer -= 1 * Time.deltaTime;
        if (_invincibilityTimer < 0)
        {
            _invincibilityTimer = 0;
        }
    }

    public void OnCollisionEnter2D(Collision2D hit)
    {
        if ((hit.gameObject.tag == "enemy") && (_invincibilityTimer == 0))
        {
            other.DealDamage();
            other.CalculateHealth();
        }
    }
}
