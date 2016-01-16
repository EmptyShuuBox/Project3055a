using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
      public float speed = 0f;
      public float jump = 0f;
      private float movex = 0f;
      
      bool Grounded = false;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // simple left right movement
        if (Input.GetKey(KeyCode.A))
        {
            movex = -1;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movex * speed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().rotation = 0;
            jumpMechanic();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movex = 1;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movex * speed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().rotation = 0;
            jumpMechanic();
        }
        
        else
        {
            
            movex = 0;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movex * speed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().rotation = 0;
        }
        jumpMechanic();
       
    }

    //jump
    
    private void jumpMechanic()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            if (Grounded)
            {

                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,
                                                                   jump);
            }
        }
    }
    //Check to see if grounded.
    void OnTriggerEnter2D()
    {
        Grounded = true;
    }
    void OnTriggerExit2D()
    {
        Grounded = false;
    }
}
