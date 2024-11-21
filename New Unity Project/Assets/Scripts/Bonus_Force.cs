using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus_Force : MonoBehaviour
{
    public GameObject element;
    Rigidbody rb;

    bool ballIsActive;
    // Start is called before the first frame update
    void Start()
    {
        rb = element.GetComponent<Rigidbody>();
        ballIsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ballIsActive)
        {
            float x = element.transform.position.x;
            float y = element.transform.position.y;

            float speed = rb.velocity.magnitude;

            if (x >= -560 && x < -200 && y>600)  //++
            {
                rb.AddForce(0, speed*0.12f, 0, ForceMode.Impulse);
                //ballIsActive = !ballIsActive;
            }

            if (x >= -560 && x < -200 && y > 550 && y<600)//+
            {
                rb.AddForce(0, speed * 0.06f, 0, ForceMode.Impulse);
                //ballIsActive = !ballIsActive;
            }

            if (x >= -560 && x < -200 && y < 400)//--
            {
                rb.AddForce(0, -speed * 0.12f, 0, ForceMode.Impulse);
                //ballIsActive = !ballIsActive;
            }

            if (x >= -560 && x < -200 && y < 450 && y>400)//-
            {
                rb.AddForce(0, -speed * 0.06f, 0, ForceMode.Impulse);
                //ballIsActive = !ballIsActive;
            }



            if (x >= 200 && x < 300 && y > 550)
            {
                rb.AddForce(0, -speed * 0.1f, 0, ForceMode.Impulse);
                //ballIsActive = !ballIsActive;
            }
            if (x >= 200 && x < 300 && y < 450)
            {
                rb.AddForce(0, speed * 0.1f, 0, ForceMode.Impulse);
                //ballIsActive = !ballIsActive;
            }
        }
    }
}
