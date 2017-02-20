using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinemaster : MonoBehaviour
{
    // Instantiate a prefab with an attached Missile script
    public GameObject SfirePrefab;
    public GameObject SearthPrefab;
    public GameObject SwaterPrefab;
    public Transform GM;


    void Start()
    {
        Shrinegen();
    }

    private void Shrinegen()
    {

        Vector3 placement = Random.insideUnitSphere * 45;
        placement += GM.position;
        placement.y = 3;
        // Instantiate the orb at the position and rotation of this object's transform
        GameObject sffab = (GameObject)Instantiate(SfirePrefab, placement, transform.rotation);
        placement = Random.insideUnitSphere * 45;
        placement.y = 3;
        GameObject sefab = (GameObject)Instantiate(SearthPrefab, placement, transform.rotation);
        placement = Random.insideUnitSphere * 45;
        placement.y = 3;
        GameObject swfab = (GameObject)Instantiate(SwaterPrefab, placement, transform.rotation);
    }
}
