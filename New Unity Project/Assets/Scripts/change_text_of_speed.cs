using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class change_text_of_speed : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Text text;

    //изменение определение скорости

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Convert.ToString(slider.value);
    }
}
