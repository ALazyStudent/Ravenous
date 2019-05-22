﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenSprite : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        float cameraHeight = Camera.main.orthographicSize * 2;
        Vector2 cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
        Vector2 spriteSize = spriteRenderer.sprite.bounds.size;

        Vector2 scale = transform.localScale;
        if (cameraSize.x >= cameraSize.y)
        { // Landscape (or equal)}
            scale *= cameraSize.x / spriteSize.x;
        } else { //portrait
            scale *= cameraSize.y / spriteSize.y;
                }

        transform.position = Vector2.zero; //optional
        transform.localScale = scale;
    }
}


