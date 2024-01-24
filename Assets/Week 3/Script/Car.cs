using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float acceleration;
    float steering;
    public float forwardspeed = 500;
    public float steeringspeed = 100;
    Rigidbody2D rigidbody;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steeringspeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardspeed*  Time.deltaTime;
        rigidbody.AddForce(force);

    }





}
