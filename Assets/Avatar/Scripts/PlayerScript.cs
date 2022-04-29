using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
     private Transform finger;
     public Animator animator;
    //  public GameObject mParentComp;

    //  public GameObject RuntimeTarget;
    private bool push;

         
     void Start () 
     {
         animator = GetComponent<Animator>();
         push = false;

         
          // Find finger and raycast
        //  finger = GameObject.Find("RightHandIndex4").transform;
        finger = GameObject.Find("RaycastPoint").transform;
         
         
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
        // // Ray casting code

        //     float maxRayDistance = 1f;
        //     var direction = finger.forward;
        //     var origin = finger.position;
        //     var Ray = Physics.Raycast(origin,direction, out RaycastHit hit, maxRayDistance);

            

            

        //     if(Ray && hit.collider.tag != "Player" )
        //     {
        //         Debug.Log("hit somethig");
        //         // Vector3 forward = origin;
        //         // Debug.DrawRay(transform.position, forward, Color.green);

        //         Debug.DrawLine(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                
                              

        //         if (hit.collider.tag == "Bubble"  )
        //             {
        //                 // gameObject.SetActive(false);
        //                 Debug.Log("hit bubble");
                        
        //             }   
        //     }
        //     else
        //     {
        //         // Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        //         Debug.Log("Did not Hit");
        //         Debug.DrawLine(transform.position, transform.TransformDirection(Vector3.forward) * 0.1f, Color.green);
        //     }
        

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
