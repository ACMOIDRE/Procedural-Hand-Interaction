using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMove : MonoBehaviour  
{
	private float speed = 4f;

	public Vector3 _directionVector;

	public List<Vector3> _listVector;

	public float time = 5f;
	float current = 0f;

	

	bool isAvailable = true;

	public Transform bubblePosition;

	public static BubbleMove instance;        
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
		// move up
		_directionVector = Vector3.up;		
		float sizemin = 0.5f;
		float sizemax = 1.0f;
		float bubbleD = Random.Range(sizemin, sizemax); // Size of the bubble

		this.transform.localScale = new Vector3(bubbleD/10, bubbleD/10, bubbleD/10);

	}

	

	// Update is called once per frame
	void Update()
	{
			

		 current += Time.deltaTime;
		if(current > time)
			{
				gameObject.SetActive(false);

				// transform.localPosition = new Vector3(68.2610016f,0.976000011f,71.939003f)	;
				transform.localPosition = 		bubblePosition.position;
				current = 0f;
				
			} 
			else if (  (gameObject.active) == true )
			{
				this.gameObject.GetComponent<Rigidbody>().AddForce(_directionVector * Time.deltaTime * speed);
			}

			
	}

	

	
	
	 





}
