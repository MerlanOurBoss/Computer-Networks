using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class Cubes_Rotate_Invisible : MonoBehaviour
{
    public GameObject cube;
    public Button create_button;
    public Text angle_text;
    public Material mat_glass;
    public Renderer rend;
    bool Paused = false;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        create_button.onClick.AddListener(Button_Click);
        rend = GetComponent<Renderer>();
        rend.enabled = false;
        // делает его полностью невидимым

        if (cube.name.Contains("Cube1") && cube.name.Contains("Clone") || cube.name.Contains("Cube5") && cube.name.Contains("Clone"))
        {
            float angle = (float)Math.Asin(cube.transform.position.z / (float)Math.Sqrt((float)Math.Pow(cube.transform.position.z, 2) + (float)Math.Pow(cube.transform.position.y - 500f, 2)));  // угол вычесляется взависимости от распложения
            angle = angle * 180 / (float)Math.PI;

            float angle2 = 0;

            if (cube.transform.position.y < 500)
                cube.transform.Rotate(180 - angle, 0, angle2);
            if (cube.transform.position.y > 500)
                cube.transform.Rotate(angle, 0, angle2);
            if (cube.transform.position.y == 500)
                cube.transform.Rotate(90f, 0, angle2);

            /*if (angle >= -1 && angle <= 1 || angle >= 179 && angle <= 181)
            {
                rend.enabled = true;
            }*/
            if (angle >= 1 && angle <= 180)
            {
                rend.enabled = true;
            }
        }

        if (cube.name.Contains("Cube2") && cube.name.Contains("Clone"))
        {
            float angle = (float)Math.Asin(cube.transform.position.z / (float)Math.Sqrt((float)Math.Pow(cube.transform.position.z, 2) + (float)Math.Pow(cube.transform.position.y - 500f, 2)));  // угол вычесляется взависимости от распложения
            angle = angle * 180 / (float)Math.PI;

            float angle2 = 0;

            if (cube.transform.position.y < 500)
                cube.transform.Rotate(180 - angle, 0, angle2);
            if (cube.transform.position.y > 500)
                cube.transform.Rotate(angle, 0, angle2);
            if (cube.transform.position.y == 500)
                cube.transform.Rotate(90f, 0, angle2);


            if (angle >= 1 && angle <= 180)
            {
                rend.enabled = true;
            }
        }

        if (cube.name.Contains("Cube3") && cube.name.Contains("Clone"))
        {
            float angle = (float)Math.Asin(cube.transform.position.z / (float)Math.Sqrt((float)Math.Pow(cube.transform.position.z, 2) + (float)Math.Pow(cube.transform.position.y - 500f, 2)));  // угол вычесляется взависимости от распложения
            angle = angle * 180 / (float)Math.PI;

            //float angle2 = 9f;
            float angle2 = (float)Convert.ToDouble(angle_text.text);

            if (cube.transform.position.y < 500)
                cube.transform.Rotate(180 - angle, 0, angle2);
            if (cube.transform.position.y > 500)
                cube.transform.Rotate(angle, 0, angle2);
            if (cube.transform.position.y == 500)
                cube.transform.Rotate(90f, 0, angle2);

            if (angle >= 1 && angle <= 180)
            {
                rend.enabled = true;
            }
        }

        if (cube.name.Contains("Cube4") && cube.name.Contains("Clone"))
        {
            float angle = (float)Math.Asin(cube.transform.position.z / (float)Math.Sqrt((float)Math.Pow(cube.transform.position.z, 2) + (float)Math.Pow(cube.transform.position.y - 500f, 2)));  // угол вычесляется взависимости от распложения
            angle = angle * 180 / (float)Math.PI;

            float angle2 = 180f - (float)Convert.ToDouble(angle_text.text);

            if (cube.transform.position.y < 500)
                cube.transform.Rotate(180 - angle, 0, angle2);
            if (cube.transform.position.y > 500)
                cube.transform.Rotate(angle, 0, angle2);
            if (cube.transform.position.y == 500)
                cube.transform.Rotate(90f, 0, angle2);

            if (angle >= 1 && angle <= 180)
            {
                rend.enabled = true;
            }

        }

        if (cube.name.Contains("Cube") && cube.name.Contains("(1)"))
        {
            rend.enabled = false;
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

    void Destroy_Shell()
    {
        if (cube.name.Contains("Clone"))
        {
            Destroy(cube);
            //Debug.Log("Deleted");
        }
    }
    void Button_Click()
    {
        start = true;
    }

    // Update is called once per frame
    void Update()
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
                //Debug.Log("I'm in");
                Destroy_Shell(); //удалить при нажатии на пробел
                start = false;
            }
        }
    }
}
