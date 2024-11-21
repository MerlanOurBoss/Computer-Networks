using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Chemistry_code : MonoBehaviour
{
    public string name = "unknown";
    public GameObject element,cube;
    string[] ch_elements = new string[] { "CO", "CO2", "NO", "NO2", "CH4", "SO2", "O2" };

    public Button bt_start;
    public InputField ifCO, ifCO2, ifNO, ifNO2, ifCH4, ifSO2, ifO2;
    public Text tCO, tCO2, tNO, tNO2, tCH4, tSO2, tO2;
    int ntCO = 0, ntCO2 = 0, ntNO = 0, ntNO2 = 0, ntCH4 = 0, ntSO2 = 0, ntO2 = 0;

    float sum1;
    float CO, CO2, NO, NO2, CH4, SO2, O2;

    bool l = false;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        bt_start.onClick.AddListener(Chemistry);
        //name =ch_elements[UnityEngine.Random.Range(0, 7)];

        if (ifCO.text != "" && ifCO2.text != "" && ifNO.text != "" && ifNO2.text != "" && ifCH4.text != "" && ifSO2.text != "" && ifO2.text != "")
        {
            sum1 = (float)Convert.ToDouble(ifCO.text) + (float)Convert.ToDouble(ifCO2.text) + (float)Convert.ToDouble(ifNO.text) + (float)Convert.ToDouble(ifNO2.text) + (float)Convert.ToDouble(ifCH4.text) + (float)Convert.ToDouble(ifSO2.text) + (float)Convert.ToDouble(ifO2.text);

        }
        else
        {
            ifCO.text = "0";
            ifCO2.text = "0";
            ifNO.text = "0";
            ifNO2.text = "0";
            ifCH4.text = "0";
            ifSO2.text = "0";
            ifO2.text = "0";

            sum1 = 1;
        }

        if (sum1 == 0)
            sum1 = 1;


        if (ifCO.text != "" && ifCO2.text != "" && ifNO.text != "" && ifNO2.text != "" && ifCH4.text != "" && ifSO2.text != "" && ifO2.text != "")
        {
            CO = 0;
            CO2 = 0;
            NO = 0;
            NO2 = 0;
            CH4 = 0;
            SO2 = 0;
            O2 = 0;

            CO = 100 / sum1 * (float)Convert.ToDouble(ifCO.text);
            CO2 = 100 / sum1 * (float)Convert.ToDouble(ifCO2.text);
            NO = 100 / sum1 * (float)Convert.ToDouble(ifNO.text);
            NO2 = 100 / sum1 * (float)Convert.ToDouble(ifNO2.text);
            CH4 = 100 / sum1 * (float)Convert.ToDouble(ifCH4.text);
            SO2 = 100 / sum1 * (float)Convert.ToDouble(ifSO2.text);
            O2 = 100 / sum1 * (float)Convert.ToDouble(ifO2.text);

           /* Debug.Log(CO);
            Debug.Log(CO2);
            Debug.Log(NO);
            Debug.Log(NO2);
            Debug.Log(CH4);
            Debug.Log(SO2);
            Debug.Log(O2);*/

            CO2 += CO;
            NO += CO2;
            NO2 += NO;
            CH4 += NO2;
            SO2 += CH4;
            O2 += SO2;

           /* Debug.Log(CO);
            Debug.Log(CO2);
            Debug.Log(NO);
            Debug.Log(NO2);
            Debug.Log(CH4);
            Debug.Log(SO2);
            Debug.Log(O2);*/

            num = UnityEngine.Random.Range(0, 100);
            //Debug.Log(num);
        }


    }

    // Update is called once per frame
    void Update()
    {        

        if (!l && element.transform.position.x>cube.transform.position.x-cube.transform.localScale.x/2)
        {
            if (num > 0 && num < CO)
            {
                name = ch_elements[0];
                ntCO = Convert.ToInt32(tCO.text) + 1;
                tCO.text = Convert.ToString(ntCO);
            }
            else if (num > CO && num < CO2)
            {
                name = ch_elements[1];
                ntCO2 = Convert.ToInt32(tCO2.text) + 1;
                tCO2.text = Convert.ToString(ntCO2);
            }
            else if (num > CO2 && num < NO)
            {
                name = ch_elements[2];
                ntNO = Convert.ToInt32(tNO.text) + 1;
                tNO.text = Convert.ToString(ntNO);
            }
            else if (num > NO && num < NO2)
            {
                name = ch_elements[3];
                ntNO2 = Convert.ToInt32(tNO2.text) + 1;
                tNO2.text = Convert.ToString(ntNO2);
            }
            else if (num > NO2 && num < CH4)
            {
                name = ch_elements[4];
                ntCH4 = Convert.ToInt32(tCH4.text) + 1;
                tCH4.text = Convert.ToString(ntCH4);
            }
            else if (num > CH4 && num < SO2)
            {
                name = ch_elements[5];
                ntSO2 = Convert.ToInt32(tSO2.text) + 1;
                tSO2.text = Convert.ToString(ntSO2);
            }
            else if (num > SO2 && num < O2)
            {
                name = ch_elements[6];
                ntO2 = Convert.ToInt32(tO2.text) + 1;
                tO2.text = Convert.ToString(ntO2);
            }
            l = true;
        }
    }

    void Chemistry()
    {
        /*
    if (ifCO.text != "" && ifCO2.text != "" && ifNO.text != "" && ifNO2.text != "" && ifCH4.text != "" && ifSO2.text != "" && ifO2.text != "")
    {
        CO = 0;
        CO2 = 0;
        NO = 0;
        NO2 = 0;
        CH4 = 0;
        SO2 = 0;
        O2 = 0;

        CO = 100 / sum1 * (float)Convert.ToDouble(ifCO.text);
        CO2 = 100 / sum1 * (float)Convert.ToDouble(ifCO2.text);
        NO = 100 / sum1 * (float)Convert.ToDouble(ifNO.text);
        NO2 = 100 / sum1 * (float)Convert.ToDouble(ifNO2.text);
        CH4 = 100 / sum1 * (float)Convert.ToDouble(ifCH4.text);
        SO2 = 100 / sum1 * (float)Convert.ToDouble(ifSO2.text);
        O2 = 100 / sum1 * (float)Convert.ToDouble(ifO2.text);

        CO2 += CO;
        NO += CO2;
        NO2 += NO;
        CH4 += NO2;
        SO2 += CH4;
        O2 += SO2;

        int num = UnityEngine.Random.Range(0, 100);
        if (num > 0 && num < CO)
        {
            name = ch_elements[0];
            ntCO=Convert.ToInt32(tCO.text)+1;
            tCO.text = Convert.ToString(ntCO);
        }
        else if(num>CO && num<CO2)
        {
            name = ch_elements[1];
            ntCO2 = Convert.ToInt32(tCO2.text) + 1;
            tCO2.text = Convert.ToString(ntCO2);
        }
        else if (num > CO2 && num < NO)
        {
            name = ch_elements[2];
            ntNO = Convert.ToInt32(tNO.text) + 1;
            tNO.text = Convert.ToString(ntNO);
        }
        else if (num > NO && num < NO2)
        {
            name = ch_elements[3];
            ntNO2 = Convert.ToInt32(tNO2.text) + 1;
            tNO2.text = Convert.ToString(ntNO2);
        }
        else if (num > NO2 && num < CH4)
        {
            name = ch_elements[4];
            ntCH4 = Convert.ToInt32(tCH4.text) + 1;
            tCH4.text = Convert.ToString(ntCH4);
        }
        else if (num > CH4 && num < SO2)
        {
            name = ch_elements[5];
            ntSO2 = Convert.ToInt32(tSO2.text) + 1;
            tSO2.text = Convert.ToString(ntSO2);
        }
        else if (num > SO2 && num < O2)
        {
            name = ch_elements[6];
            ntO2 = Convert.ToInt32(tO2.text) + 1;
            tO2.text = Convert.ToString(ntO2);
        }

        /* Debug.Log("CO=" + CO);
         Debug.Log("CO2=" + CO2);
         Debug.Log("NO=" + NO);
         Debug.Log("NO2=" + NO2);
         Debug.Log("CH4=" + CH4);
         Debug.Log("SO2=" + SO2);
         Debug.Log("O2=" + O2);
        */
    }

}
