using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public float cloudSpawnDistance;
    public float numTotalClouds;
    public float spawnVariance;
    public float numCloseClouds;

    public static CloudSpawner cloudSpawnerInstance;


    private void Awake()
    {
        cloudSpawnerInstance=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<numTotalClouds-numCloseClouds;i++)
        {
            Spawn();
        }
        for(int i=0;i<numCloseClouds;i++)
        {
            SpawnClose();
        }
    }

    void SpawnClose()
    {
        GameObject c=CloudPool.cloudPoolInstance.getCloud();
        c.SetActive(true);
        float angle=Random.Range(0f,2*Mathf.PI);
        float r=Random.Range(0,cloudSpawnDistance-.5f*spawnVariance);
        c.transform.position=new Vector3(transform.position.x+r*Mathf.Cos(angle),
            transform.position.y+r*Mathf.Sin(angle),0);
    }
    
    public void Spawn()
    {
        GameObject c=CloudPool.cloudPoolInstance.getCloud();
        c.SetActive(true);
        float angle=Random.Range(0f,2*Mathf.PI);
        float var=Random.Range(-.5f*spawnVariance,.5f*spawnVariance);
        c.transform.position=new Vector3(transform.position.x+(var+cloudSpawnDistance)*Mathf.Cos(angle),
            transform.position.y+(var+cloudSpawnDistance)*Mathf.Sin(angle),0);
    }
}
