using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	
	// Use this for initialization
	public KeyCode LeftArrow;
	public KeyCode RightArrow;
	public float running_velocity=4f;
	public int laneNumber = 2;
	public bool controlLocked=false;
	

	void Start () {
	

		
	 
	}
	
	// Update is called once per frame
	void Update () {
	GetComponent<Rigidbody>().velocity=new Vector3(0,0,running_velocity);
	if (Input.GetKeyDown(KeyCode.LeftArrow) )
		{
			running_velocity=2;
			
			Rigidbody rb = GetComponent<Rigidbody>();
		    rb.AddForce( 50000000,0,0);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			running_velocity=2;
			//rigidbody.AddForce(50,0,0);
			laneNumber += 1;
			
		}
	    
	}
	
	private void OnTriggerEnter(Collider other)
    {
      
             if(other.gameObject.tag=="coin"){

            Destroy(other.gameObject);
        
        }
   }
}
