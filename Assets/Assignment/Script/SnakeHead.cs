using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{

    Rigidbody2D rigidbody;
    

    float acceleration;
    float turnInput;
    public float movingSpeed = 200;
    public float turningSpeed = 100;
    public float maxSpeed = 200;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        turnInput = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(turnInput * - turningSpeed * Time.deltaTime);


        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            Vector2 force = transform.right  * movingSpeed * Time.deltaTime;
            rigidbody.AddForce(force);
        }


    }



}

