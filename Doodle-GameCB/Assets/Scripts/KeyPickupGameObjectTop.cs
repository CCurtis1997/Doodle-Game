using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickupGameObjectTop : MonoBehaviour
{
    public Image keyTop;
    // Start is called before the first frame update
    void Start()
    {
        keyTop.enabled = false;
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

            keyTop.enabled = true;
            Debug.Log("Giggity");
        }
    }


}
