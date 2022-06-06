using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LootScript : MonoBehaviour
{
    //This class has variables that the player can define, such as the name, item, and drop rarity
    
    [System.Serializable]
    public class DropCurrency
    {
        public string name;
        public GameObject item;
        public int dropRarity;
    }

    

    public List <DropCurrency> LootTable = new List<DropCurrency>();
    //Allows the player to set how likely something is to drop
    public int dropChance;
    
    public void calculateLoot()
    {
        //this gets a random value between 0 and 101
        int calc_dropChance = Random.Range(0, 101);

        if(calc_dropChance > dropChance)
        {
            //If the rnadom drop chance is larger than the player define done, do nothing
            //send a debug message to the console telling that there was no modifier selected
            Debug.Log("No modifier was selected");
            return;
        }

        if(calc_dropChance <= dropChance)
        {
            int itemWeight = 0;

            //Caclulates the item weight to determine which item is to be dropped
            for(int i = 0; i <LootTable.Count; i++)
            {
                itemWeight += LootTable[i].dropRarity;
            }
            Debug.Log("ItemWeight= " + itemWeight);

            int randomValue = Random.Range(0, itemWeight);

            for(int j = 0;j <LootTable.Count; j++)
            {
                if (randomValue <= LootTable[j].dropRarity)
                {
                    Instantiate(LootTable[j].item, transform.position,Quaternion.identity);
                    return;

                }
                randomValue -= LootTable[j].dropRarity;
                Debug.Log("Random Value decreased" + randomValue);

            }


        }

    }
}
