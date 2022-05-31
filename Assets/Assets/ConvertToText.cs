using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertToText : MonoBehaviour
{

    public int holder;
    //holds the text for displaying
    public Text valueText;


    // Update is called once per frame
    void FixedUpdate()
    {
    	holder++;
        //holder = Global.globalVariable;
        valueText.text = "Counter = " + holder.ToString();
    }
}