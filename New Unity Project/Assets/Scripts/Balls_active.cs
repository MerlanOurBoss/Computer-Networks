using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Balls_active : MonoBehaviour
{
    public bool ballIsActive;
    public Rigidbody rb;
    private float Force;
    public InputField input_speed;
    public double curr_time;
    public double time = 0;
    public bool logic = false;
    double rand = 0;
    //public Button button1;

    public Slider speed;

    void Start()
    {
        ballIsActive = false;     
        rb = GetComponent<Rigidbody>();
        curr_time = 0;
        //button1.onClick.AddListener(GetInputOnClickHandler);
    }

    void Update()
    {
        //Force = (float)Convert.ToDouble(input_speed.text);//здесь вы записываем силу которой будет обладать элемент, он считывает его с поля SPEED
        //if (input_speed.text != null) // условие при котором текстовое поле Скорость не должна быть пуста
        Force = (float)Convert.ToDouble(speed.value*100);//здесь вы записываем силу которой будет обладать элемент, он считывает его с поля SPEED
        if (speed.value != 0) // условие при котором текстовое поле Скорость не должна быть пуста
        {
            if (!ballIsActive) //условие, он определяет есть ли обьект в сцене
            {//если есть то ему дается скорость
                rb.AddForce(Force, 0, 0, ForceMode.Impulse);
                //rb.AddForce(Force, 0, 0);
                ballIsActive = !ballIsActive;// а здесь условие меняется так как сила ему дается только один раз, если ее не отключить то обьекту постоянно будет даваться сила в последствии чего скорость его будет постоянно увеличиваться
            }
        }

        if (logic)//чтобы включить: "!logic" в данный момент отключен, вся процедура необходима для того чтобы задавать хаотичное движение элементам
        {
            time = UnityEngine.Random.Range(0, 10);
            curr_time += Time.deltaTime; //прибавляем к нашей переменной настоящее время, посекундно
            if (curr_time >= time) //если время превыщает заданное число, оно обнуляется в конце и цикл начинается заново, что и обеспечивает постоянный прикток элементов
            {
                Force = Force / 5;
                rand = UnityEngine.Random.Range(0, 5);
                if (rand == 5)
                {
                    rb.AddForce(Force, 0, 0, ForceMode.Impulse);
                }
                else if (rand == 4)
                {
                    rb.AddForce(0, Force, 0, ForceMode.Impulse);
                }
                else if (rand == 3)
                {
                    rb.AddForce(0,0, Force, ForceMode.Impulse);
                }
                else if (rand == 2)
                {
                    //rb.AddForce(Force, 0, 0, ForceMode.Impulse);
                }
                else if (rand == 1)
                {
                    rb.AddForce(0, -Force, 0, ForceMode.Impulse);
                }
                else if (rand == 0)
                {
                    rb.AddForce(0, 0, -Force, ForceMode.Impulse);
                }
                curr_time = 0;
            }
            //logic = !logic;
        }
    }
}
