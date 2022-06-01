using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifierTest : MonoBehaviour
{
    public Transform itemHolder;

    public WeightedRandomList<Transform> lootTable;
    
  

    void OnTriggerEnter2D(Collider2D other)
    {
        //Check if score script is attached to the thing we bumped into
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            HideItem();       
        }
    }


    void HideItem()
    {
     
        foreach (Transform child in itemHolder)
        {
            Destroy(child.gameObject);
        }
    }

    void ShowItem()
    {
        Transform item = lootTable.GetRandom();
        Instantiate(item, itemHolder);
        itemHolder.gameObject.SetActive(true);
    }



    
}
