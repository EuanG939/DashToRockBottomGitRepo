using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class PickupControl : MonoBehaviour
{
   //Variables to define the state of each pickup
    public int Pickup1state;
    public int Pickup2state;
    //References the pickupcontrol script
    public static PickupControl control;



    void Awake()
    {
        //Dont destory the pickup control object between scenes if it is present
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        //Othwerwise, destory it
        else if (control != this)
        {
            Destroy(gameObject);
        }


        
    }

        [Serializable]
        class PlayerData
    {
        public int Pickup1state;
        public int Pickup2state;
    }

}
