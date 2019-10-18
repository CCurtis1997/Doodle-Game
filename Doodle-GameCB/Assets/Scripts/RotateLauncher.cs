using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLauncher : MonoBehaviour
{
    public float offset;

    public GameObject pencilPoint;
    public Vector3 pencilOffset;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pencilPoint.transform.position + pencilOffset;

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
       
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
    }
}
