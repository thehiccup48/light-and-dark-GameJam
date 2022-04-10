using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blackout : MonoBehaviour
{
    public static Blackout instance;
    public GameObject PlayerSprite;
    public GameObject Player;
    SpriteRenderer playerSR;
    SpriteRenderer _spriteRenderer;
    
    bool blackout1 = false;
    float fadeSpeed = 0.3f;
    Color color;
    Color blankColor;

    private void Awake()
    {
        blankColor.a = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        Refs();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerSR.enabled == false)
        {
            BlackOutDeath();
        }
        if(Player.GetComponent<PlayerLife>().BlackOutNext() == true)
        {
            BlackOutNext();
        }
    }

    private void Refs()
    {
        playerSR = PlayerSprite.GetComponent<SpriteRenderer>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        color = _spriteRenderer.color;
        blankColor.a = 0;
    }

    private void BlackOutNext()
    {
        BlackOut();
        if (_spriteRenderer.color.a >= 1)
        {
            _spriteRenderer.color = blankColor;
            NextLevel();
        }
    }

    void BlackOutDeath()
    {
        BlackOut();
        if (_spriteRenderer.color.a >= 1)
        {
            _spriteRenderer.color = blankColor;
            RestartLevel();
        }
    }
    void BlackOut()
    {
        color.a += fadeSpeed * Time.deltaTime;
        _spriteRenderer.color = color;
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void NextLevel()
    {
        SceneManager.LoadScene(Player.GetComponent<PlayerLife>().WereDoIGo());
    }
}
