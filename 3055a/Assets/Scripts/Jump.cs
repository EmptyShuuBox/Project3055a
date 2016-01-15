using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
    public float jumpHeight = 0.0f;
    private float movey = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.Space))
        {
            Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.y = CalculateJumpVerticalSpeed(jumpHeight);
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
	}
    public static float CalculateJumpVerticalSpeed(float targetjumpHeight)
    {
        return Mathf.Sqrt(2f * targetjumpHeight * Physics2D.gravity.y);
    }
}
