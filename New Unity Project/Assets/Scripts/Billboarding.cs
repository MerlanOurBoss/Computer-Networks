using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System;
//using Random = System.Random;

public class Billboarding : MonoBehaviour
{
    // Start is called before the first frame update
    /*  void Start()
       {

       }

       float speed = 50f;
       // Update is called once per frame
       void LateUpdate()
       {
           //transform.Rotate(0f,0f,1f* speed * Time.deltaTime, Space.World);
           //transform.LookAt(Camera.main.transform.position);
           //transform.Rotate(Vector3.up, Vector3.back);
           //transform.Rotate(Vector3.back);
           // transform.forward = new Vector3(Camera.main.transform.forward.x, transform.forward.y, Camera.main.transform.forward.z);

           transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
       }

       */
    public Transform sphere;

    void Start()
    {

    }

    private void Update()
    {
        transform.LookAt(sphere);
       // transform.Rotate(0, 0, speed += Random.Range(0f,2f));
    }

}
