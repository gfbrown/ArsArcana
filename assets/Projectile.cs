using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour {
    // Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        // Ask Colin for help
        //other.GameObject.GetComponent<Health>().health; 
    }
	// Update is called once per frame
	void Update () {
		
	}
}
