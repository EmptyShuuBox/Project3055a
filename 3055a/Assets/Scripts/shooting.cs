using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {
    public GameObject bulletPrefab;
    public GameObject bulletLocation;
    public float fireDelay = 0;
    float cooldownTimer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        cooldownTimer -= Time.deltaTime;
	    if(Input.GetKey(KeyCode.Mouse0) && cooldownTimer<=0)
            {
                cooldownTimer = fireDelay;
                Instantiate(bulletPrefab, bulletLocation.transform.position, transform.rotation);
            }
	}
}
