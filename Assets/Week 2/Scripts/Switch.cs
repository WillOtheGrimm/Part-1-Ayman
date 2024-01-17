using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //This is to make it go red when out of the sensor
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger!");
        //this line is to set the color of the sprite to what i want
        spriteRenderer.color = Color.red;
    }


    //This is to make it go green when out of the sensor
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.green;
    }
}
