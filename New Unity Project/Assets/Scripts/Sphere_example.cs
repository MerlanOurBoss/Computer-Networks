using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Sphere_example : MonoBehaviour
{
    public GameObject sphere;
    // public InputField inner_diameter;

    // Start is called before the first frame update
    void Start()
    {
        float n = 12f;   //количество
         // внутренний радиус      
        float alfa = 180 - (n - 2) / n * 180;


        Vector3 position_s = sphere.transform.position;

        float r = 20f;

        //sphere.transform.localScale = new Vector3(a, a, a);
        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = r * (float)Math.Cos(t);
            float y = r * (float)Math.Sin(t) + 500f;
            Instantiate(sphere, new Vector3(position_s.x+50, y, x), Quaternion.identity);
        }

        r = 40f;

        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = r * (float)Math.Cos(t);
            float y = r * (float)Math.Sin(t) + 500f;
            Instantiate(sphere, new Vector3(position_s.x+100f, y, x), Quaternion.identity);
        }

        r = 60f;

        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = r * (float)Math.Cos(t);
            float y = r * (float)Math.Sin(t) + 500f;
            Instantiate(sphere, new Vector3(position_s.x+150f, y, x), Quaternion.identity);
        }

        r = 80f;

        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = r * (float)Math.Cos(t);
            float y = r * (float)Math.Sin(t) + 500f;
            Instantiate(sphere, new Vector3(position_s.x + 200f, y, x), Quaternion.identity);
        }


        //Instantiate(sphere, new Vector3(sphere.transform.position.x, sphere.transform.position.y+10f, sphere.transform.position.z+10f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
