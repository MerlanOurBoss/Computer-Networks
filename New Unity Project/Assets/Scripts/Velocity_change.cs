using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Velocity_change : MonoBehaviour
{

    public GameObject element;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = element.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = element.transform.position.x;
        float y = element.transform.position.y;
        //float speed1 = 100, speed2 = 150;
        float speed = rb.velocity.magnitude;

        if (x>=-560 && x<-200)
        {
            speed = speed * 0.98f;
            rb.velocity = Vector3.right * speed;
        }

        if (x >= -180 && x < 50)
        {
            speed = speed * 1.02f;
            rb.velocity = Vector3.right * speed;
        }

        if (x >= 50 && x < 200)
        {
            speed = speed * 0.99f;
            rb.velocity = Vector3.right * speed;
        }

        if (x >= 200 && x<560)
        {
            speed = speed * 1.02f;
            rb.velocity = Vector3.right * speed;
        }

        if (x >= 560 && x < 800)
        {
            speed = speed * 1.001f;
            rb.velocity = Vector3.right * speed;
        }


        if (x >= -560 && x < -200 && y > 600)  //++
        {
            speed = speed * 0.99f;
            rb.velocity = Vector3.right * speed;
        }

        if (x >= -560 && x < -200 && y > 550 && y < 600)//+
        {
            speed = speed * 0.999f;
            rb.velocity = Vector3.right * speed;
        }

        if (x >= -560 && x < -200 && y < 400)//--
        {
            speed = speed * 0.99f;
            rb.velocity = Vector3.right * speed;
        }

        if (x >= -560 && x < -200 && y < 450 && y > 400)//-
        {
            speed = speed * 0.999f;
            rb.velocity = Vector3.right * speed;
        }
    }
}
