using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpPlatformElevator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("lantern").GetComponent<LanternScript>().LightOn())
        {
           transform.position = new Vector2(transform.position.x, 22);
        }
    }
}
