using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    float degree=0f;
    // vertical angle in radians
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a")) {
            degree+=2;
            Vector3 rotPosition = new Vector3(0,0, degree);
            transform.eulerAngles = rotPosition;

            
            //GetComponent<Rigidbody>().AddRelativeForce (-1.5f, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
           degree-=2;
            Vector3 rotPosition = new Vector3(0,0, degree);
            transform.eulerAngles = rotPosition;
            //GetComponent<Rigidbody>().AddRelativeForce (1.5f, 0, 0);
        }
    }
}