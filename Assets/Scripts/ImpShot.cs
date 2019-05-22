using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpShot : MonoBehaviour
{
    Player player;

    Rigidbody2D RB;

    float shootingTime;

    public GameObject fireball;

    public float shotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        shootingTime = 0;
        player = FindObjectOfType<Player>();
        RB = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(8, 9, true);
    }

    // Update is called once per frame
    void Update()
    {
        shootingTime += Time.deltaTime;
        //shoot
        if (shootingTime >= 2.4f)
        {
            Shoot();
            shootingTime = 0;
        }
    }

    void Shoot()
    {
        GameObject newFireBall;
        newFireBall = Instantiate(fireball, transform.position, Quaternion.identity);
        newFireBall.transform.SetParent(transform);
        newFireBall.transform.localScale = fireball.transform.localScale;
        newFireBall.SetActive(true);
        var generalDirection = Vector3.Normalize(player.transform.position - transform.position);
        var direction = new Vector2(generalDirection.x, generalDirection.y);
        newFireBall.GetComponent<Rigidbody2D>().AddForce(direction * shotSpeed, ForceMode2D.Impulse);
    }
}
