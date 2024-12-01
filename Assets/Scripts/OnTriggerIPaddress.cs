using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnTriggerIPaddress : MonoBehaviour
{
    public GameObject ip;

    private IPAddressGame ipaddressGame;
    private void Start()
    {
        ipaddressGame = FindObjectOfType<IPAddressGame>();
        Debug.Log(ipaddressGame.name);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            ip.SetActive(true);
        }
        if (Input.GetKey(KeyCode.E))
        {
            ipaddressGame.CheckIPAddress(ip.GetComponentInChildren<TextMeshProUGUI>().text.ToString());
        }
        Debug.Log(ip.GetComponentInChildren<TextMeshProUGUI>().text.ToString());
    }

    private void OnTriggerExit(Collider other)
    {
        ip.SetActive(false);
    }
}
