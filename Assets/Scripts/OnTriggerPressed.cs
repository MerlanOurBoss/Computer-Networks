using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPressed : MonoBehaviour
{
    public GameObject rj45;
    public GameObject rj45_router;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            if (Input.GetKey(KeyCode.E))
            {
                rj45.SetActive(true);
                rj45_router.SetActive(true);
                gameObject.SetActive(false);
            }
        } 
    }
}