using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCasting : MonoBehaviour {
    public GameObject spellball;
    // R is fire and additional iteration number
    //public int R;
    //public int G;
    //public int B;
    int x = 0;
    // Use this for initialization
    public void Start (){}


    void spellcast()
    {  
        //while (x <= R)
        //{
           // x++;
            GameObject SpellBall = (GameObject)Instantiate(spellball, transform.forward + transform.position, transform.rotation);
            SpellBall.GetComponent<Renderer>().material.color = transform.parent.GetComponent<OrbPickup>().spellcolor;
            SpellBall.GetComponent<Rigidbody>().velocity = transform.forward * (30);
            
        //}
}


	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && transform.parent.GetComponent<OrbPickup>().spellcolor != Color.black)
        {
            spellcast();
            transform.parent.GetComponent<OrbPickup>().spellcolor = Color.black;
            //int R = 0;
            //int G = 0;
            //int B = 0;
            //x = 0;
            //Debug.Log(R);
            //Debug.Log(G);
            //Debug.Log(B);
        }
        }

    }
