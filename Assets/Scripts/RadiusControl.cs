using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusControl : MonoBehaviour
{
    public float min;

    public float max;

    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(speed, speed, 0) * Time.deltaTime;
        if (transform.localScale.x > max)
        {
            transform.localScale = Vector3.zero;
        }
    }
}
