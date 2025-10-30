using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;

    public bool enableMovement = true;

    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      
    }

    void Update()
    {
      if(enableMovement) 
      {
         speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
         speedY = Input.GetAxisRaw("Vertical") * movSpeed;

         
         if (speedX > 0) 
         {
            
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
         }
         else if (speedX < 0) 
         {
            // Flip the scale on the X-axis
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
         }
         
      }
      
      
      rb.velocity = new Vector2(speedX, speedY);

     


    }
}