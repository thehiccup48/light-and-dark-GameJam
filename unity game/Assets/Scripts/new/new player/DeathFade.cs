using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFade : MonoBehaviour
{
    Color Spr;
    float fadeSpeed = 0.5f;
    bool fade = false;
    bool shouldReload = false;
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
        if (Spr.a >= 1)
        {
            fade = false;
            shouldReload = true;
        }
        gameObject.GetComponent<SpriteRenderer>().color = Spr;
        Fade();
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

    public bool ShouldReload()
    {
        return shouldReload;
    }

}
