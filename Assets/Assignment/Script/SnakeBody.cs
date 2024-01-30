using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBody : MonoBehaviour
{

    Rigidbody2D rigidbody;
    public SnakeHead head;
    public Transform nextBodyPiece;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        Vector2 changeInPosition = (transform.position - nextBodyPiece.position).normalized * head.segmentLength;

        rigidbody.MovePosition((Vector2)nextBodyPiece.position + changeInPosition );



        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward,nextBodyPiece.position - transform.position);
        rigidbody.MoveRotation(targetRotation);

    }


}
