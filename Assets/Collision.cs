using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision collisionInfo){


        if (collisionInfo.collider.tag == "Pipe"){
            Debug.Log("hi");
        }

    }

    // Update is called once per frame
   
}
