using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed;
    private Vector2 inputdirection;
    private Rigidbody2D rd;

    // Start is called before the first frame update
    void Start()
    {
        rd= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputy = Input.GetAxisRaw("Vertical");
       inputdirection = new Vector2(0,inputy). normalized ;
    }
    void FixedUpdate()
    {
        rd.velocity= new Vector2(0, inputdirection.y * movespeed);  
    }
}

