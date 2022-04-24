using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    GameObject LanternIcon;
    GameObject waypoint;
    private int currentWaypointIndex = 0;
    Animator m_Animator;

    private void Start()
    {
        LanternIcon = GameObject.Find("Lantern icon");
        m_Animator = LanternIcon.GetComponent<Animator>();
        waypoint = GameObject.Find("enemywaypoint");
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
        transform.position = Vector2.MoveTowards
            (transform.position, waypoint.transform.position, speed * Time.deltaTime);
    }
}