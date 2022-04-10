using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternCheck : MonoBehaviour
{
    public GameObject Lantern;

    // Update is called once per frame
    void Update()
    {
        if (Lantern.GetComponent<LanternScript>().isLightOn == true)
        {
            Debug.Log("On");
        }
        if (Lantern.GetComponent<LanternScript>().isLightOn == false)
        {
            Debug.Log("Off");
        }
    }
}
