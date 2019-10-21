using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLockedDoor : MonoBehaviour
{
    public Image keyTop;
    public Image keyBottom;
    
    

    
    public GameObject openDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (keyTop.enabled == true && keyBottom.enabled == true && collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(openDoor, transform.position, Quaternion.identity);
        }
    }
}
