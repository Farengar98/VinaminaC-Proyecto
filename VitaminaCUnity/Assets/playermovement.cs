using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playermovement : MonoBehaviour {


    public float MoveSpeed = 0.1f;

    public float jumpSpeed = 10f;
    public Rigidbody2D rigidBody;
    private SpriteRenderer mySpriteRenderer;

    // Use this for initialization
    void Start () {
    }

    public GameObject ProjectilePrefab;

	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.A))
        {

            transform.Translate(new Vector2(-1, 0) * MoveSpeed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = false;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(1, 0) * MoveSpeed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true; ;
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Instantiate (ProjectilePrefab);
        }
    }
 
}
