using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Parallel : MonoBehaviour
{
    public Slider parallel;
    public Slider vidimost;
    public Button button_On, button_Off;

    public Renderer rend11, rend12,rend21,rend22;

    // Start is called before the first frame update
    void Start()
    {
        button_On.onClick.AddListener(On);
        button_Off.onClick.AddListener(Off);

        rend11.enabled = true;
        rend12.enabled = true;
        rend21.enabled = false;
        rend22.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (vidimost.value == 0)
        {
            if (parallel.value == 0)
            {
                rend11.enabled = true;
                rend12.enabled = true;
                rend21.enabled = false;
                rend22.enabled = false;

            }
            else if (parallel.value == 1)
            {
                rend11.enabled = false;
                rend12.enabled = false;
                rend21.enabled = true;
                rend22.enabled = true;

            }
        }
        else if(vidimost.value==1)
        {
            rend11.enabled = false;
            rend12.enabled = false;
            rend21.enabled = false;
            rend22.enabled = false;
        }
    }

    void On()
    {
        vidimost.value = 0;
    }
    void Off()
    {
        vidimost.value = 1;
    }

}
