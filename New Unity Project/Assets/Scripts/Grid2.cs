using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Grid2 : MonoBehaviour
{
    public Slider slider_grid;
    
    
    public Renderer rend1, rend2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (slider_grid.value == 1)
        {
            rend1.enabled = false;
            rend2.enabled = false;
        }
        else if (slider_grid.value == 2)
        {
            rend1.enabled = true;
            rend2.enabled = false;
        }
        else if (slider_grid.value == 3)
        {
            rend1.enabled = false;
            rend2.enabled = true;
        }
    }
}
