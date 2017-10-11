﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAI : MonoBehaviour
{
    public int vida = 2;
    public float maxSpeed = 1f;
    public float speed = 1f;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        rb2d.AddForce(Vector2.right * speed);
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

        if (rb2d.velocity.x > -0.01f && rb2d.velocity.x < 0.01f)
        {
            speed = -speed;
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }

        if(vida < 1)
        {
            Destroy(gameObject);
        }

        /*//Animaciones
         if (speed > 0)
         {
             transform.localScale = new Vector3(1f, 1f, 1f);
         }
         if (speed < 0)
         {
             transform.localScale = new Vector3(1f, 1f, 1f);
         }*/

    }
}

/*
void OnTriggerEnter2D(Collider2D something)
    {
        if (something.tag == "Wall")
		{
          //  GetComponent<SpriteRenderer>().flipX = false;
   		}
        if(something.tag == "Bullet")
        {
             //Destroy();
        }


    }*/
