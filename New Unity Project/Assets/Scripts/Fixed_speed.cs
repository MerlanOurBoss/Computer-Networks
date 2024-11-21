using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Fixed_speed : MonoBehaviour
{
    public GameObject cube1, cube2, cube3, cube4, cube5, catalyst;
    public bool ballIsActive;
    public InputField input_pipeD;
    public Rigidbody rb; 
    public Slider speed;
    // Start is called before the first frame update

    float speed1, speed2, speed3, speed4;
    public float speed2_coef = 70f;
    public float speed3_coef = 150f;
    public float speed4_coef = 50f;
    public float radius;

    void Start()
    {
        ballIsActive = false;
        rb = GetComponent<Rigidbody>();

        speed1 = (float)Convert.ToDouble(speed.value * 100);
        speed2 = speed1 * speed2_coef / 100f;
        speed3 = speed1 * speed3_coef / 100f;
        speed4 = speed1 * speed4_coef / 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (input_pipeD.text != "")
            radius = (float)Convert.ToDouble(input_pipeD.text);
    }

    void FixedUpdate()
    {
        /*  rb.AddRelativeForce(100f, 0f, 0f, ForceMode.Acceleration);
          if (!ballIsActive) //условие, он определяет есть ли обьект в сцене
          {//если есть то ему дается скорость

              // а здесь условие меняется так как сила ему дается только один раз, если ее не отключить то обьекту постоянно будет даваться сила в последствии чего скорость его будет постоянно увеличиваться

              rb.AddRelativeForce(100f, 0f, 0f, ForceMode.Acceleration);
              ballIsActive = !ballIsActive;
          }*/
        

        if (transform.position.x < cube1.transform.position.x + cube1.transform.localScale.x / 2)
        {
            if (Math.Sqrt(Math.Pow(transform.position.y - 500f, 2) + Math.Pow(transform.position.z, 2)) > radius - 15f)
            {
                if (rb.velocity.magnitude > speed4)
                {
                    rb.AddRelativeForce(-speed4, 0f, 0f, ForceMode.Acceleration);
                }
                else if (rb.velocity.magnitude < speed4)
                {
                    rb.AddRelativeForce(speed4, 0f, 0f, ForceMode.Acceleration);
                }
            }
            else
            {
                if (rb.velocity.magnitude < speed1)
                {
                    rb.AddRelativeForce(speed1, 0f, 0f, ForceMode.Acceleration);


                }
                else if (rb.velocity.magnitude > speed1)
                {
                    rb.AddRelativeForce(-speed1, 0f, 0f, ForceMode.Acceleration);
                }
            }
        }
        if (transform.position.x > cube1.transform.position.x + cube1.transform.localScale.x / 2 && transform.position.x<cube3.transform.position.x)
        {
            if (rb.velocity.magnitude < speed2)
            {
                rb.AddRelativeForce(speed2, 0f, 0f, ForceMode.Acceleration);
            }
            else if (rb.velocity.magnitude > speed2)
            {
                rb.AddRelativeForce(-speed2, 0f, 0f, ForceMode.Acceleration);
            }
        }
        if (transform.position.x > catalyst.transform.position.x - cube1.transform.localScale.x / 2 && transform.position.x < catalyst.transform.position.x + cube1.transform.localScale.x / 2)
        {
            if (rb.velocity.magnitude < speed3)
            {
                rb.AddRelativeForce(speed3, 0f, 0f, ForceMode.Acceleration);
            }
            else if (rb.velocity.magnitude > speed3)
            {
                rb.AddRelativeForce(-speed3, 0f, 0f, ForceMode.Acceleration);
            }
        }
        if (transform.position.x > cube4.transform.position.x - cube4.transform.localScale.x / 2 && transform.position.x < cube4.transform.position.x)
        {
            if (rb.velocity.magnitude < speed2)
            {
                rb.AddRelativeForce(speed2, 0f, 0f, ForceMode.Acceleration);
            }
            else if (rb.velocity.magnitude > speed2)
            {
                rb.AddRelativeForce(-speed2, 0f, 0f, ForceMode.Acceleration);
            }
        }
        if (transform.position.x > cube4.transform.position.x)
        {
            if (Math.Sqrt(Math.Pow(transform.position.y-500f, 2) + Math.Pow(transform.position.z, 2)) > radius - 15f)
            {
                if (rb.velocity.magnitude > speed4)
                {
                    rb.AddRelativeForce(-speed4, 0f, 0f, ForceMode.Acceleration);
                }
                else if (rb.velocity.magnitude < speed4)
                {
                    rb.AddRelativeForce(speed4, 0f, 0f, ForceMode.Acceleration);
                }
            }
            else
            {
                if (rb.velocity.magnitude < speed1)
                {
                    rb.AddRelativeForce(speed1, 0f, 0f, ForceMode.Acceleration);
                }
                else if (rb.velocity.magnitude > speed1)
                {
                    rb.AddRelativeForce(-speed1, 0f, 0f, ForceMode.Acceleration);
                }
            }
                 
        }
    }
}
