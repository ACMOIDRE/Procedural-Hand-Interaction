using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMove : MonoBehaviour
{
    private float speed = 4f;

    public float maxSpeed;

    public Vector3 _directionVector;

    public List<Vector3> _listVector;

    public float time = 4f;
    float current = 0f;

    private GameObject BubbleObj;       // Tag assign "Bubble"
    public Color material1;
    public Color material2;

    public Shader Shader1;  // set standard shader

    Rigidbody Rb;


    bool isAvailable = true;

    public Transform bubblePosition;

    public static BubbleMove instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        // move up
        Renderer rend = GameObject.FindGameObjectWithTag("Bubble").GetComponent<Renderer>();
        Rb = GetComponent<Rigidbody>();

        float sizemin = 0.5f;
        float sizemax = 1.0f;
        float bubbleD = Random.Range(sizemin, sizemax); // Size of the bubble

        this.transform.localScale = new Vector3(bubbleD / 10, bubbleD / 10, bubbleD / 10);
        _directionVector = Vector3.up;

    }



    // Update is called once per frame
    void Update()
    {



        current += Time.deltaTime;
        //  Debug.Log(current);

        if (current > time )
        {


            transform.localPosition = new Vector3(68.2610016f, 0.976000011f, 71.939003f);
            // transform.localPosition = 		bubblePosition.position;					// you can possition holder for spawn loc.

            gameObject.SetActive(true);

            Renderer rend = GameObject.FindGameObjectWithTag("Bubble").GetComponent<Renderer>();

            if (rend.material.color == Color.red)
            {

                rend.material.color = Color.blue;

            }
            else
            {
                rend.material.color = Color.red;
            }

            current = 0f;


        }
        

        else if ( (gameObject.activeSelf) == true && current < time)
        {
            Vector3 force = _directionVector * Time.deltaTime * speed;
            this.gameObject.GetComponent<Rigidbody>().AddForce(force);

        }

		// if ( (gameObject.activeSelf) == false )
        // {
        //     transform.localPosition = new Vector3(68.2610016f, 0.976000011f, 71.939003f);
        //     // transform.localPosition = 		bubblePosition.position;					// you can possition holder for spawn loc.

        //     gameObject.SetActive(true);

        //     Renderer rend = GameObject.FindGameObjectWithTag("Bubble").GetComponent<Renderer>();

        //     if (rend.material.color == Color.red)
        //     {

        //         rend.material.color = Color.blue;

        //     }
        //     else
        //     {
        //         rend.material.color = Color.red;
        //     }

        //     current = 0f;

        // }


		// Stabilizing Rigidbody Upward motion
		if (Rb.velocity.magnitude > maxSpeed)
        {
            Rb.velocity = Vector3.ClampMagnitude(Rb.velocity, maxSpeed);
        }

        float rbVelocity = Rb.velocity.magnitude;
        // Debug.Log(rbVelocity); 


    }




}
