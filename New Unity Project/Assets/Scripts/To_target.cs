using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class To_target : MonoBehaviour
{
    public GameObject cilynder;
    public Slider speed;
    float speed1;
    public GameObject cube1,cube2;
    public bool l;
    // Start is called before the first frame update
    void Start()
    {
        l = false;
        speed1 = (float)Convert.ToDouble(speed.value);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cilynder.transform.position, 0.1f);
        if (transform.position.x > cube2.transform.position.x && transform.position.x < cube1.transform.position.x)
        {
            transform.right = cilynder.transform.position - transform.position;
            l = true;
        }
        else
        {
            l = false;
        }
    }
}
