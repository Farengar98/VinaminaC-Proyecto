using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float maxSpeed = 1f;
    public float speed;
    bool initialDir;
    private Rigidbody2D rb2d;

    public int vida = 2;

    // Use this for initialization
    void Start()
    {
        //speed = Random.Range (0.75f, 1.25f);
        rb2d = GetComponent<Rigidbody2D>();
        initialDir = (Random.value > 0.5f);

        if (initialDir)
        {

            speed *= -1;
        }
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

        if (speed < 0)
        {

            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = true;

        }

        if (vida < 1)
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

    void OnCollisionEnter2D(Collision2D something)
    {
        if (something.gameObject.tag == "Wall")
        {
            //  GetComponent<SpriteRenderer>().flipX = false;
        }
        if (something.gameObject.tag == "Bullet")
        {
            //Destroy();
            print("menos vida cohone");
            vida--;
        }
        if (something.gameObject.tag == "Suelo")
        {
            Vector3 temp = new Vector2(transform.position.x, (-1) * transform.position.y);
            transform.position = temp;

        }

    }
}
