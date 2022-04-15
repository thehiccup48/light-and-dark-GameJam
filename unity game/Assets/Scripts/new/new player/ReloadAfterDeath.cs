using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadAfterDeath : MonoBehaviour
{
    string _respawn = "1";
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("death fade").GetComponent<DeathFade>().ShouldReload())
        {
            PlayerPrefs.SetString("LastExitName", _respawn);
            GameObject.Find("Player").GetComponent<Animator>().SetTrigger("live");
            GameObject.Find("Player").GetComponent<Animator>().ResetTrigger("die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
