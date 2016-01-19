using UnityEngine;
using System.Collections;

public class moveForward : MonoBehaviour
{
    public float maxSpeed = 0f;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool facingRight = GameObject.Find("PlayerBody").GetComponent<Movement>().facingRight;
        bool shotRight = GameObject.Find("PlayerArm").GetComponent<shooting>().shotRight;

        if (facingRight && shotRight)
        {
            Vector3 pos = transform.position;
            Vector3 velocity = new Vector3(maxSpeed * Time.deltaTime, 0, 0);
            pos += transform.rotation * velocity;
            transform.position = pos;
        }
        else
        {
            
            Vector3 pos = transform.position;
            Vector3 velocity = new Vector3(maxSpeed * Time.deltaTime, 0, 0);

            pos -= transform.rotation * velocity;
            transform.position = pos;
        }
    }
}
