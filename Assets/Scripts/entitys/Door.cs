using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject LanternIcon;
    public GameObject doorWaypoint2;
    public GameObject doorWaypoint1;
    Animator m_Animator;

    float speed2 = 5;
    float speed1 = 2;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = LanternIcon.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Idle_off"))
        {
            move();
        }

        if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Idle_off"))
        {
            gameObject.transform.position = Vector2.MoveTowards
                (gameObject.transform.position, doorWaypoint1.transform.position, speed2 * Time.deltaTime);
        }
    }
    private void move()
    {
        gameObject.transform.position = Vector2.MoveTowards
                (gameObject.transform.position, doorWaypoint2.transform.position, speed1 * Time.deltaTime);
    }
}
