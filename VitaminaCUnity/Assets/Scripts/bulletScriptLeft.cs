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

		Vector2 position = transform.position;

		position = new Vector2 (position.x + bulletSpeed * Time.deltaTime, position.y);

		transform.position = position;

		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1,1));

		if(transform.position.x > max.x)
		{
			Destroy (gameObject);
		}


	}
}