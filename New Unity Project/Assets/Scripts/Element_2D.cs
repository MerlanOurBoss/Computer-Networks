using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Element_2D : MonoBehaviour
{
    public GameObject element1;
    public Renderer rend;
    public Button button_3D, button_2D;
    public Slider slider;

    // Start is called before the first frame update
    void Start()  // в целом здесь меняется слайдер от 3д на 2д
    {
        rend = element1.GetComponent<Renderer>();
        button_3D.onClick.AddListener(dim_3D);
        button_2D.onClick.AddListener(dim_2D);
        slider.value = 0;
        //rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (slider.value == 0)
        {
            rend.enabled = true;
        }
        if (slider.value == 1)
        {
            if (element1.transform.position.z >= -15 && element1.transform.position.z <= 15)
            {
                rend.enabled = true;
            }
            else
                rend.enabled = false;
        }
       */
       
    }

    void dim_3D()
    {
        slider.value = 0;
    }
    void dim_2D()
    {
        slider.value = 1;
    }
}
