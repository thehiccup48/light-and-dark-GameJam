using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class container : MonoBehaviour
{
    public GameObject button;
    public GameObject smolLantern;
    public GameObject lantern;
    public GameObject lanternIcon;
    public GameObject Lights;
    public GameObject Door;
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    [SerializeField] private float speed = 2;
    Vector3 previousPos;
    // Update is called once per frame
    void Update()
    {
        if (button.GetComponent<BoxCollider2D>().isActiveAndEnabled == false)
        {
            if (currentWaypointIndex != 1)
            {
                Move();
            }
           gameObject.GetComponent<Animator>().SetTrigger("turn_on");
            if (transform.position == previousPos)
            {
                lantern.SetActive(true);
                smolLantern.GetComponent<SmolLanternFollow>().enabled = true;
                smolLantern.GetComponent<GlowScript>().enabled = true;              
                lanternIcon.SetActive(true);
                Lights.SetActive(true);
                Door.GetComponent<NewExit>().sceneToLoad = "2 lantern transition";
            }
            previousPos = transform.position;
        }  
    }

    private void Move()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .001f)
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
