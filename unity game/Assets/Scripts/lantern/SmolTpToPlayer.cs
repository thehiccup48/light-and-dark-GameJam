using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmolTpToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (GameObject.Find("black in").GetComponent<SpriteRenderer>().color.a > 0)
        {
            transform.position = GameObject.Find("Lantern waypiont").transform.position;
        }        
    } 
}
