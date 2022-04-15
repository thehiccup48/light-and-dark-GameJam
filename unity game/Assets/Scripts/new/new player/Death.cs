using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    Animator _animator;

    public bool isPlayerDead = false;
    private void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (!_spriteRenderer.enabled)
        {
            isPlayerDead = true;
        }
        if (_spriteRenderer.enabled)
        {
            isPlayerDead = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Die();
        }

    }

    private void Die()
    {
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        _animator.ResetTrigger("live");
        _animator.SetTrigger("die");
    }

    public bool IsDead()
    {
        return isPlayerDead;
    }
}
