using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class Gamemaster : MonoBehaviour
{
    // Instantiate a prefab with an attached Missile script
    public GameObject firePrefab;
    public GameObject earthPrefab;
    public GameObject waterPrefab;
    public Transform player;


    void Start()
    {
            InvokeRepeating("Orbgen", 0.0f, 2.0f);
    }

    private void Orbgen()
    {
       // if () {
            Vector3 placement = Random.insideUnitSphere * 45;

            placement += player.position;
            placement.y = 5;
            // Instantiate the orb at the position and rotation of this object's transform
            GameObject ffab = (GameObject)Instantiate(firePrefab, placement, transform.rotation);
            placement = Random.insideUnitSphere * 45;
            placement.y = 5;
            GameObject efab = (GameObject)Instantiate(earthPrefab, placement, transform.rotation);
            placement = Random.insideUnitSphere * 45;
            placement.y = 5;
            GameObject wfab = (GameObject)Instantiate(waterPrefab, placement, transform.rotation);
       // }
    } 
}