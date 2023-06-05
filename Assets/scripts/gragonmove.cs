using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class gragonmove : MonoBehaviour
{
  [SerializeField]  private Transform[] waypoints;
    int wayPoIntIndex;
    private float moveSpeed=1000;
    private Vector3 target;
    void Start()
    {
        updateDestination();
    }

    // Update is called once per frame
    void Update()
    {
     if (Vector3.Distance(transform.position, target) < 1)
        {
            updateDestination();
            itarteWaypointIndex();
        }   
    }

    private void updateDestination()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, waypoints[wayPoIntIndex].position,moveSpeed*Time.deltaTime);
        Debug.Log("RUN");
        // Move the object towards the new position
        transform.position = newPosition;
    }
  private void   itarteWaypointIndex()
    {
        wayPoIntIndex++;
        if(wayPoIntIndex== waypoints.Length)
        {
            wayPoIntIndex = 0;
        }
    }
}
