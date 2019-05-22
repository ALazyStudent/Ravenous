using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().health -= 10;
        }
    }
}
