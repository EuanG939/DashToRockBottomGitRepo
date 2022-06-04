using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class PickupControl : MonoBehaviour
{
    public int Pickup1state;
    public int Pickup2state;
    public static PickupControl control;



    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
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
