using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScriptRight : MonoBehaviour
{

    public float bulletSpeed = 10;

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        GetComponent<SpriteRenderer>().flipX = false;
        transform.Translate(new Vector2(bulletSpeed, 0));

        Vector2 position = transform.position;

        position = new Vector2(position.x + bulletSpeed * Time.deltaTime, position.y);

        transform.position = position;



    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}