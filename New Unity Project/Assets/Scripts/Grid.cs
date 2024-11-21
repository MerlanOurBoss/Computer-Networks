using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Grid : MonoBehaviour
{
    public GameObject cube1,cube2;
    public Slider slider_grid;

        // Start is called before the first frame update
    void Start()
    {

        float x0=-1000, x1=1000;
        float y0=0, y1=1000;
        float z0=-500, z1=500;

        float Ni = (x1 - x0) / 100;
        float Nj = (y1 - y0) / 100;
        float Nk = (z1 - z0) / 100;


        for (int i = 0; i <= Ni; i++)
        {
            for (int j = 0; j <= Nj; j++)
            {
                cube1.transform.localScale = new Vector3(x1-x0, 5, 5);
                Instantiate(cube1, new Vector3(0,y0+j*100,z0+i*100), Quaternion.identity);


                cube1.transform.localScale = new Vector3(5, 5, z1-z0);
                Instantiate(cube1, new Vector3(x0+i*100, y0+j * 100, 0), Quaternion.identity);

                cube1.transform.localScale = new Vector3(5, y1-y0, 5);
                Instantiate(cube1, new Vector3(x0+i * 100, (y1-y0)/2, z0 + j * 100), Quaternion.identity);
            }
        }

        Ni = (x1 - x0) / 50;
        Nj = (y1 - y0) / 50;
        Nk = (z1 - z0) / 50;

        for (int i = 0; i <= Ni; i++)
        {
            for (int j = 0; j <= Nj; j++)
            {
                cube2.transform.localScale = new Vector3(x1 - x0, 5, 5);
                Instantiate(cube2, new Vector3(0, y0 + j * 50, z0 + i * 50), Quaternion.identity);


                cube2.transform.localScale = new Vector3(5, 5, z1 - z0);
                Instantiate(cube2, new Vector3(x0 + i * 50, y0 + j * 50, 0), Quaternion.identity);

                cube2.transform.localScale = new Vector3(5, y1 - y0, 5);
                Instantiate(cube2, new Vector3(x0 + i * 50, (y1 - y0) / 2, z0 + j * 50), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    { 
    }

}
