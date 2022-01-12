using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{   

    private Rigidbody2D rb;
    private Vector2 direction = new Vector2 (1,0);
    private int speed = 1;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) {
            rb.AddForce(transform.position = new Vector2(1,0)*speed);
            //transform.Translate(direction.up*speed);
        }

        if(Input.GetKey(KeyCode.Q)) {
            rb.AddForce(transform.position = new Vector2(-1,0)*speed);
            //transform.Translate(-direction.up*speed);
        }

    }
}
