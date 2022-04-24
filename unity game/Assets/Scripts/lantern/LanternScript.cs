using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternScript : MonoBehaviour
{
    public static LanternScript instance;
    public bool isLightOn = false;
    public float cooldownTime = 0f;
    private float timeToNextUse = 0;

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

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
    public bool LightOn()
    {        
        return isLightOn;        
    }
}
