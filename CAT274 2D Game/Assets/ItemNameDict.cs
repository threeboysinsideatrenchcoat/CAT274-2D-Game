using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemNameDict : MonoBehaviour
{
    public string itemName;
    public CharacterMoveDict myPlayer; 
    public int itemNumber = 1; 

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<CharacterMoveDict>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collison)
    {
        AddItem();
        Destroy(gameObject);
    }
//Function for adding items 
    public void AddItem()
    {
        if(myPlayer.myInventoryDict.ContainsKey(itemName))
        {
            myPlayer.myInventoryDict[itemName]+= itemNumber; 
        }
        else
        {
            myPlayer.myInventoryDict.Add(itemName, itemNumber);
        }
        myPlayer.DisplayInventory();
    }
}
