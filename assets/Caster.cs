using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caster : MonoBehaviour
{

    public Color spellcolor = Color.black;
    // Use this for initialization
    public int R = 0;
    public int G = 0;
    public int B = 0;
    public GameObject spellball;
    void OnTriggerEnter(Collider other)
    {


        // Destroy orb get color
        if (other.gameObject.tag == "Red" | other.gameObject.tag == "Green" | other.gameObject.tag == "Blue")
        {
            Destroy(other.gameObject);
            spellcolor += other.GetComponent<Renderer>().material.color / 10;

            // Up spell stat based on color

            if (other.gameObject.tag == "Red")
            {
                R++;
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
            if (B > 10)
            {
                B = 10;
            }
            if (G > 10)
            {
                G = 10;
            }

        }


    }
}
