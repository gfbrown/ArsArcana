using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusGen : MonoBehaviour {
    public GameObject FocusPrefab;
    public Transform shrine;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Focgen", 0.0f, 1.0f);
        InvokeRepeating("Focgen", 0.0f, 1.0f);
    }
    private void Focgen()
    {
        Vector3 placement;
        placement = shrine.position;
        placement.y = 5;
        GameObject fab = (GameObject)Instantiate(FocusPrefab, placement, transform.rotation);
    } 
	// Update is called once per frame
	void Update () {
		
	}
}
