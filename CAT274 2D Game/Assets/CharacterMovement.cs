using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static CharacterMovement Instance; 

    public GameObject player;
    public float speed = 0.2f; 
//How to make a List 
   public List<string> myInventory;

//How to make Inventory not full
   public bool inventoryFull = false;

    // Start is called before the first frame update

//How to make a Singleton 
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
        
    }

// Character Movement 
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
//Inventory Limit Size
        if(myInventory.Count >= 20)
        {
        inventoryFull = true; 
        }

        if(myInventory.Count < 20)
        {
        inventoryFull = false; 
        }
    }

//Collison with another object 
    private void OnCollisionEnter2D(Collision2D collison)
    {  
        //if (collison.gameObject.tag == "Key")
        //{
            //Destroy(collison.gameObject);
        //}

//Collison with enemies
        if(collison.gameObject.tag == "Enemy")
        {
            Destroy(player);
        }
    }
    
//Triggering a zone with sound 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter trigger");
    }

// Formula for making a list
    public void addItem(string item)
    {
        myInventory.Add(item);
    }      
}