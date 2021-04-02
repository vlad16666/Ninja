using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyContr : MonoBehaviour
{
    Animator anim;
    float v;
    float h;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     v = Input.GetAxis("Vertical");
     anim.SetFloat("run",v);
    h = Input.GetAxis("Horizontal");   
    if(Input.GetKeyDown("space")){
        anim.SetTrigger("jump");
    }
    if(Input.GetButtonDown("Fire1")){
        anim.SetTrigger("attack");
    }
    }
    public void Poluchatel(float arg) 
    {
        transform.rotation = Quaternion.Euler(0,arg,0);
    }
}
