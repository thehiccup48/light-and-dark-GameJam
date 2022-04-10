using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class PlayerLife : MonoBehaviour
{
    public static PlayerLife instance;
    public GameObject playerSprite;
    private SpriteRenderer playerSpSp;
    GameObject camerafollow;

    Rigidbody2D rb;
    private Animator anim;
    string wereDoIGo;
    bool blackOutNext = false;
    int playerSpawn = 1;

    private void Awake()
    {
       DontDestroyOnLoad(gameObject);
    }

    private void Start()
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

    void Refs()
    {
        camerafollow = GameObject.Find("CM vcam1");
        playerSpSp = playerSprite.GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = playerSprite.GetComponent<Animator>();
        camerafollow.GetComponent<CinemachineVirtualCamera>().Follow = gameObject.transform;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Die();
        }
        if (collision.gameObject.CompareTag("Door"))
        {
            wereDoIGo = collision.gameObject.GetComponent<Exit>().WereDoIGo();
            playerSpawn = collision.gameObject.GetComponent<Exit>().PlayerSpawn();
            PlayerSpawnRef();
            WereDoIGo();
            Leave();
        }
    }

    public string WereDoIGo()
    {
        return wereDoIGo;
    }

    private void Leave()
    {
        rb.bodyType = RigidbodyType2D.Static;

        blackOutNext = true;
    }

    public bool BlackOutNext()
    {
        return blackOutNext;
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    public int PlayerSpawnRef()
    {
        return playerSpawn;
    }
}
