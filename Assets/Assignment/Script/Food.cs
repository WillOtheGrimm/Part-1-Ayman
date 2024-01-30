using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public Collider2D headCollider;
    public SnakeHead head;
    



    // Start is called before the first frame update
    void Start()
    {
        MoveFood();
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == headCollider)
        {
            MoveFood();
            head.AddBody();    

        }
    }

    private void MoveFood() {

        transform.position = Random.insideUnitCircle * 7 ;
    
    }
}
