using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveLights : MonoBehaviour
{
    public GameObject[] gameObjects;


    // Start is called before the first frame update
    void Start()
    {
        foreach (var objects in gameObjects)
        {
            Destroy(objects);
        }
    }
}
