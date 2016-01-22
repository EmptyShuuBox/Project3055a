using UnityEngine;
using System.Collections;

public class detection : MonoBehaviour {
    public GameObject target;
    public bool enemyDetected = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay2D(Collider2D other)
    {
        enemyDetected = true;
        
    }

}
