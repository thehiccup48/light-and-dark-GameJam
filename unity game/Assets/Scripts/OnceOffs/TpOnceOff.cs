using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpOnceOff : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(GameObject.Find("smol lantern").transform.position, GameObject.Find("Lantern waypiont").transform.position) < 0.2f)
        {
            GameObject.Find("smol lantern").GetComponent<SmolTpToPlayer>().enabled = true;
        }
    }
}
