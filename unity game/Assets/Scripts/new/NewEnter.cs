using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnter : MonoBehaviour
{
    public string LastExitName;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("LastExitName") == LastExitName)
        {
            PlayerLoadScript.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
