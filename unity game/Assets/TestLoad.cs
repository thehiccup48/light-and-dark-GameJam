using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoad : MonoBehaviour
{
    Color Spr;
    float fadeSpeed = 0.3f;
    bool fade = false;
    GameObject playerSprite;
    GameObject player;
    SpriteRenderer playerSpr;
    Animator playerAnimtor;
    // Start is called before the first frame update
    void Start()
    {
        playerSprite = GameObject.Find("PlayerSprite");
        player = GameObject.Find("Player");
        playerSpr = playerSprite.GetComponent<SpriteRenderer>();
        playerAnimtor = playerSprite.GetComponent<Animator>();
        Spr = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        Fade();
        if (Spr.a >= 1)
        {
            fade = false;
            playerAnimtor.SetBool("life", true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        gameObject.GetComponent<SpriteRenderer>().color = Spr;
    }

    private void Fade()
    {
        if (playerSpr.enabled == false)
        {
            fade = true;
        }
        if (fade == true)
        {
            Spr.a += fadeSpeed * Time.deltaTime;
        }
    }
}
