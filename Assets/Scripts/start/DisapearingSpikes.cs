using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearingSpikes : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (button.GetComponent<BoxCollider2D>().isActiveAndEnabled == false)
        {
            Destroy(gameObject);
        }
    }
}
