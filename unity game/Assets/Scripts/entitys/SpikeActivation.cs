using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeActivation : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Activate");
    }
}
