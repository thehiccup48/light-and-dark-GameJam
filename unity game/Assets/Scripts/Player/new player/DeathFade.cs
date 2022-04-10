using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFade : MonoBehaviour
{
    Color Spr;
    float fadeSpeed = 0.3f;
    bool fade = false;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Spr = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        Fade();
        if (Spr.a >= 1)
        {
            fade = false;
        }
        gameObject.GetComponent<SpriteRenderer>().color = Spr;
    }

    private void Fade()
    {
        if (player.GetComponent<Death>().IsDead())
        {
            fade = true;
        }
        if (fade)
        {
            Spr.a += fadeSpeed * Time.deltaTime;
        }
    }
}
