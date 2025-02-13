using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpriteChange : MonoBehaviour  
{
    private SpriteRenderer mySpriteRenderer;
    public Sprite newSprite;
// Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        mySpriteRenderer.sprite = newSprite; 
    }

}
