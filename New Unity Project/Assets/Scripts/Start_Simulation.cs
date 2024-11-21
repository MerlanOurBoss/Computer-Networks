using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Start_Simulation : MonoBehaviour
{
    public Button button_start, button_reset;
    public GameObject element, cube1;

    public double curr_time; // необходима для того чтобы запускать процесс бесконечно
    public double logic;
    public bool start = false;
    public InputField input_pipeD;
    public InputField input_speed;
    public InputField input_count;
    public InputField input_time;

    //public Slider speed;

    public int count = 0;
    public double time = 0;

    public float y, z, x0, y0, z0;
    public float radius;

    bool Paused = false;

    void Start()
    {
        button_start.onClick.AddListener(Start_process); //здесь задается функция после нажатия на Button котороая становиться активной, 
        button_reset.onClick.AddListener(Reset);

        curr_time = 0; // назначаем ей число 0
        logic = 0;

        for (int i = 0; i < 5; i++)
        {
            //Instantiate(element1, new Vector3(0, 500, 0), Quaternion.identity);
        }

        x0 = cube1.transform.position.x - cube1.transform.localScale.x / 2;
        y0 = element.transform.position.y;
        z0 = element.transform.position.z;

    }

    void Update() // эта функция работает всегда, как запускается скрипт
    {
        if (input_pipeD.text != "" && input_speed.text != "" && input_count.text != "" && input_time.text != "")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!Paused)
                {
                    Pause();
                }
                else
                {
                    Resume();
                }
            }
            if (!Paused)
            {
                if (start)
                {
                    radius = (float)Convert.ToDouble(input_pipeD.text)-15f;
                    //Start_process();
                }
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    Reset();
                }
            }


            if (start)
            {
                string str_input_time = input_time.text;
                str_input_time = str_input_time.Replace(".", ",");
                time = Convert.ToDouble(str_input_time);

                curr_time += Time.deltaTime; //прибавляем к нашей переменной настоящее время, посекундно
                if (curr_time >= time) //если время превыщает заданное число, оно обнуляется в конце и цикл начинается заново, что и обеспечивает постоянный прикток элементов
                {
                    while (count < Convert.ToInt32(input_count.text))
                    {
                        y = UnityEngine.Random.Range(y0 - radius, y0 + radius);
                        z = UnityEngine.Random.Range(z0 - radius, z0 + radius);


                        if (Math.Sqrt(Math.Pow(y - y0, 2) + Math.Pow(z - z0, 2)) < radius) // если случайно выбранные координаты не привыщают радиус то они пояляются на сцене
                        {
                            Instantiate(element, new Vector3(x0, y, z), Quaternion.identity); //область где создаются наши новые элементы
                                                                                              //Debug.LogWarning("hi="+Convert.ToString(dd1.options[1].text));
                            count++;
                        }
                    }
                    curr_time = 0;
                    count = 0;
                }

            }
        }
    }

    void Resume()
    {
        Paused = false;
    }

    void Pause()
    {
        Paused = true;
    }

    public void Start_process() // сама функция отвечает только за одно действие, изменение логической переменной Start
    {
        if (input_pipeD.text != "" && input_speed.text != "" && input_count.text != "" && input_time.text != "")
        {
            start = true;
        }
    }

    public void Reset()
    {
        if(start)
        {
            start = false;
        }
    }
}
