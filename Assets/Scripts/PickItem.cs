using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public GameObject parent;
    public GameObject tip;
    public GameObject shpereTip;
    private bool isPickable = false;
    private void OnTriggerEnter(Collider other)
    {
        tip.SetActive(true);
        isPickable = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (isPickable && Input.GetKey(KeyCode.E))
        {
            parent.SetActive(false);
            tip.SetActive(false);
            shpereTip.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        tip.SetActive(false);
        isPickable = false;
    }
}
