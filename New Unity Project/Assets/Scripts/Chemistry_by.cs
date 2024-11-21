using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = System.Random;

public class Chemistry_by : MonoBehaviour
{
    public GameObject element1;
    public Material mat, mat_glass;
    public Rigidbody rb;
    public Slider slider;
    Renderer rend;
    float length = 150f;

    public Slider slider_ch;
    
    float start_pos = -180f;

    Random rand;
    int ID;
    int degree;
    bool d_l = false;

    public GameObject cube;

    void Start()
    {
        mat = element1.GetComponent<Renderer>().material;
        rb = element1.GetComponent<Rigidbody>();
        rend = element1.GetComponent<Renderer>();

        degree = Convert.ToInt32(slider.value)*20;

        rand = new Random();
        ID = rand.Next(0, 100);
        if(ID>=0 && ID <= degree)
        {
            d_l = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        start_pos = cube.transform.position.x - cube.transform.localScale.x / 2;
        length = cube.transform.localScale.x;
        if (slider_ch.value == 1)
        {
            if (d_l)
            {
                float coef = length / 16f;
                float x = element1.transform.position.x;

                if (element1.name == "Element1")
                {
                    element1.GetComponent<Renderer>().material = mat_glass;
                }

                if (element1.name != "Element1")
                {
                    if (x < start_pos)//1
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.9255f, 0.1059f, 0.1412f);
                    }
                    else if (x > start_pos && x < start_pos + coef)//1
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.9255f, 0.1059f, 0.1412f);
                    }
                    else if (x > start_pos + coef && x < start_pos + coef * 2f)//2
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.9255f, 0.1059f, 0.1412f);
                    }
                    else if (x > start_pos + coef * 2f && x < start_pos + coef * 3f)//3
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.9412f, 0.2745f, 0.1333f);
                    }
                    else if (x > start_pos + coef * 3f && x < start_pos + coef * 4f)//4
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.9569f, 0.3922f, 0.1451f);
                    }
                    else if (x > start_pos + coef * 4f && x < start_pos + coef * 5f)//5
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.9804f, 0.5765f, 0.1098f);
                    }
                    else if (x > start_pos + coef * 5f && x < start_pos + coef * 6f)//6
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.9882f, 0.6666f, 0.0941f);
                    }
                    else if (x > start_pos + coef * 6f && x < start_pos + coef * 7f)//7
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(1f, 0.7647f, 0.0549f);
                    }
                    else if (x > start_pos + coef * 7f && x < start_pos + coef * 8f)//8
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(1f, 0.7647f, 0.0549f);
                    }
                    else if (x > start_pos + coef * 8f && x < start_pos + coef * 9f)//9
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(1f, 0.9412f, 0.0078f);
                    }
                    else if (x > start_pos + coef * 9f && x < start_pos + coef * 10f)//10
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.9529f, 0.9098f, 0.0118f);
                    }
                    else if (x > start_pos + coef * 10f && x < start_pos + coef * 11f)//11
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.8627f, 0.8863f, 0.1255f);
                    }
                    else if (x > start_pos + coef * 11f && x < start_pos + coef * 12f)//12
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.7804f, 0.8549f, 0.1608f);
                    }
                    else if (x > start_pos + coef * 12f && x < start_pos + coef * 13f)//13
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.7059f, 0.8314f, 0.2078f);
                    }
                    else if (x > start_pos + coef * 13f && x < start_pos + coef * 14f)//14
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.6196f, 0.7961f, 0.2392f);
                    }
                    else if (x > start_pos + coef * 14f && x < start_pos + coef * 15f)//15
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.5216f, 0.7647f, 0.2745f);
                    }
                    else if (x > start_pos + coef * 15f && x < start_pos + coef * 16f)//16
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.4353f, 0.7451f, 0.2549f);
                    }
                    else if (x > start_pos + coef * 16f && x < start_pos + coef * 17f)//17
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.3137f, 0.7176f, 0.2980f);
                    }
                    else if (x > start_pos + coef * 17f)//17
                    {
                        //mat.color = new Color(255,0,0,255); 
                        mat.color = new Color(0.3137f, 0.7176f, 0.2980f);
                    }
                }
            }
            else
                mat.color = new Color(0.9255f, 0.1059f, 0.1412f);
                //mat.color = new Color(1f, 1f, 1f);
        }

    }
}
