using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToRun : MonoBehaviour
{

    public Animator animator;
    public bool Jump;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Running()
    {
        animator.SetTrigger("isRunning");
    }


}
