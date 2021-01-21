
using UnityEngine;

public class Waypoints : MonoBehaviour
{


    //Static class allows me to refrance "points" from anywhere
    public static Transform[] points;

    private void Awake()
    {
        //Assigning the "points" a value equal to that of the childs of whatever object this script is attached to
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            //Creating array to easely store value
            points[i] = transform.GetChild(i);
        }
    }
}
