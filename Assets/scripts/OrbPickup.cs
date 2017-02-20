using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbPickup : MonoBehaviour {

    public Color spellcolor = Color.black;
    public int R;
    public int G;
    public int B;
    // Use this for initialization
    void OnTriggerEnter(Collider other) {


        // Destroy orb get color
        if (other.gameObject.tag == "Red" | other.gameObject.tag == "Green" | other.gameObject.tag == "Blue") {
            Destroy(other.gameObject);
            spellcolor += other.GetComponent<Renderer>().material.color / 26;

            // Up spell stat based on color

            if (other.gameObject.tag == "Red"){
                R++ ;
            }
            if (other.gameObject.tag == "Green")
            {
                G++;
            }
            if (other.gameObject.tag == "Blue")
            {
                B++;
            }

            // Set Max at 10 Spell stat color

            if (R > 10)
            {
                R = 10;
            }
            if (B>10)
            {
                B = 10;
            }
            if (G>10)
            {
                G = 10;
            }

        }

        
    }
}