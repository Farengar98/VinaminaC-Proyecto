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

    public GameObject bulletRight;
	public GameObject bulletLeft;

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
			if (GetComponent<SpriteRenderer> ().flipX) {
				Instantiate (bulletRight);
			}
			else
			{
				Instantiate (bulletLeft);
			}
            
        }



    }

	IEnumerator  waitForASec ()
	{
		yield return new WaitForSeconds (1.0f);
		applyDelay = false;
	}


	public bool applyDelay = false;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "RightTP" || !applyDelay)
		{
			print("hey, estoy triggered Right");
			Vector3 temp = new Vector2(-transform.position.x,transform.position.y);
			transform.position = temp;
			applyDelay = true;
			StartCoroutine (waitForASec());
		}
		if (collision.gameObject.tag == "LeftTP"|| !applyDelay) 
		{
			print("hey, estoy triggered Left");
			Vector3 temp = new Vector2(-transform.position.x,transform.position.y);
			transform.position = temp;
			applyDelay = true;
			StartCoroutine (waitForASec());
		}
}
}
