using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{
    //Varibale to define the time before destruction
    public float interval;
    
    void Start()
    {
       //Destory the timer after a certain time
        Destroy (gameObject, interval);
    }

}
