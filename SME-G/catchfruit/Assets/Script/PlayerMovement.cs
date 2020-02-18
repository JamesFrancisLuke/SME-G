using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   //we need a speed to move the basket
    private float speed = 10f;
    //a preference to rigidbody
    private Rigidbody2D mybody;
   //Awake is the frist function to initial the game
    void Awake ()
    {    //Get components from the current game object
        mybody = GetComponent<Rigidbody2D>();
        
    }
    //fixedupdate just be called every couple of frame
     void FixedUpdate()
    {     //get current v from the body
        Vector2 vel = mybody.velocity;
        //move basket left and right
        //get horizontal axis for player's press
        vel.x = Input.GetAxis("Horizontal") * speed;
        mybody.velocity = vel;
        
    }

   
    
}
