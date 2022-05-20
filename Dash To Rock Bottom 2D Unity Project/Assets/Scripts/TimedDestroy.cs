using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{

    //unity editor variable
    public float goalTime; //number of seconds the object should live for (max time on timer)

    //Private variable (used internally in the script)
    private float startTime; //time stamp the timer is starting at (timestamp is seconds since game started)
    
    // Start is called before the first frame update
    void Start()
    {
        //Time.time - current time stamp
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //delcare variable to contain end timestamp for comparisons
        float endTime;
        //end timestamp is start timestamp plus how long the object should live
        endTime = startTime + goalTime;

        //check if current time is greater or equal to end time, if it is, perform action
        if (Time.time >= endTime)
        {
            //destroy this object
            Destroy(gameObject);
        }
    }
}
