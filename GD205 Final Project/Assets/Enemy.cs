using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    //Creating a float variable (setting it public will allow us to change it outside of the script)
    public float speed = 10f;

    //creating more variables, private will not show up outside of this script
    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        //calling to the Waypoints scripts for imformation
        target = Waypoints.points[0];
    }

    void Update()
    {
        //Tell the enemy object to go to the waypoint(target)
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        //If the enemy gets in a certen distance of the waypoint it triggers the function "GetNextWaypoint"
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            //Starts a custum function
            GetNextWaypoint();
        }

        //The custum function itself
        void GetNextWaypoint()
        {
            //if there are no more waypoints in the line up it will destory the game object and load the game over scene
            if (wavepointIndex >= Waypoints.points.Length - 1)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Game Over");
                return;
            }

            //Changes the "target" to the next one in the array
            wavepointIndex++;
            target = Waypoints.points[wavepointIndex];
        }
    }
}
