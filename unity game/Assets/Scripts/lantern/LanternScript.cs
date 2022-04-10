using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lantern : MonoBehaviour
{
    public bool lightOn = false;

    // Update is called once per frame
    void Update()
    {
        if (lightOn = false && Input.GetKey("f"))
        {
            lightOn = true;
        }
        if (lightOn = true && Input.GetKey("f"))
        {
            lightOn = false;
        }
    }

    public bool LightOn()
    {
        if (lightOn == true)
        {
            return true;
        }
        else return false;
    }
}
