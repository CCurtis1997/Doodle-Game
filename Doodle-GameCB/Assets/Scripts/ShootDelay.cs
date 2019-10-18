using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootDelay : MonoBehaviour
{
    public Slider shootDelayBar;
    public float maxCoolDown = 100;
    private float _currentCoolDown;

    // Start is called before the first frame update
    void Start()
    {
        _currentCoolDown = maxCoolDown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
