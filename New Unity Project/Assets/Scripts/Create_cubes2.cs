using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class Create_cubes2 : MonoBehaviour
{
    public GameObject cube1, cube2, cube3, cube4, cube5;
    public Button create_button;
    //bool l = false;

    bool Paused = false;

    public InputField diameter1;
    public InputField diameter2;
    //float offer_diameter;
    public Text angle_text;
    bool start = false;
    public Slider blocks;
    // Start is called before the first frame update
    void Start()
    {
        create_button.onClick.AddListener(Button_Click);
        //offer_diameter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (diameter1.text != "" && diameter2.text != "" && (float)Convert.ToDouble(diameter2.text) >= (float)Convert.ToDouble(diameter1.text))
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
                    if (diameter1.text != "" && diameter2.text != "")
                    {
                        Create_Shell();
                    }
                    start = false;
                }
            }

        }
    }

    void Create_Shell()
    {
        float n = 500f;   //количество
        float a = 5f;
        float r = (float)Convert.ToDouble(diameter1.text) + 2*a;  // внутренний радиус      
        float R = (float)Convert.ToDouble(diameter2.text) + 2*a;  //радиус 
        float alfa = 180 - (n - 2) / n * 180;
        float a1 = 2 * (float)Math.PI * r / n;
        float a2 = 2 * (float)Math.PI * R / n;


        Vector3 position_cube1 = cube1.transform.position;
        Vector3 scale_cube1 = cube1.transform.localScale;
        float pos_1 = position_cube1.x;
        float scale_1 = scale_cube1.x;

        cube1.transform.localScale = new Vector3(scale_cube1.x + a / 5, a, a);
        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = r * (float)Math.Cos(t);
            float y = r * (float)Math.Sin(t) + 500f;
            Instantiate(cube1, new Vector3(position_cube1.x, y, x), Quaternion.identity);
        }

        Vector3 position_cube5 = cube5.transform.position;
        Vector3 scale_cube5 = cube5.transform.localScale;
        float pos_5 = position_cube5.x;
        float scale_5 = scale_cube5.x;

        cube5.transform.localScale = new Vector3(scale_cube5.x + a / 5, a, a);
        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = r * (float)Math.Cos(t);
            float y = r * (float)Math.Sin(t) + 500f;
            Instantiate(cube5, new Vector3(position_cube5.x, y, x), Quaternion.identity);
        }



        Vector3 position_cube2 = cube2.transform.position;
        Vector3 scale_cube2 = cube2.transform.localScale;
        float pos_2 = position_cube2.x;
        float scale_2 = 90 * (blocks.value + 1);

        cube2.transform.localScale = new Vector3(100 * (blocks.value + 1), a, a);
        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = R * (float)Math.Cos(t);
            float y = R * (float)Math.Sin(t) + 500f;
            Instantiate(cube2, new Vector3(position_cube2.x, y, x), Quaternion.identity);
        }


        Vector3 position_cube3 = cube3.transform.position;
        Vector3 scale_cube3 = cube3.transform.localScale;
        //pos_3 = position_cube3.x;
        //scale_3 = scale_cube3.x;

        float pos_x1 = (pos_1 + scale_1 / 2 - scale_2 / 2) / 2;
        //float scale_x1 = (float)Math.Sqrt(Math.Pow(pos_1 + scale_1 + scale_2, 2) + Math.Pow(R - r, 2));
        float scale_x = (float)Math.Sqrt(Math.Pow(scale_2 / 2 - (pos_5 - scale_5 / 2), 2) + Math.Pow(R - r, 2));

        float rR = (R + r) / 2;
        float arR = 2 * (float)Math.PI * rR / n;
        cube3.transform.localScale = new Vector3(scale_x, a, a);
        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = rR * (float)Math.Cos(t);
            float y = rR * (float)Math.Sin(t) + 500f;
            Instantiate(cube3, new Vector3(pos_x1, y, x), Quaternion.identity);
        }


        Vector3 position_cube4 = cube4.transform.position;
        Vector3 scale_cube4 = cube4.transform.localScale;
        //pos_3 = position_cube3.x;
        //scale_3 = scale_cube3.x;

        float pos_x2 = (pos_5 - scale_5 / 2 + scale_2 / 2) / 2;
        //float scale_x2 = (float)Math.Sqrt(Math.Pow(pos_5 + scale_5 + scale_2, 2) + Math.Pow(R - r, 2));

        // float rR = (R + r) / 2;
        // float arR = 2 * (float)Math.PI * rR / n;
        cube4.transform.localScale = new Vector3(scale_x, a, a);
        for (int i = 0; i < n; i++)
        {
            float t = alfa * (float)Math.PI / 180 * i;
            float x = rR * (float)Math.Cos(t);
            float y = rR * (float)Math.Sin(t) + 500f;
            Instantiate(cube4, new Vector3(pos_x2, y, x), Quaternion.identity);
        }

        angle_text.text = Convert.ToString(Math.Atan(Math.Abs(R - r) / (Math.Abs(pos_1 + scale_1 / 2 - pos_2 + scale_2 / 2))) * 180 / (float)Math.PI);
        //angle_text.text = "9";
    }

    void Resume()
    {
        Paused = false;
    }

    void Pause()
    {
        Paused = true;
    }

    void Button_Click()
    {
        if (!start)
        {
            if (diameter1.text != "" && diameter2.text != "")
            {
                start = true;
            }
        }
    }
}
