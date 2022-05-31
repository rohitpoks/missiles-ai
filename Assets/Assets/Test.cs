using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
	//public CameraFollow cameraFollow;
	public Rigidbody2D rb;
    public Transform player;
    public GameObject cam;
    //public Collision2D collision;
    float angle = 0f;
    float max_velocity = 6f;
    float angular_velocity = 270;
    float seconds = 0;
    // vertical angle in radians
    // Start is called before the first frame update
    
    
    void Start()
    {
    	//collision=GetComponent<Collision2D>();
        QualitySettings. vSyncCount = 0;
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        cam = GameObject.Find("Main Camera");
        //cameraFollow.setUp(new Vector3(0,-3));
        //rb.velocity = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
    	//CollisionGameObjectExample c = new CollisionGameObjectExample();
    	//c.OnCollisionEnter(collision);
    	seconds+=1/60;
    	// get angle
        angle = transform.eulerAngles.z;
        // calculate resultant horizontal and vertical components
        float res_x =  max_velocity * (float) Math.Cos((Math.PI) * (angle-90) / 180);
        float res_y =  max_velocity * (float) Math.Sin((Math.PI) * (angle-90) / 180);
        // generate new velocity
        rb.velocity = new Vector3(res_x, res_y, 0);
        cam.transform.position=new Vector3(transform.position.x,transform.position.y,-10);
        
        if (Input.GetKey("m")) {
            rb.angularVelocity = angular_velocity;
            
            //GetComponent<Rigidbody>().AddRelativeForce (-1.5f, 0, 0);
        }
        else if (Input.GetKey("l"))
        {
            rb.angularVelocity = -angular_velocity;

            //GetComponent<Rigidbody>().AddRelativeForce (1.5f, 0, 0);
        }
        else {
            rb.angularVelocity = 0;
        }
    }
}