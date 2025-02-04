using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;
//adding text to game
using UnityEngine.UI;

public class CharacterMoveDict : MonoBehaviour
{
    public static CharacterMoveDict Instance; 

    public GameObject player;
    public float speed = 0.2f;

    //Making a Dictionary 
    public Dictionary<string, int> myInventoryDict = new Dictionary<string, int>();

    public TextMeshProUGUI inventoryDisplay;
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

        else 
        { 
            Destroy(gameObject);
        }
    }
    void Start()
        {
        //doing it here makes it happen at the start
            myInventoryDict.Add("Sword",1);
            DisplayInventory(); 
        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
       {
        player.transform.position += Vector3.up * speed;
        Debug.Log("W Pressed");
       }

        if (Input.GetKey(KeyCode.S))
        {
        player.transform.position += Vector3.down * speed;
        Debug.Log("S Pressed");
       }

        if (Input.GetKey(KeyCode.A))
        {
        player.transform.position += Vector3.left * speed;
        Debug.Log("A Pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
         player.transform.position += Vector3.right * speed;
        Debug.Log("D Pressed");
        }
    }

    public void DisplayInventory()
    {
        inventoryDisplay.text = "";
        foreach (var item in myInventoryDict)
        {
            inventoryDisplay.text += "Item: " + item.Key + ", Quantity: " + item.Value + "\n";
        }
    }

}
