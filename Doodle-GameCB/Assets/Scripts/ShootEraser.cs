using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEraser : MonoBehaviour
{
    public GameObject eraser;
    public float shootCooldown = 0.2f;
    private bool _isShooting;
    // Start is called before the first frame update
    void Start()
    {
        _isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && _isShooting == false)
        {
            Instantiate(eraser, transform.position, Quaternion.identity);
            _isShooting = true;

        }

        if (_isShooting == true)
        {
            shootCooldown -= Time.deltaTime;

            if(shootCooldown <= 0)
            {
                shootCooldown = 0;

                if(shootCooldown == 0)
                {
                    _isShooting = false;
                }
            }
        }

        
    }
}
