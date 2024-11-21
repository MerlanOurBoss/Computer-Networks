using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Change1 : MonoBehaviour
{

    SphereCollider myCollider;
    public GameObject element1,catalyst,cube1,cube5,cube3,cube4,cube2;
    float x_pos, delta;
    bool logic = false;
    //bool logic1 = false, logic2 = false;
    // Start is called before the first frame update
    void Start()
    {
        myCollider = element1.GetComponent<SphereCollider>();
        myCollider.radius = 0.8f; //начальный размер коллайдера

        delta = 30f; //погрешность
        x_pos = -catalyst.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic)
        {
            if (element1.transform.position.x > cube1.transform.position.x - cube1.transform.localScale.x / 2 && element1.transform.position.x < cube1.transform.position.x + cube1.transform.localScale.x / 2) // это начало входная труба
            {
                myCollider.radius = 0.8f;
            }
            if (element1.transform.position.x > cube1.transform.position.x + cube1.transform.localScale.x / 2 && element1.transform.position.x < cube3.transform.position.x) // первое расширение
            {
                myCollider.radius = 1f;
            }
            if (element1.transform.position.x > cube3.transform.position.x && element1.transform.position.x < cube2.transform.position.x - cube2.transform.localScale.x / 2) // первое расширение
            {
                myCollider.radius = 1.3f;
            }
            if (element1.transform.position.x > cube2.transform.position.x + cube2.transform.localScale.x / 2 && element1.transform.position.x < cube5.transform.position.x - cube5.transform.localScale.x / 2) // сужение
            {
                myCollider.radius = 0.8f;
            }
            if (element1.transform.position.x > cube5.transform.position.x - cube5.transform.localScale.x / 2 && element1.transform.position.x < cube5.transform.position.x + cube5.transform.localScale.x / 2) //конечная труба
            {
                myCollider.radius = 0.6f;
            }
            if (element1.transform.position.x > cube2.transform.position.x - cube2.transform.localScale.x / 2 && element1.transform.position.x < cube2.transform.position.x + cube2.transform.localScale.x / 2) // расщиренная труба
            {
                myCollider.radius = 0.36f;
            }
            if (element1.transform.position.x > x_pos - delta && element1.transform.position.x < -x_pos + delta)// внутри катализатора
            {
                myCollider.radius = 0.02f;
            }
        }
    }
}
