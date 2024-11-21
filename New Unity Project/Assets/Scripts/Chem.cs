using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Chem : MonoBehaviour
{
    public Text ifCO, ifCO2, ifNO, ifNO2, ifCH4, ifSO2, ifO2;
    public Text tCO, tCO2, tNO, tNO2, tCH4, tSO2, tO2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float sum1 = (float)Convert.ToDouble(ifCO.text) + (float)Convert.ToDouble(ifCO2.text) + (float)Convert.ToDouble(ifNO.text) + (float)Convert.ToDouble(ifNO2.text) + (float)Convert.ToDouble(ifCH4.text) + (float)Convert.ToDouble(ifSO2.text) + (float)Convert.ToDouble(ifO2.text);
        
        tCO2.text = Convert.ToString(100 / sum1 * (float)Convert.ToDouble(ifCO.text));
        tCO.text = Convert.ToString(100 / sum1 * (float)Convert.ToDouble(ifCO2.text));
        tNO2.text = Convert.ToString(100 / sum1 * (float)Convert.ToDouble(ifNO.text));
        tNO.text = Convert.ToString(100 / sum1 * (float)Convert.ToDouble(ifNO2.text));
        tCH4.text = Convert.ToString(100 / sum1 * (float)Convert.ToDouble(ifCH4.text));
        tSO2.text = Convert.ToString(100 / sum1 * (float)Convert.ToDouble(ifSO2.text));
        tO2.text = Convert.ToString(100 / sum1 * (float)Convert.ToDouble(ifO2.text));
    }
}
