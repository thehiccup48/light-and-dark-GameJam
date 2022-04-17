using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReloadAfterDeath : MonoBehaviour
{
    [SerializeField] string _respawn = "1";
    GameObject player;
    Animator playerAnim;
    // Update is called once per frame
    private void Start()
    {
        player = GameObject.Find("Player");
        playerAnim = player.GetComponent<Animator>();
    }
    void Update()
    {
        if (GameObject.Find("death fade").GetComponent<DeathFade>().ShouldReload())
        {
            PlayerPrefs.SetString("LastExitName", _respawn);
            playerAnim.SetTrigger("live");
            playerAnim.ResetTrigger("die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
