using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Button_change : MonoBehaviour
{
    public Button button_create, button_delete;
    // Start is called before the first frame update
    void Start()
    {
        button_create.onClick.AddListener(Button_Create); //здесь задается функция после нажатия на Button котороая становиться активной, 
        button_delete.onClick.AddListener(Button_Delete);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Button_Create()
    {
        button_create.gameObject.SetActive(false);
        button_delete.gameObject.SetActive(true);
    }
    void Button_Delete()
    {
        button_delete.gameObject.SetActive(false);
        button_create.gameObject.SetActive(true);

        
    }
}
