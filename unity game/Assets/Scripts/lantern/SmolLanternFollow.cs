using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmolLanternFollow : MonoBehaviour
{
    public static SmolLanternFollow instance;
    GameObject lanternWaypoint;

    [SerializeField] private float speed;
    private void Start()
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
        lanternWaypoint = GameObject.Find("Lantern waypiont");
    }
    // Update is called once per frame
    void Update()
    {       
            move();
    }
    void move()
    {
        transform.position = Vector2.MoveTowards
            (transform.position, lanternWaypoint.transform.position, speed * Time.deltaTime);
    }
}
