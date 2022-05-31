using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudPool : MonoBehaviour
{
    public static CloudPool cloudPoolInstance;

    [SerializeField] private GameObject pooledCloud1;
    [SerializeField] private GameObject pooledCloud2;
    [SerializeField] private GameObject pooledCloud3;

    private int type=0;
    private bool notEnoughClouds=true;

    private List<GameObject> clouds=new List<GameObject>();

    private void Awake()
    {
        cloudPoolInstance=this;
    }

    // Start is called before the first frame update
    /*void Start()
    {
        clouds=new List<GameObject>();        
    }*/

    // Update is called once per frame

    public GameObject getCloud()
    {
        if (clouds.Count>0)
        {
            for (int i=0;i<clouds.Count;i++)
            {
                if(!clouds[i].activeInHierarchy)
                {
                    return clouds[i];
                }
            }
        }
        if (notEnoughClouds)
        {
            GameObject c;
            if(type%3==0)
            {
                c=Instantiate(pooledCloud1);
            }
            else if(type%3==1)
            {    
                c=Instantiate(pooledCloud2);
            }    
            else
            {
                c=Instantiate(pooledCloud3);
            }
            type+=1;
            c.SetActive(true);
            clouds.Add(c);
            return c;
        }
        return null;
    }
}
