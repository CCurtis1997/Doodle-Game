using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickupUI : MonoBehaviour
{
    public Image key;
    
    // Start is called before the first frame update
    void Start()
    {
        key.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && key.enabled == false)
        {
            key.enabled = true;
        }else if (Input.GetKeyDown(KeyCode.Q) && key.enabled == true)
        {
            key.enabled = false;
        }
    }

    
}
