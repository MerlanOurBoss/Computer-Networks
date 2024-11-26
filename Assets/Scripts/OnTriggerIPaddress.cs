using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerIPaddress : MonoBehaviour
{
    public GameObject ip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            ip.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ip.SetActive(false);
    }
}
