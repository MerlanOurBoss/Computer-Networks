using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Target_to_target : MonoBehaviour
{

    public GameObject cube1, cube2, cube3, cube4, cube5;
    public InputField diameter2;
    float d2;

    public float x_start, x_end;
    float y_start, y_end, y=500f;
    float z_start, z_end;

    public float x_lenght, y_lenght, z_lenght;

    public float n = 100;
    public float m = 1;
    public float k = 1;

    

    public GameObject cilynder;
    public Slider speed;
    float speed1;
    public float x1, y1, z1;
    public float x2, y2, z2;
    // Start is called before the first frame update
    void Start()
    {
        speed1 = (float)Convert.ToDouble(speed.value * 100);

        d2= (float)Convert.ToDouble(diameter2.text);


        
    } 

    // Update is called once per frame
    void Update()
    {
        x_start = cube1.transform.position.x - cube1.transform.localScale.x / 2;
        x_end = cube5.transform.position.x + cube5.transform.localScale.x / 2;
        y_start = y - d2;
        y_end = y + d2;
        z_start =-d2;
        z_end = d2;

        x_lenght = (x_end - x_start) / n;
        y_lenght = (y_end - y_start) / m;
        z_lenght = (z_end - z_start) / k;

        float[,] array = new float[(int)n, 3];

        for (float i = 0; i < n; i++)
        {
            array[(int)i, 0] = x_start + x_lenght * (0.5f + i);
            array[(int)i, 1] = y_start + y_lenght * 0.5f;
            array[(int)i, 2] = z_start + z_lenght * 0.5f;
        }

        //array[0, 0] = x_start + x_lenght * 0.5f;
        //array[0, 1] = y_start + y_lenght * 0.5f;
       // array[0, 2] = z_start + z_lenght * 0.5f;
       // array[1, 0] = x_start + x_lenght * 1.5f;
        //array[1, 1] = y_start + y_lenght * 0.5f;
       // array[1, 2] = z_start + z_lenght * 0.5f;
        //array[2, 0] = x_start + x_lenght * 2.5f;
        //array[2, 1] = y_start + y_lenght * 0.5f;
       //array[2, 2] = z_start + z_lenght * 0.5f;

        x1 = array[1, 0];
        y1 = array[1, 1];
        z1 = array[1, 2];

        x2 = array[2, 0];
        y2 = array[2, 1];
        z2 = array[2, 2];


        /*if (transform.position.x < x_start+x_lenght)
        {
            transform.right = new Vector3(array[1,0], array[1, 1], array[1, 2]) - transform.position;
        }
        else if (transform.position.x < x_end-x_lenght)
        {
            transform.right = new Vector3(array[2, 0], array[2, 1], array[2, 2]) - transform.position;
        }
        else
        {
            transform.right = cilynder.transform.position - transform.position;
        }
        */

        if (transform.position.x < x_end-x_lenght)
        { 
            for (int i = 1; i < n; i++)
            {
                if (transform.position.x < x_start + x_lenght * (float)i)
                {
                    transform.right = new Vector3(array[i, 0], array[i, 1], array[i, 2]) - transform.position;
                }
            }
        }
        else
        {
            transform.right = cilynder.transform.position - transform.position;
        }
    }
}
