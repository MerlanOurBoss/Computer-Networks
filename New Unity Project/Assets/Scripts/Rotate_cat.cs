using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Rotate_cat : MonoBehaviour
{
    public GameObject cat;
    public GameObject cube;
    float angle;
    public InputField diameter2;
    public Slider blocks;
    public Button bt_delete;
    // Start is called before the first frame update
    void Start()
    {
        bt_delete.onClick.AddListener(DeleteClick);

        if (cat.name.Contains("Clone"))
        {
            if (diameter2.text != "")
            {
                cat.transform.Rotate(0, 0, 90);

                float d2 = (float)Convert.ToDouble(diameter2.text);
                float d = d2 / 50f;
                cat.transform.localScale = new Vector3(d,1,d);
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DeleteClick()
    {
        if (cat.name.Contains("Clone"))
        {
            Destroy(cat);
        }
        else
        {

        }
    }
}
