using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnDistance;
    public float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
    	
        InvokeRepeating("Spawn",0f,spawnInterval);
    }

    private void Spawn()
    {
        GameObject m=Stockpile.stockpileInstance.getMissile();
        if (m!=null)
        {
            m.SetActive(true);
            float angle=Random.Range(0,2*Mathf.PI);
            m.transform.position=new Vector3(transform.position.x+SpawnDistance*Mathf.Cos(angle),
                transform.position.y+SpawnDistance*Mathf.Sin(angle),0);
        }   
    }
}