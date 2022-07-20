using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform[] patrol;
    private int Currentpoint;
    public float moveSpeed;


    void Start()
    {
        transform.position = patrol[0].position;
        Currentpoint = 0;
    }

 void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Waypoint")
            {
                Flip();
            }
        }
    void Flip()
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

    void Update()
    {
       

        if (transform.position == patrol[Currentpoint].position)
        {
            Currentpoint++;
            
        }

        if (Currentpoint >= patrol.Length)
        {
            Currentpoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrol[Currentpoint].position, moveSpeed * Time.deltaTime);
    }

    

}
