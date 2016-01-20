using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
    private bool doorOpen = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       

    }
    void OnTriggerStay2D()
    {
        
        GameObject entrance = GameObject.Find("Door");
        Vector3 entrancePos = entrance.transform.position;
        
        if (Input.GetKey(KeyCode.Q) == true && doorOpen == false)
        {
         
            entrancePos.y += 1.2f;
            entrance.transform.position = entrancePos;
            doorOpen = true;
        }
        
    }
}
