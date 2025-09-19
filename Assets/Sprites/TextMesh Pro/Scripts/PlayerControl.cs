using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


   public float movSpeed;
   float speedX, speedY;
   Rigidbody2D rb;

   void Start()
   {
      rb = GetComponent<Rigidbody2D>();
      
   }

   void Update()
   {
      
      speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
      speedY = Input.GetAxisRaw("Vertical") * movSpeed;
      
     



      rb.velocity = new Vector2(speedX, speedY);

      //transform.localScale = new Vector3(-transform.localScale.x,transform.localScale.y,transform.localScale.z);


   }
}
