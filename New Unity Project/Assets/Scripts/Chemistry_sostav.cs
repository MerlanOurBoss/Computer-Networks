using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = System.Random;

public class Chemistry_sostav : MonoBehaviour
{
    public GameObject element1,element2;
    //public Slider slider;
    int degree;

    bool onetime=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Replace(GameObject el1, GameObject el2)
    {
    Vector3 el1_tform = el1.transform.position;
     Destroy (el1);
     Instantiate (el2, el1_tform, Quaternion.identity);
   
    }

    void OnCollisionEnter(Collision myCollision) {
  // определение столкновения с двумя разноименными объектами
  if (myCollision.gameObject.name.Contains("Cube Catalyst")) {  
      // Обращаемся к имени объекта с которым столкнулись  
      //Debug.Log("Hit the catalyst");
      if(!onetime)
      {
      Replace(element1,element2);
      onetime=!onetime;
      }

    }
  }
}

