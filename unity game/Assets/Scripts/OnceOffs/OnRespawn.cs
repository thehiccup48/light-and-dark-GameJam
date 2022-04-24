using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnRespawn : MonoBehaviour
{
    bool inLanternRoom = false;
    bool respawned = false;

    // Update is called once per frame
    void Update()
    {
        if (respawned)
        {
            GameObject.Find("set Active").GetComponent<setActiveLights>().enabled = true;
            respawned = false;
        }
        if (SceneManager.GetActiveScene().name == "lanternRoom")
        {
            inLanternRoom = true;
        }
        else
        {
            inLanternRoom = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy") && inLanternRoom)
        {
            respawned = true;
        }
    }
}
