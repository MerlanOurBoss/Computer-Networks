using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_select : MonoBehaviour
{
    public GameObject Background, Clients, Geometry, Aerodinamics, Chemistry,text1,text2;
    public Button clients_bt, geometry_bt, aero_bt, chemistry_bt;
    // Start is called before the first frame update

    //здесь идет выборка панели
    //между клиентами, геометрии, аэродинамика, Химия
    void Start()
    {
        text1.SetActive(true);
        text2.SetActive(false);
        Background.SetActive(true);
        Clients.SetActive(false);
        Geometry.SetActive(false);
        Aerodinamics.SetActive(false);
        Chemistry.SetActive(false);
        clients_bt.onClick.AddListener(clients_Click);
        geometry_bt.onClick.AddListener(geometry_Click);
        aero_bt.onClick.AddListener(aero_Click);
        chemistry_bt.onClick.AddListener(chemistry_Click);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void geometry_Click()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        Background.SetActive(false);
        Clients.SetActive(false);
        Geometry.SetActive(true);
        Aerodinamics.SetActive(false);
        Chemistry.SetActive(false);

    }
    void aero_Click()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        Background.SetActive(false);
        Clients.SetActive(false);
        Geometry.SetActive(false);
        Aerodinamics.SetActive(true);
        Chemistry.SetActive(false);
    }
    void chemistry_Click()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        Background.SetActive(false);
        Clients.SetActive(false);
        Geometry.SetActive(false);
        Aerodinamics.SetActive(false);
        Chemistry.SetActive(true);
    }
    void clients_Click()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        Background.SetActive(false);
        Clients.SetActive(true);
        Geometry.SetActive(false);
        Aerodinamics.SetActive(false);
        Chemistry.SetActive(false);
    }
}
