using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerMovment : MonoBehaviour
{

    public CharacterController2D controller;
    public float runSpeed = 20f;
    Animator animator;

    float horizontalMove = 0f;
    bool jump = false;

    bool notBlackedOut = false;
    bool canMove = false;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>().Follow = gameObject.transform;
        if (CanMove())
        {
            Move();
        }        
        jump = false;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void Move()
    {
        if (canMove)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        }       
    }
    public bool CanMove()
    {
        if (GameObject.Find("black in").GetComponent<SpriteRenderer>().color.a <= 0f && GameObject.Find("death fade").GetComponent<SpriteRenderer>().color.a <= 0f)
        {
            notBlackedOut = true;
        }
        else
        {
            notBlackedOut = false;
        }
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Player_death") && notBlackedOut)
        {
            canMove = true;
        }
        else
        {
            canMove = false;
        }
        return canMove;
    }
}
