using UnityEngine;

public class MoverWayPoints : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints; 
    [SerializeField] private float _speed = 5f; 

    private int currentWaypointIndex = 0;

    private void Update()
    {
        Transform currentWaypoint = _waypoints[currentWaypointIndex];

        MoveToNextPoint(currentWaypoint);

        if (Vector3.Distance(transform.position, currentWaypoint.position) == 0)
        {
            currentWaypointIndex++;
        
            if (currentWaypointIndex == _waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }

    private void MoveToNextPoint(Transform target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

    }
}
