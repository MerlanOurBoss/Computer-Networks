using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Laminar : MonoBehaviour
{
    public GameObject element, cube1, cube2, cube3;
    public Text angle_text;
    public InputField diametr1,diametr2;

    Rigidbody rig;


    float angle_full, angle;
    float d1,d2;
    float x1, y1, z1;
    bool temp1 = false, temp2 = false;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();

        angle_full = (float)Convert.ToDouble(angle_text.text);
        d1 = (float)Convert.ToDouble(diametr1.text);
        d2 = (float)Convert.ToDouble(diametr2.text);
        //x1 = cube2.transform.position.x - cube2.transform.localScale.x / 2;
        x1 = element.transform.position.x + 1;
        y1 = element.transform.position.y;
        z1 = element.transform.position.z;
    }


    // Update is called once per frame
    void Update()
    {/*
        if(element.transform.position.x < cube1.transform.position.x+cube1.transform.localScale.x/2)
        {
            element.transform.right = new Vector3(x1, element.transform.position.y, element.transform.position.z) - element.transform.position;
        }



        if (element.transform.position.x > cube1.transform.position.x && element.transform.position.x < cube1.transform.position.x + cube1.transform.localScale.x / 2)
        {
            // angle = angle_full / d1 * (float)Math.Sqrt(Math.Pow(element.transform.position.y, 2) + Math.Pow(element.transform.position.z, 2));
            y1 = d2 / d1 * (element.transform.position.y-500f)+500f;
            z1 = d2 / d1 * element.transform.position.z;
        }
        if (element.transform.position.x > cube1.transform.position.x && element.transform.position.x < cube2.transform.position.x - cube2.transform.localScale.x / 2)
        {
            if (!temp)
            {
               // y1 = (x1 - element.transform.position.x) * (float)Math.Tan(angle / 180 * Math.PI);
                //temp = true;
            }
            element.transform.right = new Vector3(x1, y1, z1) - element.transform.position;
        }



        if (element.transform.position.x > cube2.transform.position.x && element.transform.position.x < cube2.transform.position.x + cube2.transform.localScale.x / 2)
        {
            // angle = angle_full / d1 * (float)Math.Sqrt(Math.Pow(element.transform.position.y, 2) + Math.Pow(element.transform.position.z, 2));
            x1 = cube3.transform.position.x - cube3.transform.localScale.x / 2;
            y1 = d1 / d2 * (element.transform.position.y - 500f) + 500f;
            z1 = d1 / d2 * element.transform.position.z;
        }
        if (element.transform.position.x > cube2.transform.position.x  && element.transform.position.x < cube3.transform.position.x - cube3.transform.localScale.x / 2)
        {
            if (!temp)
            {
                // y1 = (x1 - element.transform.position.x) * (float)Math.Tan(angle / 180 * Math.PI);
                //temp = true;
            }
            element.transform.right = new Vector3(x1, y1, z1) - element.transform.position;
        }*/
        

        if (element.transform.position.x > cube1.transform.position.x + cube1.transform.localScale.x / 2 && element.transform.position.x<cube2.transform.position.x-cube2.transform.localScale.x/2)
        {
            x1 = element.transform.position.x + 1;
            if (!temp1)
            {
                //Debug.Log("pos="+element.transform.position.x + ";" + element.transform.position.y + ";" + element.transform.position.z);
                
                y1 = d2 / d1 * (element.transform.position.y - 500f) + 500f;
                z1 = d2 / d1 * element.transform.position.z;
                //Debug.Log("to=" + x1 + ";" + y1 + ";" + z1);

                //Debug.DrawLine(element.transform.position, new Vector3(cube2.transform.position.x-cube2.transform.localScale.x/2, y1, z1), Color.red,10,false);
                temp1 = true;
            }
            //element.transform.right = new Vector3(x1, y1, z1) - element.transform.position;

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(x1, y1, z1), 1f);
        }
        else if(element.transform.position.x > cube2.transform.position.x + cube2.transform.localScale.x / 2 && element.transform.position.x < cube3.transform.position.x - cube3.transform.localScale.x / 2)
        {
            x1 = element.transform.position.x + 1;
            if (!temp2)
            {
                y1 = d1 / d2 * (element.transform.position.y - 500f) + 500f;
                z1 = d1 / d2 * element.transform.position.z;
                temp2 = true;
            }
            //element.transform.right = new Vector3(x1, y1, z1) - element.transform.position;

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(x1, y1, z1), 0.6f);
        }
        else
        {
            if (element.name.Contains("Clone"))
            {
                x1 = element.transform.position.x + 1;
                y1 = element.transform.position.y;
                z1 = element.transform.position.z;

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(x1, y1, z1), 0.6f);
            }
            //element.transform.right = new Vector3(x1, y1, z1) - element.transform.position;
        }
        
        //rig.velocity = transform.right * 100f; 
        

        /* if(element.transform.position.x>cube1.transform.position.x)
         {
             y1 = d2 / d1 * (element.transform.position.y - 500f) + 500f;
             z1 = d2 / d1 * element.transform.position.z;
             element.transform.right = new Vector3(x1, y1, z1) - element.transform.position;
         }
         else
         {
            // element.transform.right = new Vector3(x1, y1, z1) - element.transform.position;
         }*/
    }
}
