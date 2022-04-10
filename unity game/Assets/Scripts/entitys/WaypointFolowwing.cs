using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFolowwing : MonoBehaviour
{
    GameObject LanternIcon;
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    Animator m_Animator;

    private void Start()
    {
        LanternIcon = GameObject.Find("Lantern icon");
        m_Animator = LanternIcon.GetComponent<Animator>();
    }

    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {         
        if (!m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Idle_off"))
        {
            move();
        }
        
    }

    void move()
    {
            if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .01f)
            {
                currentWaypointIndex++;
                if (currentWaypointIndex >= waypoints.Length)
                {
                    currentWaypointIndex = 0;
                }
            }

            transform.position = Vector2.MoveTowards
                (transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
