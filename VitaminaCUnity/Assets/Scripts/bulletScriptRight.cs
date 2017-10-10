using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScriptRight : MonoBehaviour {

    public float bulletSpeed = 10; 
	public GameObject originPos;

	// Use this for initialization
	void Start () {
		transform.Translate(new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y));
	}

<<<<<<< Updated upstream
	
=======
>>>>>>> Stashed changes
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer>().flipX = false;
		transform.Translate(new Vector2(bulletSpeed, gameObject.transform.position.y));

		Vector2 position = transform.position;

		position = new Vector2 (position.x + bulletSpeed * Time.deltaTime, position.y);

		transform.position = position;

		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1,1));

		if (transform.position.x > max.x ) {
			Destroy (gameObject);
		}
	}
}