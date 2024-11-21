using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collider_Change2 : MonoBehaviour
{

    SphereCollider myCollider;
    public GameObject element1, catalyst, cube1, cube5, cube3, cube4, cube2;
    float x_pos;
    bool logic = false;
    //bool logic1 = false, logic2 = false;
    // Start is called before the first frame update
    void Start()
    {
        myCollider = element1.GetComponent<SphereCollider>();
        myCollider.radius = 0.4f; //начальный размер коллайдера

        //delta = 30f; //погрешность
        x_pos = -catalyst.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic)
        {
            if (element1.transform.position.x > cube2.transform.position.x - cube2.transform.localScale.x / 2 && element1.transform.position.x < cube2.transform.position.x + cube2.transform.localScale.x / 2) // расщиренная труба
            {
                myCollider.radius = 0.01f;
            }
            else
            {
                myCollider.radius = 0.4f;
            }
        }
    }
}
