using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DestroyCubeAndCatalyst : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button_delete;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        button_delete.onClick.AddListener(Button_Delete);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Button_Delete()
    {

        Destroy_Shell();

    }
    void Destroy_Shell()
    {
        if (cube.name.Contains("Clone"))
        {
            Destroy(cube);
            //Debug.Log("Deleted");
        }
    }
}
