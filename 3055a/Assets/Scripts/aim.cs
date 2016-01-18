using UnityEngine;
using System.Collections;

public class aim : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        bool rot = GetComponentInParent<Movement>().facingRight;
        Vector3 mousePos = Input.mousePosition;                                             //get mouse position                                     
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);             //Get object position and put it "on the screen" (same as mouse) 
        if (rot == true)
        {
            Vector3 offset = new Vector3(mousePos.x - screenPos.x, mousePos.y - screenPos.y);   //Check where the mouse is relative to the object 
            float angle = Mathf.Atan2(offset.x, offset.y) * Mathf.Rad2Deg;                      //Turn that into an angle and convert to degrees
            transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.back);                     //Set the object's rotation to be of the angle over -Z
        }
        else
        {
            Vector3 offset = new Vector3(mousePos.x + screenPos.x, mousePos.y - screenPos.y);   //Check where the mouse is relative to the object 
            float angle = Mathf.Atan2(offset.x, offset.y) * Mathf.Rad2Deg;                      //Turn that into an angle and convert to degrees
            transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.back);                     //Set the object's rotation to be of the angle over -Z
        }
    }   
}
