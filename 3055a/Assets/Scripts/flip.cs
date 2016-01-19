using UnityEngine;
using System.Collections;

public class flip : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!GetComponentInParent<Movement>().facingRight)
        {
            
            Vector3 theScale = transform.localScale;
            theScale.y = -1;
            theScale.x = -1;
            theScale.z = -1;
            transform.localScale = theScale;

        }

    }
}
