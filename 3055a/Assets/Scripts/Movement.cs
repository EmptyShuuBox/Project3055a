using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
      public float speed = 0f;
      private float movex = 0f;
      private float movey = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            movex = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movex = 1;
        }
        else
        {
            movey = 0;
            movex = 0;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(movex * speed, movey * speed);
    }
}
