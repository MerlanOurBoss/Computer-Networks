using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class DB_changePanel : MonoBehaviour
{
    public Button bt_DB,bt1,bt2,bt3;
    public GameObject panelCH,panel1, panel2;
    // Start is called before the first frame update
    void Start()
    {

        bt_DB.onClick.AddListener(ChangePanel);
        bt1.onClick.AddListener(ChangePanel2);
        bt2.onClick.AddListener(ChangePanel2);
        bt3.onClick.AddListener(ChangePanel2);
        panel1.SetActive(true);
        panel2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangePanel()
    {
        //panelCH.SetActive(true);
        panel1.SetActive(false);
        panel2.SetActive(false);
    }
    void ChangePanel2()
    {
        panel1.SetActive(true);
        panel2.SetActive(true);
    }
}
