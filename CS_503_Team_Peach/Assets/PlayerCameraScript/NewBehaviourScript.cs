using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
 
    //speed value for movement
    public float maxSpeed = 1f;
    //initialize component
    Rigidbody2D body;

    Animator anim;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // FixedUpdate is called for each physics update.
    void FixedUpdate()
    {  
        //raw input from the user and do appropriate actions (Up and Down)
        float moveUD = Input.GetAxis("Vertical");
        //raw input from user and do the appropriate actions (Left and Right)
        float moveLR = Input.GetAxis("Horizontal");

        //for the animator to determine animation        
        body.velocity = new Vector2 (moveUD * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        anim.SetFloat("UDSpeed", moveUD);

           
        body.velocity = new Vector2(moveLR * maxSpeed, GetComponent<Rigidbody2D>().velocity.x);
        anim.SetFloat("LRSpeed", moveLR);    //Fun fact: didn't use abs value. I need the actual value for direction

      
       
        
   
    
    }

    




}

