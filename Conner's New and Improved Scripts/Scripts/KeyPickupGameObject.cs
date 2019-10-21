using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickupGameObject : MonoBehaviour
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
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            key.enabled = true;
            Debug.Log("Giggity");
        }
    }
}
