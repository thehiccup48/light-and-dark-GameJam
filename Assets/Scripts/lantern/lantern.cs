using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternScript : MonoBehaviour
{
    public bool isLightOn = false;
    public float cooldownTime = 2f;
    private float timeToNextUse = 0;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToNextUse)
        {
            if (Input.GetKey("f"))
            {
                isLightOn = !isLightOn;
                timeToNextUse = Time.time + cooldownTime;
            }           
        }
    }
}
