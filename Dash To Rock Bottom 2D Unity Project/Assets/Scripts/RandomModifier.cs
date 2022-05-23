using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomModifier : MonoBehaviour
{
    public List<GameObject> lights;
    public int[] table = 
    { 
        60, // Modifier 1
        30, //Modifier 2
        10 //Modifier 3
    };

    public int total;
    public int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        //tally total weight
        //draw a random number between 0 and total weight (100)
        foreach(var item in table)
        {
            total += item;
        }

        randomNumber = Random.Range(0, total);

        //for(int i = 0; i < table.length; i++)
        //{
           // if (randomNumber <= table[i])
           // {
           //     lights[i].SetActive(true);
           //     return;
          //  }
         //   else
        //    {
        //        randomNumber -= table[i];
        //    }
     //   }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
