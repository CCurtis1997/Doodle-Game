using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealthPts = 4;
    public int _currentHealthPts;
    public int damage = 1;
    public GameObject eraser;

    public GameObject[] lootDrops;
    private int _randomDrop;


    // Start is called before the first frame update
    void Start()
    {
        _currentHealthPts = maxHealthPts;
        eraser = GameObject.FindGameObjectWithTag("Projectile");
        
    }

    // Update is called once per frame
    void Update()
    {

        _randomDrop = Random.Range(0, lootDrops.Length);

        if ( _currentHealthPts <= 0)
        {
            Destroy(gameObject);

            Instantiate(lootDrops[_randomDrop], transform.position, Quaternion.identity);
            
        }
    }

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            _currentHealthPts -= damage;

        }
    }

   
}
