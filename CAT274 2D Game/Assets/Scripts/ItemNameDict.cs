using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemNameDict : MonoBehaviour
{
    public string itemName;
    public CharacterMoveDict myPlayer; 
    public int itemNumber = 1;

    public Dictionary<string, int> myInventoryDict = new Dictionary<string, int>();

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
       // AddItem();
        Destroy(gameObject);
    }
//Function for adding items 

}
