using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playermovement : MonoBehaviour {


    public float MoveSpeed = 0.1f;

    public float jumpValue = 1;
    public Rigidbody2D cosa;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-MoveSpeed, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(+MoveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            cosa.AddForce(transform.up * jumpValue); 
        }
    }
}
