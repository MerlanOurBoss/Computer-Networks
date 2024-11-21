using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Scale_Change : MonoBehaviour
{

    public GameObject element1;
    public InputField input_diameter;
    public float scale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string str = input_diameter.text;
            str = str.Replace(".", ",");

            scale = (float)Convert.ToDouble(str);
            element1.transform.localScale = new Vector3(scale,scale,scale); //изменение размера обьекта
        }
    }
}
