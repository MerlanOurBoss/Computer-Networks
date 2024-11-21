using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Change_Scale_Near_cat : MonoBehaviour
{
    public GameObject element1, catalyst, cube1,cube2,cube5;
    //public InputField input_diameter;
    public float scale;
    SphereCollider myCollider;

    public InputField diametr1, diametr2;
    float d1, d2;
    float x_begin;
    float x_end;
    float elm_s;
    float count;
    float step;
    float coll_rad;

     float alfa1; //нач
     float alfa2;//учел
     float alfa3;//уменьше

    // Start is called before the first frame update
    void Start()
    {

       // x_begin = cube.transform.position.x + cube.transform.localScale.x / 2;
        //x_end = catalyst.transform.position.x - catalyst.transform.localScale.x / 2;
        elm_s = element1.transform.localScale.x;
        count = element1.transform.localScale.x - 1;
        step = (x_end - x_begin) / count;

        d1 = (float)Convert.ToDouble(diametr1.text);
        d2 = (float)Convert.ToDouble(diametr2.text);

        alfa1 = d1/2;
        alfa2 = d2 / d1 * 200;
        alfa3 = d1 / 100;


        myCollider = element1.GetComponent<SphereCollider>();
        myCollider.radius = 0.5f;
        coll_rad = 0.5f;


        if (element1.name.Contains("Element2") && element1.name.Contains("Clone"))
        {
            myCollider = element1.GetComponent<SphereCollider>();
            myCollider.radius = 0.3f;
            coll_rad = 0.3f;
        }
        // y_begin = cube.transform.position.x - cube.transform.localScale.x / 2;
    }

    
    
    // Update is called once per frame
    void Update()
    {
        // if(element1.transform.position.x > cube2.transform.position.x - cube2.transform.localScale.x / 2)
        if (element1.transform.position.x > cube1.transform.position.x && element1.transform.position.x < cube1.transform.position.x+cube1.transform.localScale.x/2)
        {
            float count1 = elm_s - elm_s * alfa1/100f;
            float step1= (cube1.transform.position.x + cube1.transform.localScale.x / 2- cube1.transform.position.x) / count1;
            scale = elm_s - (element1.transform.position.x - cube1.transform.position.x) / step1;
            myCollider.radius = scale*coll_rad/elm_s;
            //element1.transform.localScale = new Vector3(scale, scale, scale); //изменение размера обьекта
        }

        if (element1.transform.position.x > cube1.transform.position.x + cube1.transform.localScale.x / 2 && element1.transform.position.x < cube2.transform.position.x-cube2.transform.localScale.x/2)
        {
            float count2 = elm_s*alfa1/100f*alfa2/100-elm_s*alfa1/100f;
            float step2 = -(cube1.transform.position.x-cube1.transform.localScale.x / 2) / count2;
            scale = elm_s*alfa1/100f + (element1.transform.position.x - (cube1.transform.position.x + cube1.transform.localScale.x / 2)) / step2;
            myCollider.radius = scale * coll_rad / elm_s;
        }
        //уменьшение
        if (element1.transform.position.x > cube2.transform.position.x - cube2.transform.localScale.x / 2 && element1.transform.position.x < catalyst.transform.position.x - catalyst.transform.localScale.x / 2)
        {
            float count3 = elm_s * alfa1 / 100f * alfa2 / 100f - elm_s * alfa1 / 100f * alfa2 / 100f * alfa3 / 100f;
            float step3 = ((cube2.transform.position.x - cube2.transform.localScale.x / 2) - ((cube2.transform.position.x - cube2.transform.localScale.x / 2) + (cube1.transform.position.x + cube1.transform.localScale.x / 2)) / 2) / count3;
            scale = elm_s * alfa1 / 100f * alfa2 / 100f - (element1.transform.position.x - ((cube2.transform.position.x - cube2.transform.localScale.x / 2) + (cube1.transform.position.x + cube1.transform.localScale.x / 2)) / 2) / step3;
            myCollider.radius = scale * coll_rad / elm_s;
            //element1.transform.localScale = new Vector3(scale, scale, scale); //изменение размера обьекта

        }

        if (element1.transform.position.x > cube2.transform.position.x + cube2.transform.localScale.x / 2 && element1.transform.position.x < cube5.transform.position.x - cube5.transform.localScale.x/2)
        {
            float count4 = elm_s*alfa1/100f*alfa2/100f-elm_s*alfa3/100f;
            float step4 = ((cube5.transform.position.x - cube5.transform.localScale.x / 2) -(cube2.transform.position.x + cube2.transform.localScale.x / 2)) / count4;
            scale = elm_s * alfa3/100f + (element1.transform.position.x - (cube2.transform.position.x + cube2.transform.localScale.x / 2)) / step4;
            myCollider.radius = scale * coll_rad / elm_s;
        }
        /*
        if (element1.transform.position.x > -x_end && element1.transform.position.x < -x_begin)
        {
            scale = (elm_s + (element1.transform.position.x + x_begin) / step)*0.8f;
            myCollider.radius = scale / 320f;
            //element1.transform.localScale = new Vector3(scale, scale, scale); //изменение размера обьекта
        }

        if (element1.transform.position.x > y_begin && element1.transform.position.x < x_begin) 
        {
            //scale = (elm_s + (element1.transform.position.x + y_begin) / step);
            //myCollider.radius = scale / 320f;
            //element1.transform.localScale = new Vector3(scale, scale, scale); //изменение размера обьекта
        }*/
    }
}
