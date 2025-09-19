using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_patrol : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Transform currentPoint;    
    public float speed;

    private Vector2 velocity;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = PointA.transform.position;
        currentPoint = PointB.transform;

        direction = (currentPoint.position - PointA.transform.position).normalized;
        Debug.Log("direction: "+direction);
        velocity = direction * speed;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("currentPoint: "+currentPoint.gameObject.name);

        //velocity = direction * speed;

        //Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == PointB.transform)
        {
            rb.velocity = velocity;
        }
        else
        {
            rb.velocity = -velocity;
        }

        Debug.Log("Distance: "+Vector2.Distance(transform.position, currentPoint.position));

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointB.transform )
        {
            Debug.Log("Switch to Point B");
            currentPoint = PointA.transform;    
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointA.transform )
        {
            Debug.Log("Switch to Point B");
            currentPoint = PointB.transform;    
        }       
    }   
}
