using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
     private Transform finger;
     public Animator animator;
     public GameObject mParentComp;

    //  public GameObject RuntimeTarget;
    private bool push;

         
     void Start () 
     {
         animator = GetComponent<Animator>();
         push = false;

         
          // Find finger and raycast
         finger = GameObject.Find("RightHandIndex4").transform;
         
         if (finger)
         {
             Debug.Log("Found Finger");
         }
         else
         {
             Debug.Log("Cant Find Finger");
         }

     }
    
 
   

    // Update is called once per frame
    void Update()
    {
        // Ray casting code
            RaycastHit hit;
            float maxDistance = 1f;
            var direction = finger.forward;
            var origin = finger.position;
            var Ray = Physics.Raycast(origin,direction, out  hit, maxDistance);

            if(Ray && hit.collider.tag != "Player"  )
            {
                // Vector3 forward = origin;
                // Debug.DrawRay(transform.position, forward, Color.green);              

                if (hit.collider.tag == "Finish" && hit.collider.tag != "Player" )
                    {
                        // gameObject.SetActive(false);
                    }   
            }
        

        //Click the mouse or tap the screen to change the animation
        if ( Input.GetMouseButtonDown(0) ) 
        {  
            push = true;   
            animator.SetBool("push", true); 

            
            
                 
        } 
         else if (Input.GetMouseButtonDown(1))
        { 
            // push = false;  
            animator.SetBool("push", false);
         }
          
        
        
    }


    



    
}
