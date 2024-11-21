using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Force : MonoBehaviour
{

    public GameObject cat1, cat2, element1;
    public Rigidbody rb;
    float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = element1.GetComponent<Rigidbody>();
        force = rb.velocity.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        force = rb.velocity.magnitude;
    }

    private void OnTriggerEnter(Collider other)
    {
        rb.AddForce(force*10,0,0, ForceMode.VelocityChange);
    }
}
