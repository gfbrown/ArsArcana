using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Health : MonoBehaviour
{
    public GameObject player;
    public double health = 255;
    public void healthadjust()
    {
        



    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // To test dying.
        if (Input.GetButtonDown("Fire2"))
        {
            health = health - 25.5;
        }
        //What happens when you die.
        if (health <= 0)
        {
            Debug.Log("you died");
            player.transform.position = new Vector3(0,35,0);
        }
    }
}