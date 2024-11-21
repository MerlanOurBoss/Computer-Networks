using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Settings : MonoBehaviour
{
    public Button bt_settings,bt_exit;
    public GameObject SettingsPanel;
    // Start is called before the first frame update
    void Start()
    {
        bt_settings.onClick.AddListener(SettingsClick);
        bt_exit.onClick.AddListener(ExitClick);
        SettingsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SettingsClick()
    {
        SettingsPanel.SetActive(true);
    }
    void ExitClick()
    {
        SettingsPanel.SetActive(false);
    }
}
