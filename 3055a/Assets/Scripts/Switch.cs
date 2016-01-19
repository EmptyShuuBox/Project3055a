using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
    public bool doorOpen = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        OnTriggerEnter2D();

    }
    void OnTriggerEnter2D()
    {
        GameObject entrance = GameObject.Find("Door");
        Vector3 entrancePos = entrance.transform.position;

        if (Input.GetKey(KeyCode.Q) == true && doorOpen == false)
        {
            entrancePos.y += 1.2f;
            entrance.transform.position = entrancePos;
            doorOpen = !doorOpen;
        }
        else if (Input.GetKey(KeyCode.Q) == true && doorOpen == true)
        {
            entrancePos.y -= 1.2f;
            entrance.transform.position = entrancePos;
            doorOpen = !doorOpen;
        }
    }
}
