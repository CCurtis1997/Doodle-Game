using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootEraser : MonoBehaviour
{
    public GameObject eraser;
   
   

    public Slider shootDelayBar;
    public float maxCoolDown = 100;
    private float _currentCoolDown;
    public float refillSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _currentCoolDown = maxCoolDown;
        shootDelayBar.value = _currentCoolDown;
    }

    // Update is called once per frame
    void Update()
    {

       
        if (_currentCoolDown >= 0 && _currentCoolDown <= 100)
        {
            _currentCoolDown += Time.deltaTime * refillSpeed ;
            shootDelayBar.value = _currentCoolDown;


        }
        else
        {
            _currentCoolDown = 100;
        }

        if (Input.GetMouseButtonDown(0) && _currentCoolDown > 80)
        {
            Instantiate(eraser, transform.position, transform.rotation);
            SetBar();

            Debug.Log("firing");

           

        }
       
    }

    private void FixedUpdate()
    {

      
    }

    private void SetBar()
    {
        _currentCoolDown = 0;
        shootDelayBar.value = _currentCoolDown;
    }

 

   
}
