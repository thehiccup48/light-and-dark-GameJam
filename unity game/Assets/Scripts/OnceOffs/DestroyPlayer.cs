using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("Player"));
        Destroy(GameObject.Find("lantern"));
        Destroy(GameObject.Find("smol lantern"));
    }
}
