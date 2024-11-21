using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider_ch_aero : MonoBehaviour
{
    public Slider slider_aero_ch;
    public Button button_aero, button_ch;

    // Start is called before the first frame update
    void Start()
    {
        button_aero.onClick.AddListener(aero);
        button_ch.onClick.AddListener(ch);
        slider_aero_ch.value = 0;
    }

    // Update is called once per frame
    void Update() 
    {
        /*if (slider_aero.value == 0)
        {
            slider_ch.value = 1;
        }
        else if (slider_aero.value == 1)
        {
            slider_ch.value = 0;
        }

        if (slider_ch.value == 0)
        {
            slider_aero.value = 1;
        }
        else if (slider_ch.value == 1)
        {
            slider_aero.value = 0;
        }*/
    }
    void aero()
    {
        slider_aero_ch.value = 0;
    }
    void ch()
    {
        slider_aero_ch.value = 1;
    }
}
