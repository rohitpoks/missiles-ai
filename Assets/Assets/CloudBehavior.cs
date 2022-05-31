using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehavior : MonoBehaviour
{
    public int maxDistance;
    public GameObject cloud;
    GameObject ship;

    void OnEnable()
    {
        ship=GameObject.Find("Ship");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(ship.transform.position,transform.position)>maxDistance)
        {
            CloudSpawner.cloudSpawnerInstance.Spawn();
            cloud.SetActive(false);
        }
    }
}
