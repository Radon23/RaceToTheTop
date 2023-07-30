using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBird : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float velocity = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   if (Input.GetMouseButtonDown(0)){
        rb.velocity = Vector2.up * velocity;
    
        }
    }

}
