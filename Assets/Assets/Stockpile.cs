using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stockpile : MonoBehaviour
{	
    public static Stockpile stockpileInstance;

    [SerializeField]
    private GameObject pooledMissile;
    private bool notEnoughMissiles=true;
    private bool oneMissile = true;
    private bool threeMissiles = true;
    private List<GameObject> missiles;

    private void Awake()
    {
        stockpileInstance=this;
    }

    // Start is called before the first frame update
    void Start()
    {
        missiles=new List<GameObject>();    
    }

    public GameObject getMissile()
    {
        if (missiles.Count>0)
        {
            // i < missiles.Count
            for (int i=0;i<missiles.Count;i++)
            // changed code here
            {
                if(!missiles[i].activeInHierarchy)
                {
                    return missiles[i];
                }
            }
        }
       /* if (notEnoughMissiles || oneMissile || threeMissiles)
        {
            if (notEnoughMissiles) notEnoughMissiles = false;
            else if (oneMissile) oneMissile = false;
            else if (threeMissiles) threeMissiles = false;
            GameObject m=Instantiate(pooledMissile);
            m.SetActive(false);
            missiles.Add(m);
            return m;
        }
        return null;   */

        if (notEnoughMissiles)
        {
            GameObject m=Instantiate(pooledMissile);
            m.SetActive(false);
            missiles.Add(m);
            return m;
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}