using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float damage;
    public float speed;

    public int health;

    public Text healthText;

    public GameObject loseScreen;

    // Update is called once per frame
    void FixedUpdate()
    {
        healthText.text = "HP " + health;
        if (health <= 0)
        {
            health = 0;
            gameObject.SetActive(false);
            loseScreen.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Imp")
        {
            collision.GetComponent<Imp>().currentHealth -= damage;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Imp")
        {
            health -= 10;
            collision.gameObject.GetComponent<Imp>().Hit();
        }
    }
}
