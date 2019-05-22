using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imp : MonoBehaviour
{
    Player player;

    Spawner spawner;

    public float maxHealth;

    public float currentHealth;

    public float speed;

    Rigidbody2D RB;

    bool hit;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        spawner = FindObjectOfType<Spawner>();
        player = FindObjectOfType<Player>();
        RB = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            spawner.KillImp();
            Destroy(gameObject);
        }

        if (hit)
        {
            timer += Time.deltaTime;
            transform.position += Vector3.Normalize(transform.position - player.transform.position) * (speed * 1.5f) * Time.deltaTime;
            if (timer >= 1)
            {
                hit = false;
                timer = 0;
            }
        }
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.Normalize(player.transform.position - transform.position) * speed * Time.deltaTime;
    }

    public void Hit()
    {
        hit = true;
    }
}
