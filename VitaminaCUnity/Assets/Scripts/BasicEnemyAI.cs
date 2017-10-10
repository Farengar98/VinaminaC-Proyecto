using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAI : MonoBehaviour {
	
	public Transform wallCheck;
	public float wallCheckRadius;
	public LayerMask whatIsWall;
	private bool hittingWall;
	private bool LeftOrRight;

    private bool moveRight;
	public float moveSpeed;
    Collision2D collision;

	public int vida;

    // Use this for initialization
    void Start () {

		vida = 2;
        LeftOrRight = Random.value > 0.5f;
        if (LeftOrRight)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        
    }
	
	// Update is called once per frame
	void Update () {

		/*
        if (transform.localScale.x < 0)
        {
            transform.Translate(new Vector2(enemySpeed/100, 0));
        }
        else
        {
            transform.Translate(new Vector2(enemySpeed /100, 0));
        }

        if(collision.gameObject.tag == "Wall")
        {
            flip();
        }
<<<<<<< Updated upstream:VitaminaCUnity/Assets/Scripts/BasicEnemyAI.cs

		if (collision.gameObject.tag == "Bullet")
			{
			vida--;
			}

		if (vida == 0) 
		{
			Destroy (gameObject);		
		}
	}
=======
*/
		hittingWall = Physics2D.OverlapCircle (wallCheck.position, wallCheckRadius, whatIsWall);

		if (hittingWall) {
			moveRight = !moveRight;
		}

		if (moveRight) {
		
			transform.localScale = new Vector3 (-0.3f, 0.3f, 0.3f);
			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		} else {
			transform.localScale = new Vector3 (0.3f, 0.3f, 0.3f);
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		}
>>>>>>> Stashed changes:VitaminaCUnity/Assets/BasicEnemyAI.cs

    void flip()
    {
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }
    void OnTriggerEnter2D(Collider2D something)
    {
        if (something.tag == "Wall")
		{
          //  GetComponent<SpriteRenderer>().flipX = false;
		

   		}

	}
}