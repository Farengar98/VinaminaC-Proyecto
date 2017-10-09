using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScriptLeft : MonoBehaviour {

    public float bulletSpeed = 10; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer>().flipX = true;
        transform.Translate(new Vector2(-bulletSpeed, 0));

	}
}
