using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScriptRight : MonoBehaviour {

    public float bulletSpeed = 10; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer>().flipX = false;
		transform.Translate(new Vector2(bulletSpeed, 0));

	}
}
