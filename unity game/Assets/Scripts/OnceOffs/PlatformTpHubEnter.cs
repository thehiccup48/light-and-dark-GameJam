using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTpHubEnter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("LastExitName") == "Enter 1")
        {
            transform.position = new Vector2(transform.position.x, 11);
        }
        if (PlayerPrefs.GetString("LastExitName") == "Enter 2")
        {
            transform.position = new Vector2(transform.position.x, 11);
        }
    }
}
