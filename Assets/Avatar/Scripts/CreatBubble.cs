using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreatBubble : MonoBehaviour 
{
        // Pooling obj
        public static CreatBubble instance;        

        private List<GameObject> poolObjects = new List<GameObject>();
        private int amountToPool = 1;

        [SerializeField] private GameObject bubblePrefab;

        public Transform bubblePosition;

        bool isAvailable = true;



        private void Awake()
         {
                if  ( instance == null)
                {
                        instance = this;
                }
        }

       



    // Start is called before the first frame update
    void Start()
	{
                
                for (  int i = 0; i < amountToPool; i++ )
                {
                        // GameObject obj = Instantiate(bubblePrefab, new Vector3(68.2610016f,0.976000011f,71.939003f), Quaternion.identity);
                        
                        // Working before load
                        GameObject obj = Instantiate(bubblePrefab, bubblePosition.position, Quaternion.identity);

                        // load resource
                        // GameObject Prefab = (GameObject)Resources.Load("Sphere");
                        // GameObject obj = Instantiate(Prefab, bubblePosition.position, Quaternion.identity);

                        // Instatiate(prefab, new Vector3(posX, posY, posZ), Quaternion.identity);
                        obj.SetActive(false);
                        poolObjects.Add(obj);

                }     

                 

                // // new courountne

                // StartCoroutine(IenumTwo());

                Debug.Log("Start");

	}

      


        public GameObject GetPooledObject()
        {
                for ( int i= 0 ; i < poolObjects.Count; i++)
                {
                        if (!poolObjects[i].activeInHierarchy)
                        {
                                return poolObjects[i];
                                
                        }
                }
                return null;
        }

       
           

        private void Update() 
        {
                // Invoke("BubbleStateUpdate", 5);
                 
                // if(!isAvailable)
                // {
                        StartCoroutine(IenumTwo());      
                // }         
 
        }



         IEnumerator IenumTwo()
	 {
                //              // using courtine function in update




                        yield return new WaitForSeconds(5); 

                        GameObject bubble =  poolObjects[0];
                        // bubble.transform.position = bubblePosition.position;
                        bubble.SetActive(true); 
                          

                        StartCoroutine(IenumTwo());

                
         }



      // public void InstantBubble()
        // {
                 
                 

        //         // //  GameObject bubble = ObjectPool.instance.GetPooledObject();  // not working

        //         // GameObject bubble = instance.GetPooledObject();

        //         GameObject bubble =  poolObjects[0];

        //          if (bubble != null)
        //          {
        //                 bubble.SetActive(true);                
        //          } 
                 

        // }

        

        // // old courountine function
	// IEnumerator IenumCreatBubble()
	// {

        // while (true)
        // {
        //         Debug.Log("before yield");
        // 	yield return new WaitForSeconds(UnityEngine.Random.Range(2, 5 ));                          // Time between two bubbles

        //         // Invoke("InstantBubble", 1);               
               

        //          Debug.Log("after  yield");
            
        // }     


	// }




    
         // public void BubbleStateUpdate( )
        // {
                //              // using invoke function in update

                
        //         GameObject bubble =  poolObjects[0];
        //         bubble.transform.position = bubblePosition.position;

        //         bubble.SetActive(true);  
        // }

        // IEnumerator IenumTwo()
	//  {
                //              // using courtine function in update
        //          while (true)
        //         {
        //                 yield return new WaitForSeconds(10); 
        //                 GameObject bubble =  poolObjects[0];
        //                 bubble.transform.position = bubblePosition.position;

        //                 bubble.SetActive(true);    
        //         }
        //  }

}
