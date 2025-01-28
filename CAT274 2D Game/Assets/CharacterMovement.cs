using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.2f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Character movement 
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

    //Collison with another object 
    private void OnCollisionEnter2D(Collision2D collison)
    {  
        if (collison.gameObject.tag == "Key")
        {
            Destroy(collison.gameObject);
        }

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
}