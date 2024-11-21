using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class control_cilynder : MonoBehaviour
{

    public GameObject cube1, cilyder1;
    // Start is called before the first frame update
    void Start()
    {
        cilyder1.transform.position = new Vector3(cube1.transform.position.x - cube1.transform.localScale.x / 2 - cilyder1.transform.localScale.y, cilyder1.transform.position.y, cilyder1.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
