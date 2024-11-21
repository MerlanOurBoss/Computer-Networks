using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calayst_change : MonoBehaviour
{

    public GameObject cat1, cat2;
    public InputField diameter1, diameter2;
    //public InputField lenght1;
   // public GameObject lenght1;
    float d1,d2;
    float l;
    bool Paused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Paused)
        {
            if (diameter1.text != "" && diameter2.text != "")
            {
                d1 = (float)Convert.ToDouble(diameter1.text);
                d2 = (float)Convert.ToDouble(diameter2.text);

                if (d2 >= d1)
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        // Vector3 scale_cube2 = cube2.transform.localScale;


                        // l = (float)Convert.ToDouble(lenght1.text);
                        //l= cat1.transform.localScale.x;

                        cat1.transform.localScale = new Vector3(d2 / 50, 4, d2 / 50);
                        cat2.transform.localScale = new Vector3(d2 / 50, 4, d2 / 50);


                        //cube2.transform.localScale = new Vector3(l, scale_cube2.y, scale_cube2.z);
                    }
            }
        }
        
    }

    void Resume()
    {
        Paused = false;
    }

    void Pause()
    {
        Paused = true;
    }
}
