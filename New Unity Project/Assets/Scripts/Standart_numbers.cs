using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Standart_numbers : MonoBehaviour
{
    public InputField input_pipeD;
    public InputField input_speed;
    public InputField input_fixed;
    public InputField input_time;
    public InputField input_number;
    public InputField element_d;
    public InputField diameter1;
    public InputField diameter2;

    public InputField input_1_1;
    public InputField input_2_1;
    public InputField input_3_1;
    public InputField input_4_1;
    public InputField input_5_1;
    public InputField input_6_1;
    public InputField input_7_1;
    public InputField input_8_1;
    public InputField input_9_1;
    public InputField input_10_1;


    public InputField input_1_2;
    public InputField input_2_2;
    public InputField input_3_2;
    public InputField input_4_2;
    public InputField input_5_2;
    public InputField input_6_2;
    public InputField input_7_2;
    public InputField input_8_2;
    public InputField input_9_2;
    public InputField input_10_2;

    public InputField ifCO, ifCO2, ifNO, ifNO2, ifCH4, ifSO2, ifO2;

    //public InputField length1;
    //public InputField length2;

    //стандартные определения текстовых полей

    // Start is called before the first frame update
    void Start()
    {
        input_pipeD.text = "150";
        input_speed.text = "500";
        input_fixed.text = "1000";
        input_time.text = "0.00001";
        input_number.text = "4";
        element_d.text = "25";
        diameter1.text = "70";
        diameter2.text = "140";




        input_1_1.text = "1";
        input_2_1.text = "1";
        input_3_1.text = "14";
        input_4_1.text = "60";
        input_5_1.text = "1";
        input_6_1.text = "1";
        input_7_1.text = "1";
        input_8_1.text = "1";
        input_9_1.text = "1";
        input_10_1.text = "12";




        input_1_2.text = "14500";
        input_2_2.text = "13000";
        input_3_2.text = "9000";
        input_4_2.text = "7365.43";
        input_5_2.text = "1000";
        input_6_2.text = "1121.1";
        input_7_2.text = "100000";
        input_8_2.text = "3500";
        input_9_2.text = "1";
        input_10_2.text = "0";

        ifCO.text = "23";
        ifCO2.text = "1";
        ifNO.text = "24";
        ifNO2.text = "0";
        ifCH4.text = "0";
        ifSO2.text = "0";
        ifO2.text = "10";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
