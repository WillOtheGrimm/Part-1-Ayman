using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rigidbody;

    //To have a speed variable for player movement
    public float speed = 5f;

    Vector2 direction;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //This is to control input and movement 
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
       
        rigidbody.AddForce(direction * force * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player hit something");
    }
}
