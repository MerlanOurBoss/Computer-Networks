using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Catalyst_count : MonoBehaviour
{
    public Slider blocks;
    public GameObject cat;
    public GameObject cube2;
   
    public Button bt_create;
    // Start is called before the first frame update
    void Start()
    {
        bt_create.onClick.AddListener(Create);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void Create()
    {

        if (blocks.value == 1)
        {
            //cube2.transform.localScale=new Vector3()
            Instantiate(cat, new Vector3(45, 500f, 0), Quaternion.identity);
        }
        if (blocks.value == 2)
        {
            float scale = 0;
            scale = cube2.transform.localScale.x - 90 * 2;
            //cube2.transform.localScale=new Vector3()
            Instantiate(cat, new Vector3( - 2.5f, 500f, 0), Quaternion.identity);
            Instantiate(cat, new Vector3(  92.5f, 500f, 0), Quaternion.identity);
        }
        if (blocks.value == 3)
        {
            //cube2.transform.localScale=new Vector3()
            Instantiate(cat, new Vector3(- 47.5f, 500f, 0), Quaternion.identity);
            Instantiate(cat, new Vector3( 45, 500f, 0), Quaternion.identity);
            Instantiate(cat, new Vector3( 137.5f, 500f, 0), Quaternion.identity);
        }
        if (blocks.value == 4)
        {
            //cube2.transform.localScale=new Vector3()
            Instantiate(cat, new Vector3( -95f , 500f, 0), Quaternion.identity);
            Instantiate(cat, new Vector3( - 2.5f, 500f, 0), Quaternion.identity);
            Instantiate(cat, new Vector3( 92.5f, 500f, 0), Quaternion.identity);
            Instantiate(cat, new Vector3( 185f, 500f, 0), Quaternion.identity);
        }
        
    }

    
}
