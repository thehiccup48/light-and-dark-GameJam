using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowScript : MonoBehaviour
{
    GameObject Lantern;
    public Animator animator;

    private void Start()
    {
        Lantern = GameObject.Find("lantern");
    }
    private void Update()
    {
        animator.SetBool("shouldIGlow", Lantern.GetComponent<LanternScript>().isLightOn);
    }
}
