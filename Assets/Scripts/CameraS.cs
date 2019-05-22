using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraS : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        var x = Mathf.Lerp(transform.position.x, player.position.x, 0.125f);
        var y = Mathf.Lerp(transform.position.y, player.position.y, 0.125f);
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
