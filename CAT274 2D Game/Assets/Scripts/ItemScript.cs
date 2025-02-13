using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    public string objectName;

    public CharacterMoveDict myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<CharacterMoveDict>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
            myPlayer.AddItem(objectName);
            Destroy(gameObject);

        
    }
}
