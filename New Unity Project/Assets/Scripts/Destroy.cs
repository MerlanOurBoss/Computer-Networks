using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject element1, catalyst, cube1;
    public Button button_reset;
    public Rigidbody rb;
    public InputField diameter1;

    public bool Paused = false;

    void Start()
    {
        button_reset.onClick.AddListener(Reset);
        rb = element1.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Paused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }

        if (!Paused)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                Reset();
            }
/*
            if (diameter1.text != "")
                if (Math.Sqrt(Math.Pow(element1.transform.position.y - 500f, 2) + Math.Pow(element1.transform.position.z, 2)) > (float)Convert.ToDouble(diameter1.text))
                    Destroy_element();
            if (element1.transform.position.x < cube1.transform.position.x - cube1.transform.localScale.x / 2 - element1.transform.localScale.x)
                Destroy_element();
*/

            if(diameter1.text!="")
            {
                if (Math.Sqrt(Math.Pow(element1.transform.position.y - 500f, 2) + Math.Pow(element1.transform.position.z, 2)) > (float)Convert.ToDouble(diameter1.text) && element1.transform.position.x<cube1.transform.position.x)
                    Destroy_element();
            }


            if (element1.transform.position.x > catalyst.transform.position.x - catalyst.transform.localScale.x / 2 && element1.transform.position.x < catalyst.transform.position.x + catalyst.transform.localScale.x / 2)
            {
                if (rb.velocity.magnitude < 10f)
                {
                    // Destroy(element1);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy_element();
    }

    void Resume()
    {
        Paused = false;
    }

    void Pause()
    {
        Paused = true;
    }

    public void Reset()
    {
        Destroy_element();
    }

    public void Destroy_element()
    {
        string dist = element1.name.Replace("(Clone)","");
        if (element1.name.Contains("Clone"))
        {
            Destroy(element1);
        }      
    }
}
