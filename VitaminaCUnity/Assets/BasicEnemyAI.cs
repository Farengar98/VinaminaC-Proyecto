using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAI : MonoBehaviour {

    private bool LeftOrRight;
    public float enemySpeed;
    Collision2D collision;

    // Use this for initialization
    void Start () {
        LeftOrRight = Random.value > 0.5f;
        if (LeftOrRight)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
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
	}

    void flip()
    {
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }
    void OnTriggerEnter2D(Collider2D something)
    {
        if (something.tag == "Wall")
            GetComponent<SpriteRenderer>().flipX = false;
    }

}

