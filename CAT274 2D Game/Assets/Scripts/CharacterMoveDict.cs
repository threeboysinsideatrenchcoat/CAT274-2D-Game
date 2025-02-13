using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;
using UnityEngine.SceneManagement;
//adding text to game
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharacterMoveDict : MonoBehaviour
{
    public static CharacterMoveDict Instance; 

    public GameObject player;
    public float speed = 0.2f;

    //Making a Dictionary 
    public Dictionary<string, int> myInventoryDict = new Dictionary<string, int>();

    public TextMeshProUGUI inventoryDisplay;

    public int KillCount = 0; 
    
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
            //myInventoryDict.Add("Key",1);
           // DisplayInventory(); 
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

        if (KillCount == 10)
        {
            SceneManager.LoadScene("Ending");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && Input.GetKey(KeyCode.Space))
        {
            Destroy(collision.gameObject);
            KillCount += 1;
        }

        if (collision.gameObject.tag == "Bush" && Input.GetKey(KeyCode.E))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Special Bush" && Input.GetKey(KeyCode.E))
        {
            Destroy(collision.gameObject);
        }

        int test;
        myInventoryDict.TryGetValue("key", out test);

        if (collision.gameObject.tag == "door"  && test == 1)  
        {
            SceneManager.LoadScene("HouseScene");

        }

    }
    //   if (collision.gameObject.tag == "Bush" && Input.GetKey(KeyCode.E))
    //    {

    public void AddItem(string itemname)
    {
        myInventoryDict.Add(itemname,1);


    }
    //KillCount = 9 
        


    //if(Destroy(collison.gameObject) && my.inventory )


    ///
    /// 1. size of collider
    ///2. 
    ///
    ///
    ///
    ///

}
