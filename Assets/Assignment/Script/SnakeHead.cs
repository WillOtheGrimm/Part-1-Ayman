using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{

    Rigidbody2D rigidbody;


    float turnInput;
    public float movingSpeed = 200;
    public float turningSpeed = 300;
    public float maxSpeed = 200;
    public float segmentLength = 1;
    List<SnakeBody> bodySegments = new();
    public SnakeBody bodyPrefab;
    public float maxHeadAngle = 90;
    public GameObject gameOver;



    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        turnInput = Input.GetAxis("Horizontal");


    }

    private void FixedUpdate()
    {

        if (bodySegments.Count > 0)
        {
            Vector3 distanceFromBody = transform.position - bodySegments[0].transform.position;
            float headAngle = Vector3.Angle(distanceFromBody, transform.up);

            if (headAngle <= maxHeadAngle)
            {

                rigidbody.AddTorque(turnInput * -turningSpeed * Time.deltaTime);
            }
        }
        else
        {
            rigidbody.AddTorque(turnInput * -turningSpeed * Time.deltaTime);

        }



        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            Vector2 force = transform.up * movingSpeed * Time.deltaTime;
            rigidbody.AddForce(force);
        }


    }

    public void AddBody()
    {

        SnakeBody newSegment = Instantiate(bodyPrefab);
        newSegment.head = this;

        if (bodySegments.Count == 0)
        {
            newSegment.nextBodyPiece = transform;
        }
        else
        {
            newSegment.nextBodyPiece = bodySegments[bodySegments.Count - 1].transform;
        }
        bodySegments.Add(newSegment);
        newSegment.transform.position = newSegment.nextBodyPiece.position - newSegment.nextBodyPiece.up * segmentLength;

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        gameOver.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("No restart function yet, please restart game.");
    }

}

