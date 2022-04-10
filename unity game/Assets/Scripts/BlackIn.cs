using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackIn : MonoBehaviour
{
    Color color;
    bool stopFade = false;
    float fadeSpeed = 0.3f;

    void Start()
    {
        color = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        FadeIn();
    }

    private void FadeIn()
    {
        if (stopFade == false)
        {
            color.a -= Time.deltaTime * fadeSpeed;
        }
        gameObject.GetComponent<SpriteRenderer>().color = color;
        if (color.a <= 0)
        {
            stopFade = true;
        }
    }
}
