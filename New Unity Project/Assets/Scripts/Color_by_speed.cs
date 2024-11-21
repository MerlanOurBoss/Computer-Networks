using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color_by_speed : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject element1;
    public Material mat, mat_glass;
    public Rigidbody rb;
    public InputField input_speed;
    public InputField input_fixed;
    public Slider slider1;
    Renderer rend;
    float Force;

    public Slider speed;
    public Slider speed_fixed;

    public Slider slider_aero;

    void Start()
    {
        mat = element1.GetComponent<Renderer>().material;
        rb = element1.GetComponent<Rigidbody>();
        rend = element1.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (slider_aero.value == 0)
        {
            /*if (slider.value == 1)
            {
                Force = (float)Convert.ToDouble(input_fixed.text);
            }
            else
            {
                //Force = (float)Convert.ToDouble(input_speed.text);
                Force = (float)Convert.ToDouble(speed.value);
            }*/
            //Force = (float)Convert.ToDouble(input_fixed.text);
            Force = speed_fixed.value;
            if (element1.name == "Element1")
            {
                element1.GetComponent<Renderer>().material = mat_glass;
            }

            if (slider1.value == 0)
            {
                rend.enabled = true;
            }
            if (slider1.value == 1)
            {
                if (element1.transform.position.z >= -30 && element1.transform.position.z <= 30)//показывать только середину когда слайндер поменяется
                {
                    rend.enabled = true;
                }
                else
                    rend.enabled = false;
            }


            if (element1.name != "Element1")
            {
                if (rb.velocity.magnitude > Force * 1)//1
                {
                    //mat.color = new Color(255,0,0,255); 
                    mat.color = new Color(1f, 1f, 1f);
                }
                else if (rb.velocity.magnitude > Force * 0.933 && rb.velocity.magnitude <= Force * 1)//1
                {
                    //mat.color = new Color(255,0,0,255); 
                    mat.color = new Color(1f, 0.9899f, 0.9555f);
                }
                else if (rb.velocity.magnitude <= Force * 0.933 && rb.velocity.magnitude >= Force * 0.867)//2
                {
                    // mat.color = new Color(255, 79, 2, 255);
                    mat.color = new Color(1f, 0.9490f, 0.8000f);
                }
                else if (rb.velocity.magnitude <= Force * 0.867 && rb.velocity.magnitude >= Force * 0.8)//3
                {
                    //mat.color = new Color(255, 120, 1, 255);
                    mat.color = new Color(1f, 0.9020f, 0.6000f);
                }
                else if (rb.velocity.magnitude <= Force * 0.8 && rb.velocity.magnitude >= Force * 0.733)//4
                {
                    //  mat.color = new Color(255,158,1,255);
                    mat.color = new Color(1f, 0.8510f, 0.4000f);
                }
                else if (rb.velocity.magnitude <= Force * 0.733 && rb.velocity.magnitude >= Force * 0.667)//5
                {
                    //mat.color = new Color(252,193,1,255);
                    mat.color = new Color(1f, 0f, 0f);
                }
                else if (rb.velocity.magnitude <= Force * 0.667 && rb.velocity.magnitude >= Force * 0.6)//6
                {
                    // mat.color = new Color(249,226,0,255);
                    mat.color = new Color(0.7529f, 0f, 0f);
                }
                else if (rb.velocity.magnitude <= Force * 0.6 && rb.velocity.magnitude >= Force * 0.533)//7
                {
                    //  mat.color = new Color(190,221,15,255);
                    mat.color = new Color(0.6275f, 0.1725f, 0.3137f);
                }
                else if (rb.velocity.magnitude <= Force * 0.533 && rb.velocity.magnitude >= Force * 0.467)//8
                {
                    mat.color = new Color(0.4980f, 0.1451f, 0.4824f);
                }
                else if (rb.velocity.magnitude <= Force * 0.467 && rb.velocity.magnitude >= Force * 0.4)//9
                {
                    mat.color = new Color(0.4392f, 0.1882f, 0.6275f);
                }
                else if (rb.velocity.magnitude <= Force * 0.4 && rb.velocity.magnitude >= Force * 0.333)//10
                {
                    mat.color = new Color(0.3569f, 0.0627f, 0.7529f);
                }
                else if (rb.velocity.magnitude <= Force * 0.333 && rb.velocity.magnitude >= Force * 0.267)//11
                {
                    mat.color = new Color(0.4549f, 0.4353f, 0.8431f);
                }
                else if (rb.velocity.magnitude <= Force * 0.267 && rb.velocity.magnitude >= Force * 0.2)//12
                {
                    mat.color = new Color(0.3490f, 0.3961f, 0.8431f);
                }
                else if (rb.velocity.magnitude <= Force * 0.2 && rb.velocity.magnitude >= Force * 0.133)//13
                {
                    mat.color = new Color(0f, 0.4392f, 0.7529f);
                }
                else if (rb.velocity.magnitude <= Force * 0.133 && rb.velocity.magnitude >= Force * 0.067)//14
                {
                    mat.color = new Color(0.1843f, 0.3333f, 0.5922f);
                }
                else if (rb.velocity.magnitude <= Force * 0.067 && rb.velocity.magnitude > Force * 0)//15
                {
                    mat.color = new Color(0f, 0.1255f, 0.3764f);
                }
                else if (rb.velocity.magnitude == Force * 0)
                {
                    mat.color = new Color(0f, 0f, 0f);
                }

               /* if (rb.velocity.magnitude == Force * 0 && element1.transform.position.x > -710)
                {
                    rb.AddForce(Force / 10, 0, 0, ForceMode.Impulse);
                }
                if (rb.velocity.magnitude <= Force * 0.067 && rb.velocity.magnitude > Force * 0 && element1.transform.position.x > -710)//15
                {
                    rb.AddForce(Force / 10, 0, 0, ForceMode.Impulse);
                }*/
            }
        }
    }
}
/* if (rb.velocity.magnitude > Force * 0.9375 && rb.velocity.magnitude <= Force * 1)//1
            {
                //mat.color = new Color(255,0,0,255); 
                mat.color = new Color(1f, 0, 0);
            }
            else if (rb.velocity.magnitude <= Force * 0.9375 && rb.velocity.magnitude >= Force * 0.875)//2
            {
                // mat.color = new Color(255, 79, 2, 255);
                mat.color = new Color(1f, 0.3098f, 0.0078f);
            }
            else if (rb.velocity.magnitude <= Force * 0.875 && rb.velocity.magnitude >= Force * 0.8125)//3
            {
                //mat.color = new Color(255, 120, 1, 255);
                mat.color = new Color(1f, 0.4706f, 0.0078f);
            }
            else if (rb.velocity.magnitude <= Force * 0.8125 && rb.velocity.magnitude >= Force * 0.75)//4
            {
                //  mat.color = new Color(255,158,1,255);
                mat.color = new Color(1f, 0.6196f, 0.0078f);
            }
            else if (rb.velocity.magnitude <= Force * 0.75 && rb.velocity.magnitude >= Force * 0.6875)//5
            {
                //mat.color = new Color(252,193,1,255);
                mat.color = new Color(0.9882f, 0.7569f, 0.0078f);
            }
            else if (rb.velocity.magnitude <= Force * 0.6875 && rb.velocity.magnitude >= Force * 0.625)//6
            {
                // mat.color = new Color(249,226,0,255);
                mat.color = new Color(0.9765f, 0.8863f, 0f);
            }
            else if (rb.velocity.magnitude <= Force * 0.625 && rb.velocity.magnitude >= Force * 0.5625)//7
            {
                //  mat.color = new Color(190,221,15,255);
                mat.color = new Color(0.7451f, 0.8667f, 0.0588f);
            }
            else if (rb.velocity.magnitude <= Force * 0.5625 && rb.velocity.magnitude >= Force * 0.5)//8
            {
                mat.color = new Color(0.3216f, 0.7412f, 0.1373f);
            }
            else if (rb.velocity.magnitude <= Force * 0.5 && rb.velocity.magnitude >= Force * 0.4375)//9
            {
                mat.color = new Color(0f, 0.6588f, 0.2196f);
            }
            else if (rb.velocity.magnitude <= Force * 0.4375 && rb.velocity.magnitude >= Force * 0.375)//10
            {
                mat.color = new Color(0f, 0.6706f, 0.4863f);
            }
            else if (rb.velocity.magnitude <= Force * 0.375 && rb.velocity.magnitude >= Force * 0.3125)//11
            {
                mat.color = new Color(0.0078f, 0.6471f, 0.9333f);
            }
            else if (rb.velocity.magnitude <= Force * 0.3125 && rb.velocity.magnitude >= Force * 0.25)//12
            {
                mat.color = new Color(0.0902f, 0.3765f, 0.8157f);
            }
            else if (rb.velocity.magnitude <= Force * 0.25 && rb.velocity.magnitude >= Force * 0.1875)//13
            {
                mat.color = new Color(0.1765f, 0.1137f, 0.7216f);
            }
            else if (rb.velocity.magnitude <= Force * 0.1875 && rb.velocity.magnitude >= Force * 0.125)//14
            {
                mat.color = new Color(0.3137f, 0.0353f, 0.7176f);
            }
            else if (rb.velocity.magnitude <= Force * 0.125 && rb.velocity.magnitude >= Force * 0.0625)//15
            {
                mat.color = new Color(0.4627f, 0f, 0.7098f);
            }
            else if (rb.velocity.magnitude <= Force * 0.0625 && rb.velocity.magnitude >= Force * 0)//16
            {
                mat.color = new Color(0.5725f, 0f, 0.6314f);
            }*/
