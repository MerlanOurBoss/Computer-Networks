using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Exit : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Button_Click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Button_Click()
    {
        Application.Quit();
    }
}
