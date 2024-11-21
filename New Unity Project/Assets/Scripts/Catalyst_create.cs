using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Catalyst_create : MonoBehaviour
{
    public GameObject catalyst1, catalyst2;
    int size;
    public Slider slider_degree;
    public Slider slider_col;
    public Text dlina;
    public float dlinaf;

    public Button button;
    public InputField diameter;
    bool start = false;

    float x0, y0, z0;

    float R = 150f;
    float x1, y1, z1;
    float xc1, yc1, zc1;

    float x2, y2, z2;
    float xc2, yc2, zc2;

    float d, k1, k2;
    float phi1, phi11;
    float rho1;

    float phi2, phi22;
    float rho2;

    float l1 = 0;
    float l2 = 0;

    float temp, temp2;

    float a = 90f, b = 0.1f;

    bool Paused = false;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        /*cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(x0, y0, z0);
        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(x0, y0, z0);
        */

        button.onClick.AddListener(Button_Click);



        // d = 1f;
        //  k1 = d * (float)Math.PI - b / 2; //вверх вниз, не трогать
        // k2 = 0.1f;//в сторону, чем меньше тем дальше


    }

    void Create_catalyst(float x0)
    {

        size = Convert.ToInt32(slider_col.value);


        if (size == 1)
        {
            d = 0.5f;
            k1 = d * (float)Math.PI - b / 2; //вверх вниз, не трогать
            k2 = 0.2f;//в сторону, чем меньше тем дальше
        }
        else if (size == 2)
        {
            d = 0.6f;
            k1 = d * (float)Math.PI - b / 2; //вверх вниз, не трогать
            k2 = 0.2f;//в сторону, чем меньше тем дальше
        }
        else if (size == 3)
        {
            d = 0.7f;
            k1 = d * (float)Math.PI - b / 2; //вверх вниз, не трогать
            k2 = 0.2f;//в сторону, чем меньше тем дальше
        }
        else if (size == 4)
        {
            d = 0.8f;
            k1 = d * (float)Math.PI - b / 2; //вверх вниз, не трогать
            k2 = 0.2f;//в сторону, чем меньше тем дальше
        }
        else if (size == 5)
        {
            d = 1.5f;
            k1 = d * (float)Math.PI - b / 2; //вверх вниз, не трогать
            k2 = 0.2f;//в сторону, чем меньше тем дальше
        }

       
        
        /*
        //cube.transform.position = new Vector3(0, 0, 0);
        curr_time += Time.deltaTime; //прибавляем к нашей переменной настоящее время, посекундно
        if (curr_time >= time && (float)Math.Sqrt((float)Math.Pow(z1-z0,2) + (float)Math.Pow(y1 - y0, 2)) <= R) //если время превыщает заданное число, оно обнуляется в конце и цикл начинается заново, что и обеспечивает постоянный прикток элементов
        {
        */


        //start spiral ARKHIMED

        //phi1 += 3 * (float)Math.PI / 360;
        dlina.text = "";
        dlinaf = 0f;

        y0 = 500f;
        z0 = 0;

        phi1 = 0;
        rho1 = 0;

        x1 = x0;
        y1 = y0;
        z1 = z0;

        xc1 = 0;
        yc1 = 0;
        zc1 = 0;

        phi2 = 0;
        rho2 = 0;

        x2 = x0;
        y2 = y0;
        z2 = z0;

        xc2 = 0;
        yc2 = 0;
        zc2 = 0;

        temp = 0;
        temp2 = 0;

        R = (float)Convert.ToDouble(diameter.text);

        while ((float)Math.Sqrt((float)Math.Pow(z1 - z0, 2) + (float)Math.Pow(y1 - y0, 2)) <= R)
        {
            rho1 = d * temp + (float)Math.PI * d * (float)Math.Sin(90 * (float)Math.PI / 180);
            //rho1 = (float)Math.PI * d * (float)Math.Sin(90 * (float)Math.PI / 180);

            
            x1 = x0;
            y1 = y0 + rho1 * (float)Math.Cos(temp);
            z1 = z0 + rho1 * (float)Math.Sin(temp);

            float xr1, yr1, zr1;
            xr1 = xc1 - x1;
            yr1 = yc1 - y1;
            zr1 = zc1 - z1;
            l1 = (float)Math.Sqrt(xr1 * xr1 + yr1 * yr1 + zr1 * zr1);

            float arctg1 = (float)Math.Atan(yr1 / zr1) * 180 / (float)Math.PI;

            if (l1 < 10f)
            {

                Vector3 rot1 = transform.rotation.eulerAngles;
                rot1.x = -arctg1;


                Instantiate(catalyst1, new Vector3((xc1 + x1) / 2, (yc1 + y1) / 2, (zc1 + z1) / 2), Quaternion.Euler(rot1));
                catalyst1.transform.localScale = new Vector3(a, b, l1 + 0.05f);
                dlinaf += l1;

                //cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                counter++;
                //catalyst1.transform.position = new Vector3((xc1 + x1) / 2, (yc1 + y1) / 2, (zc1 + z1) / 2);
                //catalyst1.transform.rotation = Quaternion.Euler(rot1);
                //catalyst1.transform.localScale = new Vector3(a, b, l1 + 0.01f);
            }

            xc1 = x1;
            yc1 = y1;
            zc1 = z1;

            phi1 += (float)Math.PI / 90;
            phi11 = (float)Math.Sqrt(phi1) * (float)Math.PI;

            temp = phi11;

            //sinusoida
            rho2 = d * temp2 + k1 * (float)Math.Sin(temp * temp2 * k2);


            x2 = x0;
            y2 = y0 + rho2 * (float)Math.Cos(temp2);
            z2 = z0 + rho2 * (float)Math.Sin(temp2);

            //Instantiate(cube2, new Vector3(x2, y2, z2), Quaternion.identity);


            float xr2, yr2, zr2;
            xr2 = xc2 - x2;
            yr2 = yc2 - y2;
            zr2 = zc2 - z2;
            l2 = (float)Math.Sqrt(xr2 * xr2 + yr2 * yr2 + zr2 * zr2);

            float arctg2 = (float)Math.Atan(yr2 / zr2) * 180 / (float)Math.PI;

            if (l2 < 10f)
            {
                Vector3 rot2 = transform.rotation.eulerAngles;
                rot2.x = -arctg2;
                //cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                counter++;
                // catalyst2.transform.position = new Vector3((xc2 + x2) / 2, (yc2 + y2) / 2, (zc2 + z2) / 2);
                //  catalyst2.transform.rotation = Quaternion.Euler(rot2);
                // catalyst2.transform.localScale = new Vector3(a, b, l2 + 0.01f);


                Instantiate(catalyst2, new Vector3((xc2 + x2) / 2, (yc2 + y2) / 2, (zc2 + z2) / 2), Quaternion.Euler(rot2));
                catalyst2.transform.localScale = new Vector3(a, b, l2 + 0.05f);
                dlinaf += l2;
                //Instantiate(cube2, new Vector3((xc2 + x2) / 2, (yc2 + y2) / 2, (zc2 + z2) / 2), Quaternion.Euler(rot2));

            }

            xc2 = x2;
            yc2 = y2;
            zc2 = z2;

            phi2 += (float)Math.PI / 90;
            phi22 = (float)Math.Sqrt(phi2) * (float)Math.PI;

            temp2 = phi22;

            // curr_time = 0;
        }

        // dlina.text = dlinaf.ToString();
    }
    void Resume()
    {
        Paused = false;
    }

    void Pause()
    {
        Paused = true;
    }

    // Update is called once per frame
    void Update()
    {
        /* if (diameter.text != "")
             if (start)
             {
                 Create_catalyst();
                 start = !start;
             }

         */




        if (diameter.text != "")
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
                //if (start)
                //{
                //if (diameter.text != "")
                //{
                if (start)
                {

                    if (slider_degree.value == 1)
                    {
                        Create_catalyst(0);
                    }
                    if (slider_degree.value == 2)
                    {
                        Create_catalyst(-47.5f);
                        Create_catalyst(47.5f);
                    }
                    if (slider_degree.value == 3)
                    {
                        Create_catalyst(-92.5f);
                        Create_catalyst(0);
                        Create_catalyst(92.5f);
                    }
                    if (slider_degree.value == 4)
                    {
                        Create_catalyst(-140f);
                        Create_catalyst(-47.5f); 
                        Create_catalyst(47.5f);
                        Create_catalyst(140f);
                    }


                    //Create_catalyst(x0);
                    start = false;
                } // }
                  // start = false;
                  //}
            }

        }
        /* if(!del)
         {
             while(cube1)
                 Destroy(GameObject.Find("Cube"));
         }
        */
    }

    void Button_Click()
    {
        // if (diameter.text != "")
        // if (!start)
        //start = true;
        if (!start)
        {
            start = true;
        }
    }

}
