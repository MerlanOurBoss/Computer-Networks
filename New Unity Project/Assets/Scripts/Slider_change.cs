using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_change : MonoBehaviour
{
    public Button button_Free, button_Fixed;
    public Slider slider;
    public GameObject input_fixed;

    //изменение определение скорости

    // Start is called before the first frame update
    void Start()
    {
        //input_fixed.SetActive(false);
        button_Free.onClick.AddListener(Free);
        button_Fixed.onClick.AddListener(Fixed);
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 1)
        {
            input_fixed.SetActive(true);
        }
        if (slider.value == 0)
        {
            input_fixed.SetActive(false);
        }
    }

    void Free()
    {
        slider.value = 0;
    }
    void Fixed()
    {
        slider.value = 1;
    }
}
