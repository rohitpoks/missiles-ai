using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//modificaton 2
public class ShipScript : MonoBehaviour
{
	private int degree=0;
	private float xlat=0;
	private float ylat=0;
	public Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
    	//Destroy(gameObject,2f);//destroys game object after 2 seconds
    }

    // Update is called once per frame
    void Update()
    {
    	xlat+=(float)Math.Cos(Math.PI/180*(degree-90))/50;
    	ylat+=(float)Math.Sin(Math.PI/180*(degree-90))/50;
    	Vector3 latPosition = new Vector3(xlat,ylat,0);
    	transform.position = latPosition;
    	//GameObject.Find("Main Camera").transform.position = new Vector3(0,0);
    	
    	if(Input.GetKey(KeyCode.M)){
    		degree+=1;
    		Vector3 rotPosition = new Vector3(0,0, degree);
			transform.eulerAngles = rotPosition;
    	}
    	
    	if(Input.GetKey(KeyCode.L)){
    		degree-=1;
    		Vector3 rotPosition = new Vector3(0,0, degree);
			transform.eulerAngles = rotPosition;
    	}
    }

	void move() {
			
	}
    
    private void OnMouseDown(){//isnt working
    	Destroy(gameObject);
    }
}
