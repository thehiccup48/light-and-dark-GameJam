using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startplatform : MonoBehaviour
{
    public GameObject button;
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    [SerializeField] private float speed = 2;
    // Update is called once per frame
    void Update()
    {
        if (button.GetComponent<BoxCollider2D>().isActiveAndEnabled == false)
        {
            Move();
            gameObject.GetComponent<Animator>().SetTrigger("turn_on");
        }
        

    }

    private void Move()
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
