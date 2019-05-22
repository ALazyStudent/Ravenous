using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Player PlayerStats;

    Rigidbody2D myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        PlayerStats = FindObjectOfType<Player>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * PlayerStats.speed * Time.deltaTime;
            //myRB.MovePosition(transform.position + (Vector3.up * PlayerStats.speed));
            //transform.position += Vector3.up * PlayerStats.speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * PlayerStats.speed * Time.deltaTime;
            //myRB.MovePosition(transform.position + (Vector3.left * PlayerStats.speed));
            //transform.position += Vector3.left * PlayerStats.speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * PlayerStats.speed * Time.deltaTime;
            //myRB.MovePosition(transform.position + (Vector3.down * PlayerStats.speed));
            //transform.position += Vector3.down * PlayerStats.speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * PlayerStats.speed * Time.deltaTime;
            //myRB.MovePosition(transform.position + (Vector3.right * PlayerStats.speed));
            //transform.position += Vector3.right * PlayerStats.speed;
        }
    }
}
