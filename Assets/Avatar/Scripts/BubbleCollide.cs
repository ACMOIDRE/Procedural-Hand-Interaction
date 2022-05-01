using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleCollide : MonoBehaviour
{
    public Transform PlayerColliderGet;
    private void Start()
    {

        Physics.IgnoreCollision(PlayerColliderGet.GetComponent<Collider>(), GetComponent<Collider>(), true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bubble")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Finger Sphere collider collided with  Bubble");

            // other.gameObject.SetActive(false);

            
        }



    }
}
