﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScripts : MonoBehaviour
{
    public float speed = 5f;
    public float deactive_time = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DectiveObject", deactive_time);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 temp = transform.position;
        temp.x +=speed*Time.deltaTime;
        transform.position = temp;

        
    }
    void DectiveObject()
    {
        gameObject.SetActive(false);
        
    }
}

