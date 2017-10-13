using System.Collections;
using UnityEngine;

public class KillFloor : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
